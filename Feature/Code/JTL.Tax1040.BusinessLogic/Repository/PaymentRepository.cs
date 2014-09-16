
/*
Copyright   : Copyright Jeevan Technologies
File Name   : PaymentRepository.cs 
Description : Payment Repository  
Author      : Sathish 
Created Date : 12May2014

 * Modification History:
 * Thileep Changed StreetAddress,Phonenovalidation in Orderbusinessvalidation method 02July2014
 * Sathish 25Jul2014 changed IRSPaymentOption enum to PaymentOption
 * Ashok kumar  13August2014 Modified Business validation call before cyber source invoke in Order perist
------------------------
 */

using System.Globalization;
using System.ServiceModel;
using System.Text;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using JTL.Tax1040.PaymentLibrary;
using System.Activities;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;
using Tax1040WorkFlow.WorkFlow.Activities;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities;
using System.Web;

namespace JTL.Tax1040.BusinessLogic
{
    public class PaymentRepository : IPaymentRepository
    {
        #region Declarations

        private string MERCHANT_ID = string.Empty;
        private string TRANSACTION_KEY = string.Empty;
        private string MERCHANT_REFERENCE_CODE = string.Empty;
        private string RemoteAddress = string.Empty;

        StringBuilder sb;
        BillTo billingInfo;
        Card creditCardInfo;

        #endregion
        IPaymentDataService paymentDataService;
        IUserRepository userRepository;
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
            userRepository = new UserRepository();
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
                                                                        userRepository.GetEmailByUserId(userDTO.UserId));
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

        #region CyberSource


        /// <summary>
        /// Calls the cyper source process.
        /// </summary>
        /// <param name="payment">The payment.</param>
        /// <param name="paymentStatus">if set to <c>true</c> [payment status].</param>
        /// <param name="authCode">The auth code.</param>
        /// <returns></returns>
        private bool CallCyberSourceProcess(PaymentDTO payment, ref bool paymentStatus, ref string authCode)
        {
            paymentStatus = CallCyberSource(payment, out authCode);

            if (payment == null)
            {
                payment = new PaymentDTO();
            }
            payment.Order.Authorization = authCode;
            payment.Order.PaymentDate = System.DateTime.Now;

            payment.OperationStatus = paymentStatus ? StatusType.Success : StatusType.Failure;
            return paymentStatus;
        }

        /// <summary>
        /// Calls the cyber source.
        /// </summary>
        /// <param name="payment">The payment.</param>
        /// <param name="authCode">The auth code.</param>
        /// <returns></returns>
        public bool CallCyberSource(PaymentDTO payment, out string authCode)
        {
            MERCHANT_ID = ConfigurationManager.AppSettings[Constants.MERCHANT_ID];
            TRANSACTION_KEY = ConfigurationManager.AppSettings[Constants.TRANSACTION_KEY];
            MERCHANT_REFERENCE_CODE = ConfigurationManager.AppSettings[Constants.MerchantReferenceCode1040EZ];


            string errorExceptionMessage = string.Empty;
            bool processed = false;
            authCode = string.Empty;

            RequestMessage request = new RequestMessage();
            TransactionProcessorClient proc = new TransactionProcessorClient();
            ReplyMessage reply = new ReplyMessage();

            //To remove ,,for testing
            authCode = string.Empty + authCode;
            try
            {
                request = FormPaymentRequest(request, payment);

                request.merchantID = MERCHANT_ID;
                MERCHANT_REFERENCE_CODE = TRANSACTION_KEY;
                request.clientApplicationUser = MERCHANT_REFERENCE_CODE;
                request.merchantReferenceCode = MERCHANT_REFERENCE_CODE + "-" + payment.UserDataId;

                request.clientLibrary = ".NET WCF";
                request.clientLibraryVersion = Environment.Version.ToString();
                request.clientEnvironment =
                    Environment.OSVersion.Platform +
                    Environment.OSVersion.Version.ToString();
                request.ccAuthService = new CCAuthService();
                request.ccAuthService.run = "true";
                request.ccCaptureService = new CCCaptureService();
                request.ccCaptureService.run = "true";

                proc.ChannelFactory.Credentials.UserName.UserName = request.merchantID;
                proc.ChannelFactory.Credentials.UserName.Password = TRANSACTION_KEY;
                reply = proc.runTransaction(request);

                //check the reply status, return true if "ACCEPT"
                if (reply != null && reply.decision == Constants.PaymentAccept)
                {
                    if (reply.ccAuthReply != null)
                    {
                        authCode = reply.ccAuthReply.authorizationCode;
                    }

                    processed = true;
                }
                else
                {
                    payment.CyberSourceResponse = ProcessCyberResponse(reply);
                }
            }

            catch (TimeoutException ex)
            {
                errorExceptionMessage = ex.ToString();
            }
            catch (FaultException ex)
            {
                errorExceptionMessage = ex.ToString();
            }
            catch (CommunicationException ex)
            {
                errorExceptionMessage = ex.ToString();
            }
            finally
            {
                proc.Close();
            }
            payment.ExceptionErrorMessage = errorExceptionMessage;
            return processed;

        }

        #region Form the Cybersource request
        /// <summary>
        /// Set the Paypall/cypersource required information
        /// </summary>
        /// <param name="request">The RequestMessage</param>
        /// <param name="payment">The PaymentBO</param>
        /// <returns></returns>
        private RequestMessage FormPaymentRequest(RequestMessage request, PaymentDTO payment)
        {
            if (null == request)
            {
                request = new RequestMessage();
            }
            if (payment.Order != null)
            {
                // Form the Billing address information.
                this.billingInfo = new BillTo();
                SetBillingInformation(payment);
                request.billTo = this.billingInfo;

                // Form the Credit card Information.
                this.creditCardInfo = new Card();
                SetCreditCardInformation(payment);
                request.card = this.creditCardInfo;

                // Form the Purchase Information
                PurchaseTotals purchaseInfo = new PurchaseTotals();
                purchaseInfo.currency = "USD";
                payment.Order.BillingDetails.Currency = "USD";
                request.purchaseTotals = purchaseInfo;

                request.clientApplicationUser = payment.UserId.ToString(CultureInfo.CurrentCulture);

                // Form the Item Information.
                request.item = new Item[2];
                Item item = new Item { id = "0" };
                if (null != payment.Order && payment.Order.TotalAmount >= 0)
                {
                    item.unitPrice = payment.Order.TotalAmount.ToString(CultureInfo.CurrentCulture);
                }
                request.item[0] = item;
            }
            return request;
        }

        private void SetCreditCardInformation(PaymentDTO payment)
        {
            if (null != payment.Order)
            {
                if (payment.Order.BillingDetails.CreditCard != null)
                {
                    creditCardInfo.accountNumber = payment.Order.BillingDetails.CreditCard.CreditCardNo;
                    creditCardInfo.expirationMonth = payment.Order.BillingDetails.CreditCard.ExpiryMonth;
                    creditCardInfo.expirationYear = payment.Order.BillingDetails.CreditCard.ExpiryYear;
                    creditCardInfo.cvNumber = payment.Order.BillingDetails.CreditCard.SecurityCodeNo;
                }
            }
        }

        private void SetBillingInformation(PaymentDTO payment)
        {
            if (billingInfo != null)
            {
                if (payment.Order != null)
                {
                    if (null != payment.Order.BillingDetails)
                    {
                        billingInfo.firstName = payment.Order.BillingDetails.FirstName;
                        billingInfo.lastName = payment.Order.BillingDetails.LastName;
                        billingInfo.street1 = payment.Order.BillingDetails.BillingAddress.StreetAddress;
                        billingInfo.city = payment.Order.BillingDetails.BillingAddress.City;
                        if (!payment.Order.BillingDetails.BillingAddress.IsForeignAddress)
                        {
                            billingInfo.country = "USA";

                            billingInfo.state = payment.Order.BillingDetails.BillingAddress.State.StateName;
                        }
                        else
                        {
                            billingInfo.country = payment.Order.BillingDetails.BillingAddress.Country.CountryName;

                            billingInfo.state = payment.Order.BillingDetails.BillingAddress.StateOrProvince;
                        }
                        billingInfo.postalCode = payment.Order.BillingDetails.BillingAddress.ZipCode;
                        billingInfo.email = payment.Order.BillingDetails.Email;
                        billingInfo.phoneNumber = payment.Order.BillingDetails.BillingAddress.PhoneNumber;
                        billingInfo.customerID = payment.UserId.ToString(CultureInfo.CurrentCulture);
                    }
                }
            }
        }

        #endregion

        #region CyberSource Response Process

        private string ProcessCyberResponse(ReplyMessage response)
        {
            string errorMessage = string.Empty;
            if (null != response)
            {
                int reasoncode = 0;
                int.TryParse(response.reasonCode, out reasoncode);
                switch (reasoncode)
                {
                    // Missing field(s)
                    case 101:
                        errorMessage = Constants.RequiredField + EnumerateValues(response.missingField);
                        break;
                    // Invalid field(s)
                    case 102:
                        errorMessage = Constants.FieldInvalid + EnumerateValues(response.invalidField);
                        break;
                    // ESYSTEM
                    case 150:
                        errorMessage = Constants.SystemFailure;
                        break;
                    // AVS failed
                    case 200:
                        errorMessage = Constants.VerifyAddress;
                        break;
                    // Call
                    case 201:
                        errorMessage = Constants.BankRequest;
                        break;
                    // Expired card
                    case 202:
                        errorMessage = Constants.CreditCard;
                        break;
                    // General decline of the card
                    case 203:
                        errorMessage = Constants.PleaseCheck;
                        break;
                    // Insufficient funds
                    case 204:
                        errorMessage = Constants.InsufficientFund;
                        break;
                    case 208:
                        errorMessage = Constants.InvalidTransaction;
                        break;
                    // Credit floor
                    case 210:
                        errorMessage = Constants.CreditLimit;
                        break;
                    // Invalid account number
                    case 231:
                        errorMessage = Constants.AccountInvalid;
                        break;
                    // General processor decline
                    case 205:
                    case 220:
                    case 233:
                        errorMessage = Constants.ProcessorDecline;
                        break;
                    case 240:
                        errorMessage = Constants.InvalidCard;
                        break;
                    case 475:
                        errorMessage = Constants.InvalidCardHolder;
                        break;
                    case 476:
                        errorMessage = Constants.InvalidCustomer;
                        break;
                    case 520:
                        errorMessage = Constants.VerifyAddress;
                        break;
                    default:
                        errorMessage = Constants.SystemFailure;
                        break;
                }
            }
            return errorMessage;
        }

        protected string EnumerateValues(string[] array)
        {
            if (array == null)
                return string.Empty;
            sb = new System.Text.StringBuilder();
            foreach (string val in array)
            {
                sb.Append(val + "\n");
            }
            return (sb.ToString());
        }

        #endregion



        #endregion

        #region Persist Order

        /// <summary>
        /// Orders the persist.
        /// </summary>
        /// <param name="payment">The payment.</param>
        /// <returns></returns>
        public Tuple<long, List<ErrorMessage>, string> OrderPersist(PaymentDTO payment)
        {
            bool paymentStatus = false;
            string authCode = string.Empty;
            Tuple<long, List<ErrorMessage>, string> orderDetails = null;
            try
            {
                //Retrieving Error Message list from Database
                //var errorMessage = messageRepository.GetErrorMessages();
                var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                var errorMessages = new ErrorMessages(errorMessage);

                List<ErrorMessage> orderErrorList = new List<ErrorMessage>();

                OrderBusinessValidation(payment.Order, orderErrorList, errorMessages);

                if (payment != null && orderErrorList.Count == 0)
                {
                    //CybeSource Status
                    CallCyberSourceProcess(payment, ref paymentStatus, ref authCode);

                    if (paymentStatus)
                    {
                        long orderId = paymentDataService.OrderPersist(payment.UserId, payment.UserDataId,
                                                                       payment.Order, Utilities.GetIpAddress());
                        orderDetails = new Tuple<long, List<ErrorMessage>, string>(orderId,
                                                                           orderErrorList, null);
                        //Send Invoice Email
                        SendInvoiceEmail(orderId, payment);
                    }
                    else
                    {
                        orderDetails = new Tuple<long, List<ErrorMessage>, string>(0, null, payment.CyberSourceResponse);
                    }

                }
                else
                {
                    orderDetails = new Tuple<long, List<ErrorMessage>, string>(0, orderErrorList, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(payment.UserId, "Class:PaymentRepository,Method Name:OrderPersist", ex);
            }
            return orderDetails;
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
                    emailData.Subject = Constants.INVOICE_SUBJECT;
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
                    PrimaryTaxPayer primaryTaxPayer = new PrimaryTaxPayer()
                    {
                        FilingStatus = FilingStatus.Single

                    };
                    var userData = personalinfo.PersistPrimaryTaxPayer(primaryTaxPayer, paymentDTO.UserId, paymentDTO.UserDataId, Constants.TOPIC_PERSONAL_FILINGSTATUS);
                    paymentDTO.UserDataId = userData.Item1;
                }


                //var errorMessage = messageRepository.GetErrorMessages();
                var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                var errorMessages = new ErrorMessages(errorMessage);

                var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(paymentDTO.UserId, paymentDTO.UserDataId);

                //25Aug2014 Sathish to add income error message while directly coming to review.
                if (taxObject.ErrorMessages != null)
                {
                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME);
                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL);
                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_MISSING_INCOME);
                }

                dynamic federalSummaryInput = new Microsoft.Activities.Extensions.WorkflowArguments();
                federalSummaryInput.Tax1040Object = taxObject;
                federalSummaryInput.IsTaxableIncomeExceedCheck = true;
                federalSummaryInput.IsRefundAvailableCheck = true;
                federalSummaryInput.IsIncomeAndRefundAllZeros = true;
                federalSummaryInput.ErrorMessages = errorMessages;
                var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                          WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), federalSummaryInput));

                paymentDTO.UserDataId = Utilities.PersistTaxObject(paymentDTO.UserId, paymentDTO.UserDataId, taxObject);

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

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.Email,
                                                                      Constants.PAYMENT_REQUIRED_EMAIL, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    else
                    {
                        if (!Utilities.IsValidEmail(order.BillingDetails.Email))
                        {
                            errorMessage = errorMessages[Constants.PAYMENT_VALIDATION_EMAIL];
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }
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
                        else
                        {
                            errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(order.BillingDetails.BillingAddress.City,
                                                                              Constants.PAYMENT_VALIDATION_CITY_NAME, errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);

                            if (order.BillingDetails.BillingAddress.City.Length < 3)
                            {
                                //BR : #1
                                errorMessage = errorMessages[Constants.PAYMENT_BUSINESS_RULE_CITY_NAME];
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }

                        }


                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(order.BillingDetails.BillingAddress.PhoneNumber,
                                                               Constants.PAYMENT_REQUIRED_PHONE_NUMBER, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                        if (order.BillingDetails.BillingAddress.State != null)
                        {
                            if (!order.BillingDetails.BillingAddress.IsForeignAddress)
                            {

                                errorMessage = BusinessValidationRepository.AssertGreaterThanZero(order.BillingDetails.BillingAddress.State.StateId,
                                                           Constants.PAYMENT_REQUIRED_STATE_CODE, errorMessages);

                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);


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
                                                                    order.BillingDetails.BillingAddress.ZipCode.Substring(0, 5)); //22Aug2014 Sathish validated zip code based on 5 digit

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
                                //01Sep2014 Sathish Postal code validation
                                else
                                {
                                    if (order.BillingDetails.BillingAddress.ZipCode.Length >= 3)
                                    {
                                        errorMessage =
                                                    BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(
                                                          order.BillingDetails.BillingAddress.ZipCode,
                                                          Constants.PAYMENT_VALIDATION_POSTAL_CODE, errorMessages);
                                        if (errorMessage != null)
                                            errorMessageList.Add(errorMessage);
                                        else
                                        {
                                            var postalCode = Utilities.RemoveHiphen(order.BillingDetails.BillingAddress.ZipCode);
                                            postalCode = Utilities.RemoveUnderscore(postalCode);
                                            postalCode = Utilities.RemoveOpenBracket(postalCode);
                                            postalCode = Utilities.RemoveCloseBracket(postalCode);

                                            if (postalCode == Constants.NineZeros)
                                            {
                                                errorMessage = errorMessages[Constants.PAYMENT_VALIDATION_POSTAL_CODE];
                                                if (errorMessage != null)
                                                    errorMessageList.Add(errorMessage);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        errorMessage = errorMessages[Constants.PAYMENT_VALIDATION_POSTAL_CODE];
                                        if (errorMessage != null)
                                            errorMessageList.Add(errorMessage);
                                    }
                                }

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
                        //01Sep2014 Sathish US and foreign phone number validation
                        if (!order.BillingDetails.BillingAddress.IsForeignAddress)
                        {
                            if (order.BillingDetails.BillingAddress.PhoneNumber != string.Empty)
                            {
                                errorMessage = BusinessValidationRepository.AssertIsWithinPhoneNoRange(
                                                   order.BillingDetails.BillingAddress.PhoneNumber, 12, 12,
                                                   Constants.PAYMENT_VALIDATION_PHONE_NUMBER, errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }
                        }
                        else
                        {
                            if (order.BillingDetails.BillingAddress.PhoneNumber != string.Empty)
                            {

                                errorMessage = BusinessValidationRepository.AssertIsWithinForeignPhoneNo(
                                                   order.BillingDetails.BillingAddress.PhoneNumber,
                                                   Constants.PAYMENT_VALIDATION_FOREIGN_PHONE_NUMBER, errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);

                            }
                        }
                    }

                    if (order.BillingDetails.CreditCard != null)
                    {
                        //25Aug2014 Sathish checked card type unable to call Utilities.ConvertToInteger32 because it return zero
                        errorMessage = BusinessValidationRepository.AssertGreaterThanZero((int)(order.BillingDetails.CreditCard.CreditCardType.CardType),
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
                                                       Constants.PAYMENT_REQUIRED_EXPIRATION_YEAR, errorMessages); //22Aug2014 Sathish added changed constant for the year
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                    }


                }


            }
        }
        #endregion

    }
}
