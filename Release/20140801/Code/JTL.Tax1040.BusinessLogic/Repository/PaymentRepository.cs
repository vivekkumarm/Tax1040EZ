
/*
Copyright   : Copyright Jeevan Technologies
File Name   : PaymentRepository.cs 
Description : Payment Repository  
Author      : Sathish 
Created Date : 12May2014

 * Modification History:
 * Thileep Changed StreetAddress,Phonenovalidation in Orderbusinessvalidation method 02July2014
 * Sathish 25Jul2014 changed IRSPaymentOption enum to PaymentOption
------------------------
 */

using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.DataAccess;
using Newtonsoft.Json;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;

namespace JTL.Tax1040.BusinessLogic
{
    public class PaymentRepository : IPaymentRepository
    {
        IPaymentDataService paymentDataService;
        IUserRepository userrepository;
        IEmailRepository emailRepository;
        BusinessObject.Tax1040 taxObject;
        private readonly string email_image_link = ConfigurationManager.AppSettings[Constants.Tax1040ImageUrl];
        MessagesRepository messageRepository;

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxReturnRepository"/> class.
        /// </summary>
        public PaymentRepository()
        {
            messageRepository = new MessagesRepository();
            paymentDataService = new PaymentDataService();
            userrepository = new UserRepository();
            emailRepository = new EmailRepository();
        }
        #endregion

        #region Get





        public System.Tuple<double, Person, string> GetPaymentDetails(UserDTO userDTO)
        {
            //Retreiving TaxObject from database
            System.Tuple<double, Person, string> paymentDetails = null;
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                // TODO : Need to call workflow to get get Total Due

                paymentDetails = new System.Tuple<double, Person, string>(500, ((taxObject.PersonalDetails != null &&
                                                                        taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                                                                        taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                                                                        ? taxObject.PersonalDetails.PrimaryTaxPayer.Person : null),
                                                                        userrepository.GetEmailByUserId(userDTO.UserId));
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:PaymentRepository,Method Name:GetPaymentDetails", ex);
            }
            return paymentDetails;
        }


        public Order GetOrderByOrderId(PaymentDTO paymentDTO)
        {
            Order order = null;
            try
            {
                order = paymentDataService.GetOrderByOrderId(paymentDTO);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(paymentDTO.UserId, "Class:PaymentRepository,Method Name:GetOrderByOrderId", ex);
            }
            return order;
        }

        //Created by Yogalakshmi on 15th May 2014
        public List<ProductSKU> GetAllProductSKU()
        {
            //try
            //{
            return paymentDataService.GetAllProductSKU((long)ProductType.Form1040EZ);
            //}
            //catch (Exception ex)
            //{
            //   // ExceptionHandling.LogException(userId, "Class:PaymentRepository,Method Name:GetInvoiceDetails", ex);
            //}
        }

        public List<ProductSKU> GetProductSKUbyStateIDs(PaymentDTO paymentDTO)
        {
            List<ProductSKU> productSKUbyStateIDs = null;
            try
            {
                paymentDTO.ProductType = ProductType.Form1040EZ;
                productSKUbyStateIDs = paymentDataService.GetProductSKUbyStateIDs(paymentDTO);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(paymentDTO.UserId, "Class:PaymentRepository,Method Name:GetProductSKUbyStateIDs", ex);
            }
            return productSKUbyStateIDs;

        }


        public double GetOrderAmount(PaymentDTO paymentDTO)
        {
            double orderAmount = 0;
            try
            {
                paymentDTO.ProductType = ProductType.Form1040EZ;
                orderAmount = paymentDataService.GetOrderAmount(paymentDTO);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(paymentDTO.UserId, "Class:PaymentRepository,Method Name:GetOrderAmount", ex);
            }
            return orderAmount;
        }

        public List<CreditCardType> GetAllCreditCardType()
        {
            return paymentDataService.GetAllCreditCardType();
        }

        //15Jul2014 Sathish added get user feature sku
        public ShoppingCart GetUserFeatureSKU(PaymentDTO paymentDTO)
        {
            ShoppingCart shoppintCart = null;
            try
            {
                paymentDTO.ProductType = ProductType.Form1040EZ;
                shoppintCart = paymentDataService.GetUserFeatureSKU(paymentDTO);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(paymentDTO.UserId, "Class:PaymentRepository,Method Name:GetUserFeatureSKU", ex);
            }
            return shoppintCart;
        }

        #endregion

        #region Persist

        public Tuple<long, List<ErrorMessage>> OrderPersist(PaymentDTO paymentDTO)
        {
            Tuple<long, List<ErrorMessage>> orderPersist = null;
            try
            {
                //Retrieving Error Message list from Database
                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);
                List<ErrorMessage> orderErrorList = new List<ErrorMessage>();
                Order order = paymentDTO.Order;
                order.Processed = true;// TODO : Hard coded will be removed after we got CYBER Status
                order.PaymentDate = DateTime.Now;// TODO : Hard coded will be removed after we got CYBER Date time
                order.Authorization = "000";// TODO : Hard coded will be removed after we got CYBER Date time
                if (order != null)
                {
                    OrderBusinessValidation(order, orderErrorList, errorMessages);



                    // check if has no validation before persist
                    if (orderErrorList.Count == 0)
                    {
                        long orderid = paymentDataService.OrderPersist(paymentDTO.UserId, paymentDTO.UserDataId,
                                                                                                    order,
                                                                                                    Utilities.GetIpAddress());

                        orderPersist = new Tuple<long, List<ErrorMessage>>(orderid,
                                                                                                    orderErrorList);
                        SendInvoiceEmail(orderid, paymentDTO);
                    }

                    else
                    {
                        orderPersist = new Tuple<long, List<ErrorMessage>>(0, orderErrorList);
                }
            }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(paymentDTO.UserId, "Class:PaymentRepository,Method Name:OrderPersist", ex);
            }
            return orderPersist;
        }

        public void SendInvoiceEmail(long orderId, PaymentDTO paymentDTO)
        {
            try
            {
                Order order = paymentDataService.GetOrderWithOrderId(orderId);
                var emailData = emailRepository.GetEmailTemplateById(EmailTemplate.PaymentEmail);

                ShoppingCart shoppintCart = null;

                paymentDTO.ProductType = ProductType.Form1040EZ;
                shoppintCart = paymentDataService.GetUserFeatureSKU(paymentDTO);


                if (emailData != null)
                {
                    emailData.Subject = "Invoice for Payment with Tax Garden";
                    string emailContent = emailData.TemplateContent;
                    emailContent = emailContent.Replace(Constants.EMAIL_IMAGE_LINK, email_image_link);
                    emailContent = emailContent.Replace(Constants.EMAIL_INVOICENUMBER, order.OrderId.ToString());
                    if (order != null)
                    {
                        if (order.BillingDetails != null)
                        {
                            emailData.ToEmailID = order.BillingDetails.Email;


                            emailContent = emailContent.Replace(Constants.EMAIL_USER_NAME, (string.IsNullOrEmpty(order.BillingDetails.FirstName) ? "" : order.BillingDetails.FirstName)
                                + " " + (string.IsNullOrEmpty(order.BillingDetails.LastName) ? "" : order.BillingDetails.LastName));

                            emailContent = emailContent.Replace(Constants.EMAIL_ORDERDATE, order.BillingDetails.PaymentDate.ToShortDateString());

                            if (order.BillingDetails.BillingAddress != null)
                            {
                                emailContent = emailContent.Replace(Constants.EMAIL_USERADDRESS,
                                                order.BillingDetails.BillingAddress.StreetAddress + "<br />" +
                                                                     order.BillingDetails.BillingAddress.ApartmentNumber + "<br />" +
                                                                     order.BillingDetails.BillingAddress.City + "<br />" +
                                                                     order.BillingDetails.BillingAddress.StateOrProvince + "<br />" +
                                                                     order.BillingDetails.BillingAddress.ZipCode);
                            }
                        }

                        emailContent = emailContent.Replace(Constants.EMAIL_PAYMENTAMOUNT, order.TotalAmount.ToString());
                    }
                    string stateList = string.Empty;
                    double total = 0;

                    if (shoppintCart != null && shoppintCart.FederalFeature != null && shoppintCart.FederalFeature.FederalFeatureSKU != null)
                    {
                        string federallist = string.Empty;
                        foreach (FederalFeatureSKU federalFeatureSKU in shoppintCart.FederalFeature.FederalFeatureSKU)
                        {
                            string featureName = string.Empty;
                            if (federalFeatureSKU.Feature != null)
                            {
                                featureName = federalFeatureSKU.Feature.FeatureName;
                            }
                            federallist = federallist + "<tr><td style='padding-left: 15px; background: #d9534f; border-bottom: solid 1px #ffe3d1; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;color:#fff;' width='250'>" + featureName + "</td>" +
                                                                           "<td style='background: #d9534f; border-bottom: solid 1px #ffe3d1; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;color:#fff'>:</td>" +
                                                                           "<td style='background: #d9534f; border-bottom: solid 1px #ffe3d1; font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;color:#fff;padding-left:15px;'>" + federalFeatureSKU.FederalFeaturePrice + "</td></tr>";


                            total = total + federalFeatureSKU.FederalFeaturePrice;


                        }

                        emailContent = emailContent.Replace(Constants.EMAIL_FEDERALTAXPREPARATION, federallist);
                    }

                    if (shoppintCart != null && shoppintCart.StateFeature != null)
                    {
                        string statename = string.Empty;
                        foreach (StateFeature sf in shoppintCart.StateFeature)
                        {
                            if (sf.State != null)
                            {
                                statename = sf.State.StateName;
                            }
                            foreach (StateFeatureSKU sku in sf.StateFeatureSKU)
                            {
                                stateList = stateList + "<td style='font: 12px/20px Arial, Helvetica, sans-serif; background: #f8fff4; vertical-align: top; color: #737272;padding-bottom: 8px; padding-top: 8px; font-weight:bold;border-bottom: solid 1px #5e9826;'>" + statename + "</td>     <td style='font: 12px/20px Arial, Helvetica, sans-serif; background: #f8fff4; vertical-align: top; color: #737272;padding-bottom: 8px; padding-top: 8px; font-weight:bold;border-bottom: solid 1px #5e9826; '>:</td>    <td style='font: 12px/20px Arial, Helvetica, sans-serif; background: #f8fff4; vertical-align: top; color: #737272;padding-bottom: 8px; padding-top: 8px; font-weight:bold;border-bottom: solid 1px #5e9826;'>" + sku.StatePrice + "</td>";

                                total = total + sku.StatePrice;
                            }
                        }
                    }

                    emailContent = emailContent.Replace(Constants.EMAIL_DYNAMICSTATELIST, stateList);
                    emailContent = emailContent.Replace(Constants.EMAIL_TOTALSTATEPRICE, total.ToString());


                    emailData.TemplateContent = emailContent;
                    Utilities.SendMail(emailData);


                }

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(paymentDTO.UserId, "Class:PaymentRepository,Method Name:SendInvoiceEmail", ex);
            }
        }

   

        /// <summary>
        /// Check out summary persist
        /// </summary>
        /// <param name="paymentDTO">The Payment DTO</param>
        /// <returns>Order Id</returns>
        public long CheckOutSummaryPersist(PaymentDTO paymentDTO)
        {
            long orderId = 0;
            try
            {
                paymentDTO.ProductType = ProductType.Form1040EZ;
                orderId = paymentDataService.CheckOutSummaryPersist(paymentDTO);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(paymentDTO.UserId, "Class:PaymentRepository,Method Name:CheckOutSummaryPersist", ex);
            }
            return orderId;
        }

        //15Jul2014 Sathish added persit user feature sku
        public dynamic PersistUserFeature(PaymentDTO paymentDTO)
        {
            dynamic userDataIDPayment = new ExpandoObject();
            

            try
            {
                if (paymentDTO.UserDataId == 0)
                {
                    //taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(paymentDTO.UserId, paymentDTO.UserDataId);

                    PersonalInfoRepository personalinfo = new PersonalInfoRepository();
                    PrimaryTaxPayer primaryTaxPayer=new PrimaryTaxPayer(){
                        FilingStatus = FilingStatus.Single
                    
                    };
                   var userData = personalinfo.PersistPrimaryTaxPayer(primaryTaxPayer, paymentDTO.UserId, paymentDTO.UserDataId, Constants.TOPIC_PERSONAL_FILINGSTATUS);
                   paymentDTO.UserDataId = userData.Item1;
                }

                
                paymentDTO.ProductType = ProductType.Form1040EZ;
                paymentDataService.PersistUserFeature(paymentDTO);
                userDataIDPayment = paymentDTO.UserDataId;

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(paymentDTO.UserId, "Class:PaymentRepository,Method Name:CheckOutSummaryPersist", ex);
            }
            return userDataIDPayment;

        }

        #endregion

        #region BusinessValidation
        /// <summary>
        /// Business Fields Validations (Required and Validation) checked.
        /// </summary>
        /// <param name="eic"></param>
        /// <param name="errorMessageList"></param>
        /// <param name="errorMessages"></param>
        private void IRSPaymentOptionBusinessValidation(IRS irs, List<ErrorMessage> errorMessageList,
           ErrorMessages errorMessages)
        {
            ErrorMessage errorMessage;

            if (irs != null)
            {

                errorMessage = BusinessValidationRepository.AssertGreaterThanZero(irs.PaymentOption.GetHashCode(),
                                                         Constants.PAYMENT_REQUIRED_TYPE_OF_ACCOUNT, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                if (irs.BankDetails != null)
                {
                    errorMessage =
                   BusinessValidationRepository.AssertIsNotNullOrEmpty(irs.BankDetails.AccountNumber,
                                                                       Constants.PAYMENT_REQUIRED_ACCOUNT_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage =
                   BusinessValidationRepository.AssertIsNotNullOrEmpty(irs.BankDetails.RoutingTransitNumber,
                                                                       Constants.PAYMENT_REQUIRED_ROUTING_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage =
                   BusinessValidationRepository.AssertIsNotNullOrEmpty(irs.BankDetails.BankName,
                                                                       Constants.PAYMENT_REQUIRED_BANK_NAME, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage =
                     BusinessValidationRepository.AssertGreaterThanZero(irs.BankDetails.BankAccountTypeCode.GetHashCode(),
                                                                        Constants.PAYMENT_REQUIRED_TYPE_OF_ACCOUNT,
                                                                        errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage = BusinessValidationRepository.AssertIsValidRTN(
                                            irs.BankDetails.RoutingTransitNumber,
                                               Constants.TAX_AND_WRAP_UP_ROUTING_NUMBER_VALIDATION, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                }



                if (irs.PaymentOption == PaymentOption.DirectDebit)
                {
                    errorMessage = BusinessValidationRepository.AssertIsTrue(irs.IsIRSPaymentOptionAgreed,
                                                                  Constants.PAYMENT_REQUIRED_INSTRUCTION_DIRECT_DEBIT, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }
                else if (irs.PaymentOption == PaymentOption.EFTPS)
                {
                    errorMessage = BusinessValidationRepository.AssertIsTrue(irs.IsIRSPaymentOptionAgreed,
                                                                  Constants.PAYMENT_REQUIRED_INSTRUCTION_EFTPS, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }
                else if (irs.PaymentOption == PaymentOption.CheckByMail)
                {
                    errorMessage = BusinessValidationRepository.AssertIsTrue(irs.IsIRSPaymentOptionAgreed,
                                                                  Constants.PAYMENT_REQUIRED_INSTRUCTION_CHECK_OR_MONEY_ORDER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }


            }
        }


        private void OrderBusinessValidation(Order order, List<ErrorMessage> errorMessageList,
           ErrorMessages errorMessages)
        {
            if (order != null)
            {
                if (order.BillingDetails != null)
                {
                    ErrorMessage errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.FirstName,
                                                                      Constants.PAYMENT_REQUIRED_FIRST_NAME, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    if (order.BillingDetails.FirstName != string.Empty)
                    {
                        errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(order.BillingDetails.FirstName,
                                                                          Constants.PAYMENT_VALIDATION_FIRST_NAME, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.LastName,
                                                                      Constants.PAYMENT_REQUIRED_LAST_NAME, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    if (order.BillingDetails.LastName != string.Empty)
                    {
                        errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(order.BillingDetails.LastName,
                                                                          Constants.PAYMENT_VALIDATION_LAST_NAME, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    if (order.BillingDetails.BillingAddress != null)
                    {
                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.BillingAddress.StreetAddress,
                                                                   Constants.PAYMENT_REQUIRED_STREET_ADDRESS, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                        if (order.BillingDetails.BillingAddress.StreetAddress != string.Empty)
                        {
                            errorMessage = BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(order.BillingDetails.BillingAddress.StreetAddress,
                                                                              Constants.PAYMENT_VALIDATION_STREET_ADDRESS, errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }

                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.BillingAddress.City,
                                                                 Constants.PAYMENT_REQUIRED_CITY_NAME, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                        if (order.BillingDetails.BillingAddress.City != string.Empty)
                        {
                            errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(order.BillingDetails.BillingAddress.City,
                                                                              Constants.PAYMENT_VALIDATION_CITY_NAME, errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }


                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.BillingAddress.PhoneNumber,
                                                               Constants.PAYMENT_REQUIRED_PHONE_NUMBER, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                        if (order.BillingDetails.BillingAddress.PhoneNumber != string.Empty)
                        {

                            errorMessage = BusinessValidationRepository.AssertIsWithinPhoneNoRange(
                                               order.BillingDetails.BillingAddress.PhoneNumber, 12, 12,
                                               Constants.PAYMENT_VALIDATION_PHONE_NUMBER, errorMessages);


                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }


                        if (order.BillingDetails.BillingAddress.State != null)
                        {
                            if (!order.BillingDetails.BillingAddress.IsForeignAddress)
                            {
                                if (order.BillingDetails.BillingAddress.State.StateId != 0)
                                {
                                    errorMessage = BusinessValidationRepository.AssertGreaterThanZero(order.BillingDetails.BillingAddress.State.StateId,
                                                               Constants.PAYMENT_REQUIRED_STATE_CODE, errorMessages);

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }


                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.BillingAddress.ZipCode,
                                                                    Constants.PAYMENT_REQUIRED_ZIP_CODE, errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                                else
                                {
                                    errorMessage = BusinessValidationRepository.IsValidZipCode(order.BillingDetails.BillingAddress.ZipCode.ToString(),
                                                                    Constants.TAXPAYER_PERSONAL_ADDRESS_VALID_ZIP_CODE, errorMessages);

                                    if (errorMessage == null)
                                    {
                                        bool isValidZipcodeForState = Utilities.ValidateZipCodeByStateId(
                                                                    order.BillingDetails.BillingAddress.State.StateId,
                                                                    order.BillingDetails.BillingAddress.ZipCode);

                                        errorMessage = BusinessValidationRepository.AssertIsTrue(isValidZipcodeForState,
                                                Constants.TAXPAYER_PERSONAL_ADDRESS_VALID_ZIP_CODE, errorMessages);
                                        if (errorMessage != null)
                                            errorMessageList.Add(errorMessage);
                                    }
                                }
                            }
                            else
                            {

                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.BillingAddress.ZipCode,
                                    Constants.PAYMENT_REQUIRED_ZIP_CODE, errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);

                                if (order.BillingDetails.BillingAddress.State.StateName != string.Empty)
                                {
                                    errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(order.BillingDetails.BillingAddress.State.StateName,
                                                                                      Constants.PAYMENT_VALIDATION_STATE_NAME, errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }

                                if (order.BillingDetails.BillingAddress.Country != null)
                                {
                                    errorMessage = BusinessValidationRepository.AssertGreaterThanZero(order.BillingDetails.BillingAddress.Country.CountryId,
                                                         Constants.PAYMENT_REQUIRED_FOREIGN_COUNTRY_NAME, errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                            }
                        }
                    }

                    if (order.BillingDetails.CreditCard != null)
                    {
                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.CreditCard.CreditCardType.ToString(),
                                                        Constants.PAYMENT_REQUIRED_CARD_TYPE, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.CreditCard.CreditCardNo,
                                                           Constants.PAYMENT_REQUIRED_CARD_NUMBER, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                        else
                        {
                            if (order.BillingDetails.CreditCard.CreditCardType.CardType != CardType.None)
                            {
                                errorMessage = BusinessValidationRepository.IsValidCreditCardNumber(order.BillingDetails.CreditCard.CreditCardType.CardType,
                                                                                                    order.BillingDetails.CreditCard.CreditCardNo,
                                                        Constants.PAYMENT_VALIDATION_CARD_NUMBER, errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }
                        }

                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.CreditCard.SecurityCodeNo,
                                                           Constants.PAYMENT_REQUIRED_CVC, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.CreditCard.ExpiryMonth,
                                                        Constants.PAYMENT_REQUIRED_EXPIRATION_DATE, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.CreditCard.ExpiryYear,
                                                       Constants.PAYMENT_REQUIRED_EXPIRATION_DATE, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                    }


                }


            }
        }
        #endregion

    }
}
