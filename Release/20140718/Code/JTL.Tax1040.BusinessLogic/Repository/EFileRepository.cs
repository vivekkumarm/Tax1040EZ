

/*
Copyright   : Copyright Jeevan Technologies
File Name   : EFileRepository.cs 
Description : EFile Repository 
Author      : Sathish 
Created Date : 13May2014

 * Modification History:
------------------------
 * vivek 2-july-2014 persist method for the irs transmission 
 * Vincent 3July2014  Added GetFilingOptionSummary method.
 * Vincent 11July2014 Code implemented to add Validations
 * Vincent-10JULY 2014 - Made a changes tuple method added a filing class.
 * Vivek-11-7-14 - Addred mail send method
 * Vincent -14-JUly-14- Added a required field valid for Efile option
 */

using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Configuration;

namespace JTL.Tax1040.BusinessLogic
{
    public class EFileRepository : IEFileRepository
    {
        BusinessObject.Tax1040 taxObject;
        MessagesRepository messageRepository;
        IUserRepository userrepository;
        IEmailRepository emailRepository;
        ITaxReturnRepository taxReturnRepository;
        private readonly string email_image_link = ConfigurationManager.AppSettings[Constants.Tax1040ImageUrl];

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxReturnRepository"/> class.
        /// </summary>
        /// Vincent- 3 July 2014 - Added constructor method for Message repository.
        public EFileRepository()
        {
            messageRepository = new MessagesRepository();
            userrepository = new UserRepository();
            emailRepository = new EmailRepository();
            taxReturnRepository = new TaxReturnRepository();
        }

        #endregion

        #region Get

        public System.Tuple<string, PersonalDetails, IRSTransmission, Filing, bool> GetPersonAndIRSTransmission(long userId, long userDataId)
        {
            bool hasEfileErrors = false;
            //Retreiving TaxObject from database
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);
            //IRSTransmission irsTransmission = new IRSTransmission();
            //Filing filing = new Filing();

            if (taxObject.ErrorMessages != null)
            {
                //If ErrorMessages doesn't have any object it returns count as 1 for NULL object. So removing this NULL object from the list.
                taxObject.ErrorMessages.RemoveAll(err => err == null);

                if (taxObject.ErrorMessages.Count > 0)
                {
                    //Get EFile related error messages.
                    hasEfileErrors = taxObject.ErrorMessages.Any(err => err.Topic == Constants.TOPIC_EFILE);

                }
            }

            return new System.Tuple<string, PersonalDetails, IRSTransmission, Filing, bool>(Utilities.GetTaxPayerFirstNameOrNickName(taxObject),
  ((taxObject.PersonalDetails != null) ? taxObject.PersonalDetails : null),
      ((taxObject.IRSTransmission != null) ? taxObject.IRSTransmission : null), ((taxObject.Filing != null) ? taxObject.Filing : null), hasEfileErrors);

        }
        

        /// <summary>
        /// Get E-file Error Message
        /// </summary>
        /// <param name="UserData"></param>
        /// <returns></returns>
        /// vivek 15-july-14 Geting efile Error Messages
        public IEnumerable<ErrorMessage> GetErrorMessage(UserDTO UserData)
        {
            IEnumerable<ErrorMessage> errorMessage = null;
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(UserData.UserId, UserData.UserDataId);
            if (taxObject.ErrorMessages != null)
            {
                //If ErrorMessages doesn't have any object it returns count as 1 for NULL object. So removing this NULL object from the list.
                taxObject.ErrorMessages.RemoveAll(err => err == null);

                if (taxObject.ErrorMessages.Count > 0)
                {
                    //Get EFile related error messages.
                    //Commented by vivek for getting efile error message
                    //TODO
                    errorMessage = taxObject.ErrorMessages.FindAll(err => err.Topic == Constants.TOPIC_EFILE);
                    //errorMessage = taxObject.ErrorMessages;
                }
            }
            return errorMessage;
        }
        /// <summary>
        /// Delete E file Information
        /// </summary>
        /// <param name="UserData"></param>
        /// <returns></returns>
        /// vivek 15-july-14 Delete Efile Information
        public bool DeleteEfileInformation(UserDTO UserData)
        {
            bool IsDeleted=false;
             taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(UserData.UserId, UserData.UserDataId);
                if(taxObject!=null)
                {
                    //TODO: Commented by vivek for deleting the e file information
                    //taxObject.Filing=new Filing();
                    //IsDeleted = true;
                }
                return IsDeleted;
        }
        //public IRSTransmission GetIRSTranmission(long userId, long userDataId)
        //{
        //    return new IRSTransmission();
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        /// 7-July-14 vivek getting the filling details 
        public Filing GetFiling(long userId, long userDataId)
        {
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

            //Filing filing= new Filing();
            return taxObject.Filing;
        }



        // Vincent- 3 July 2014 - Added the methed form Payment repository.
        public System.Tuple<double, IRS,Filing> GetIRSPaymentOption(UserDTO userDTO)
        {
           
            //Retreiving TaxObject from database
            System.Tuple<double, IRS, Filing> irsPaymentOption = null;
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                
                //Vincent-2/7/2014-Added the Federal Summary workflow to get TaxOweAmount.
                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
                var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                            WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), input));

                var totalTaxOweAmount = taxObject.OutputForms.Tax1040EZPage1.TaxOweAmount;

                irsPaymentOption = new System.Tuple<double, IRS,Filing>(totalTaxOweAmount, ((taxObject.Settlement != null
                                                           && taxObject.Settlement.IRS != null) ? taxObject.Settlement.IRS : null),taxObject.Filing);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:PaymentRepository,Method Name:GetPaymentDetails", ex);
            }
            return irsPaymentOption;
        }

        public Filing GetFilingOptionSummary(UserDTO userDTO)
        {
            Filing filing = null;
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                if (taxObject != null && taxObject.Filing != null)
                {
                    filing = taxObject.Filing;
                }

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:EFileRepository,Method Name:GetFilingOptionSummary", ex);
            }
            return filing;


        }

        public Filing GetEFileDetails(UserDTO userDTO)
        {
            Filing filing = null;
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                //for testing 
                //taxObject.Filing = new Filing();
                //taxObject.Filing.FederalFiling = new FederalFiling();
                //taxObject.Filing.StateFiling = new List<StateFiling>();
                if (taxObject != null && taxObject.Filing != null)
                {
                    //filing = new Filing();
                    filing = taxObject.Filing;
                }

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:EFileRepository,Method Name:GetFilingOptionSummary", ex);
            }
            return filing;
        }
        #endregion

        #region Persist
        /// <summary>
        /// Persist for IRS Transmission
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taxReturnData"></param>
        /// <returns></returns>
        /// ///vivek 2-july-2014 persist method for the irs transmission 
        public dynamic PersistIRSTranmission(long userId, TaxReturnData taxReturnData)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            List<ErrorMessage> taxObjectErrorList = null;
            dynamic userData = new ExpandoObject();
            try
            {
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);

                //Creating Instance if Tax1040 is Null
                if (taxObject == null)
                {
                    taxObject = new BusinessObject.Tax1040();
                }
                //Creating Instance if IRSTransmission section is Null
                if (taxObject.IRSTransmission == null)
                {
                    taxObject.IRSTransmission = new IRSTransmission();
                }

                //Retrieving Error Message list from Database
                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);

                // Clear the Error messages exist for this topic.
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EFILE);

                if (taxObject.IRSTransmission != null)
                {

                    //Deserialize IRSTransmission object
                    IRSTransmission irsTransmission = JsonConvert.DeserializeObject<IRSTransmission>(taxReturnData.TaxData);
                    taxObject.IRSTransmission = irsTransmission;

                    var filing = taxObject.Filing;

                    //validation
                    IRSTranmissionBusinessValidation(taxObject.IRSTransmission, taxObject.ErrorMessages, errorMessages, filing);

                    //persist tax object
                    taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:EFileRepository,Method Name:PersistIRSTranmission", ex);
            }
            return userId;
        }

        /// <summary>
        /// Persist for Filling
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taxReturnData"></param>
        /// <returns></returns>
        /// ///vivek 2-july-2014 persist method for the Filing
        public dynamic PersistFiling(long userId, TaxReturnData taxReturnData)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;

            //taxObject.Filing.FederalFiling = new FederalFiling();
            List<ErrorMessage> taxObjectErrorList = null;

            try
            {
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);

                //Creating Instance if Tax1040 is Null
                //17Jul2014 Sathish changed code taxobject will be intialized only if taxobject is null
                if (taxObject == null)
                {
                    taxObject = new BusinessObject.Tax1040();
                    taxObject.Filing = new Filing();
                }
                else if (taxObject.Filing == null)
                {
                    taxObject.Filing = new Filing();
                }

                //Retrieving Error Message list from Database
                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);


                // Clear the Error messages exist for this topic.
               // messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EFILE);

                //Creating Instance if IRSTransmission section is Null
                if (taxObject.Filing == null || taxObject.Filing.FederalFiling == null || taxObject.Filing.StateFiling == null)
                {
                    taxObject.Filing = new Filing();
                    taxObject.Filing.FederalFiling = new FederalFiling();
                    taxObject.Filing.StateFiling = new List<StateFiling>();
                }
                if (taxObject.Filing != null && taxObject.Filing.StateFiling != null && taxObject.Filing.FederalFiling != null)
                {

                    //Deserialize IRSTransmission object
                    Filing filling = JsonConvert.DeserializeObject<Filing>(taxReturnData.TaxData);
                    taxObject.Filing = filling;
                    //persist tax object
                    FilingBusinessValidation(taxObject.Filing, taxObjectErrorList, errorMessages);
                    taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);
                }
                
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:EFileRepository,Method Name:PersistIRSTranmission", ex);
            }
            return new Tuple<long, List<ErrorMessage>>(userId, taxObjectErrorList); 
        }
        /// <summary>
        /// Vincent- 3 July 2014 - Added the methed form Payment repository.
        /// </summary>
        /// <param name="paymentDTO"></param>
        /// <returns></returns>
        public Tuple<long, List<ErrorMessage>> PersistIRSPaymentOption(PaymentDTO paymentDTO)
        {
            List<ErrorMessage> lstErrorMessage = new List<ErrorMessage>(); 
            Tuple<long, List<ErrorMessage>> irsPaymentOption = null;
            try
            {
                IRS irs = paymentDTO.IRS;

                if (irs != null)
                {
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(paymentDTO.UserId, paymentDTO.UserDataId);


                    if (taxObject.Settlement == null)
                    {
                        taxObject.Settlement = new Settlement();
                    }
                    taxObject.Settlement.IRS = irs;

                    //Initializing Out Parameter
                    //if (taxObject.ErrorMessages == null)
                    //    taxObject.ErrorMessages = new List<ErrorMessage>();

                    //Retrieving Error Message list from Database
                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessages = new ErrorMessages(errorMessage);

                    
                    //// Clear the Error messages
                    //messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EFILE);

                    IRSPaymentOptionBusinessValidation(taxObject.Settlement.IRS, lstErrorMessage, errorMessages);

                    //Persist TaxObject.
                    paymentDTO.UserDataId = Utilities.PersistTaxObject(paymentDTO.UserId, paymentDTO.UserDataId, taxObject);

                    //taxObjectErrorList = taxObject.ErrorMessages.FindAll(em => em.ErrorCode.StartsWith(Constants.TOPIC_EFILE));
                }

                irsPaymentOption = new Tuple<long, List<ErrorMessage>>(paymentDTO.UserDataId, lstErrorMessage);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(paymentDTO.UserId, "Class:PaymentRepository,Method Name:PersitIRSPaymentOption", ex);
            }
            return irsPaymentOption;

        }

       
        #endregion

        #region E-mail
        public bool SendEMail(long userId, long userDataId)
        {
            //string userDataId = null;
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            //serDataId = taxReturnRepository.GetTaxReturnDatabyUserDataId(userDataId,userId);
            //userDataId = taxReturnRepository.GetTaxReturnDatabyUserDataId(userDataId,);
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);
            
            User user = userrepository.GetUserDetailsByUserId(userId);

            var userEmail = user.Email;

            var userName = Utilities.GetTaxPayerFirstNameOrNickName(taxObject);
            var status = false;
           
                if (userId > 0)
                {
                    EmailData emailData = emailRepository.GetEmailTemplateById(EmailTemplate.TransmitFederalReturn);
                    if (emailData != null)
                    {
                        emailData.ToEmailID = user.Email;
                        emailData.Subject = "You have successfully Transmitted";
                        string emailContent = emailData.TemplateContent;
                        emailContent = emailContent.Replace(Constants.EMAIL_IMAGE_LINK, email_image_link);
                        emailContent = emailContent.Replace(Constants.EMAIL_USER_NAME, userName);

                        emailData.TemplateContent = emailContent;
                        Utilities.SendMail(emailData);

                        status = true;
                    }
                }
                else
                {
                    userId = 0L;
                }

                return status;
        }
        #endregion

        #region Business validation
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
                #region Comment fields
                //errorMessage = BusinessValidationRepository.AssertGreaterThanZero(irs.IRSPaymentOption.GetHashCode(),
                //                                         Constants.PAYMENT_REQUIRED_TYPE_OF_ACCOUNT, errorMessages);
                //if (errorMessage != null)
                //    errorMessageList.Add(errorMessage);

                //if (irs.BankDetails != null)
                //{
                //    errorMessage =
                //   BusinessValidationRepository.AssertIsNotNullOrEmpty(irs.BankDetails.AccountNumber,
                //                                                       Constants.PAYMENT_REQUIRED_ACCOUNT_NUMBER, errorMessages);
                //    if (errorMessage != null)
                //        errorMessageList.Add(errorMessage);

                //    errorMessage =
                //   BusinessValidationRepository.AssertIsNotNullOrEmpty(irs.BankDetails.RoutingTransitNumber,
                //                                                       Constants.PAYMENT_REQUIRED_ROUTING_NUMBER, errorMessages);
                //    if (errorMessage != null)
                //        errorMessageList.Add(errorMessage);

                //    errorMessage =
                //   BusinessValidationRepository.AssertIsNotNullOrEmpty(irs.BankDetails.BankName,
                //                                                       Constants.PAYMENT_REQUIRED_BANK_NAME, errorMessages);
                //    if (errorMessage != null)
                //        errorMessageList.Add(errorMessage);

                //    errorMessage =
                //     BusinessValidationRepository.AssertGreaterThanZero(irs.BankDetails.BankAccountTypeCode.GetHashCode(),
                //                                                        Constants.PAYMENT_REQUIRED_TYPE_OF_ACCOUNT,
                //                                                        errorMessages);
                //    if (errorMessage != null)
                //        errorMessageList.Add(errorMessage);

                //    errorMessage = BusinessValidationRepository.AssertIsValidRTN(
                //                            irs.BankDetails.RoutingTransitNumber,
                //                               Constants.TAX_AND_WRAP_UP_ROUTING_NUMBER_VALIDATION, errorMessages);
                //    if (errorMessage != null)
                //        errorMessageList.Add(errorMessage);

                //}
                #endregion

                //Vincent-3 July 2014, Added Required field and Validation Check condition.
                //Required Entry #10
                if (irs.IRSPaymentOption == IRSPaymentOption.None)
                {
                    errorMessage = errorMessages[Constants.EFILE_IRS_PAYEMENT_OPTION_NULL];
                    errorMessageList.Add(errorMessage);
                }


                if (irs.IRSPaymentOption == IRSPaymentOption.DirectDebit)
                {
                    if (irs.BankDetails != null)
                    {
                        if (irs.BankDetails.BankAccountTypeCode == AccountType.None)
                        {
                            //Required Entry #1
                            errorMessage = errorMessages[Constants.EFILE_REQUIRED_TYPE_OF_ACCOUNT];
                            errorMessageList.Add(errorMessage);
                        }

                        //Required Entry #2
                        errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(irs.BankDetails.AccountNumber,
                                                                      Constants.EFILE_REQUIRED_ACCOUNT_NUMBER, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                        //Required Entry #3
                        errorMessage =
                       BusinessValidationRepository.AssertIsNotNullOrEmpty(irs.BankDetails.RoutingTransitNumber,
                                                                           Constants.EFILE_REQUIRED_ROUTING_NUMBER, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                        //Required Entry #4
                        errorMessage =
                       BusinessValidationRepository.AssertIsNotNullOrEmpty(irs.BankDetails.BankName,
                                                                           Constants.EFILE_REQUIRED_BANK_NAME, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);


                    }

                    //Required Entry #5
                    errorMessage = BusinessValidationRepository.AssertIsTrue(irs.IsIRSPaymentOptionAgreed,
                                                                 Constants.EFILE_REQUIRED_INSTRUCTION_DIRECT_DEBIT, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    //Validation Entry #1
                    errorMessage = BusinessValidationRepository.AssertIsValidRTN(
                                           irs.BankDetails.RoutingTransitNumber,
                                              Constants.EFILE_ROUTING_NUMBER_VALIDATION, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }
                else if (irs.IRSPaymentOption == IRSPaymentOption.EFTPS)
                {
                    //Required Entry #6
                    errorMessage = BusinessValidationRepository.AssertIsTrue(irs.IsIRSPaymentOptionAgreed,
                                                                  Constants.EFILE_REQUIRED_INSTRUCTION_EFTPS, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }
                else if (irs.IRSPaymentOption == IRSPaymentOption.CheckByMail)
                {
                    //Required Entry #7
                    errorMessage = BusinessValidationRepository.AssertIsTrue(irs.IsIRSPaymentOptionAgreed,
                                                                  Constants.EFILE_REQUIRED_INSTRUCTION_CHECK_OR_MONEY_ORDER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }


            }
        }

        private void FilingBusinessValidation(Filing filing, List<ErrorMessage> errorMessageList,
           ErrorMessages errorMessages)
        {
            ErrorMessage errorMessage;
            if (filing != null)
            {
                errorMessage = BusinessValidationRepository.AssertIsNotNull(filing.Email,
                                                                    Constants.EFILE_REQUIRED_EMAIL, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
                else
                {

                    errorMessage = BusinessValidationRepository.AssertIsValidEmail(filing.Email,
                                                                      Constants.EFILE_VALIDATION_EMAIL, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

                if (filing.HaveFiledPriorYearReturnElectronically)
                    errorMessage = BusinessValidationRepository.AssertIsNotNull(filing.HaveFiledPriorYearReturnElectronically,
                                                              Constants.EFILE_REQUIRED_FILED_MODE, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
            }
        }


        private void IRSTranmissionBusinessValidation(IRSTransmission irsTransmission, List<ErrorMessage> errorMessageList,
           ErrorMessages errorMessages, Filing filing)
        {
            ErrorMessage errorMessage;
            if (filing != null)
            {
                //VAlidation Entry #9

                if (irsTransmission != null)
                {
                    if (filing.HaveFiledPriorYearReturnElectronically)
                    {

                        if ((irsTransmission.HasReceivedIPINFromIRS.HasValue && irsTransmission.HasReceivedIPINFromIRS.Value) ||
                            (irsTransmission.HavePriorYearAGI.HasValue && irsTransmission.HavePriorYearAGI.Value))
                        {

                            if (irsTransmission.FilingDate != null && irsTransmission.FilingDate.Value.Date != DateTime.Now.Date)
                            {
                                errorMessage = errorMessages[Constants.EFILE_VALIDATION_TODAY_DATE];
                                errorMessageList.Add(errorMessage);
                            }

                        }
                        else if (irsTransmission.HavePriorYearAGIAndPIN.HasValue && irsTransmission.HavePriorYearAGIAndPIN.Value)
                        {
                            if ((irsTransmission.PrimaryTaxPayerFilingDate.HasValue && irsTransmission.PrimaryTaxPayerFilingDate.Value.Date != DateTime.Now.Date) || (irsTransmission.SpouseFilingDate.HasValue && irsTransmission.SpouseFilingDate.Value.Date != DateTime.Now.Date))
                            {
                                errorMessage = errorMessages[Constants.EFILE_VALIDATION_TODAY_DATE];
                                errorMessageList.Add(errorMessage);
                            }
                        }
                    }
                    else
                    {
                        if ((irsTransmission.TaxpayerDateIssuedByIRS.HasValue && irsTransmission.TaxpayerDateIssuedByIRS.Value.Date != DateTime.Now.Date) || (irsTransmission.SpouseDateIssuedByIRS.HasValue && irsTransmission.SpouseDateIssuedByIRS.Value.Date != DateTime.Now.Date))
                        {
                            errorMessage = errorMessages[Constants.EFILE_VALIDATION_TODAY_DATE];
                            errorMessageList.Add(errorMessage);
                        }


                        if ((string.IsNullOrEmpty(irsTransmission.TaxpayerEFINIssuedByIRS)) || (string.IsNullOrEmpty(irsTransmission.SpouseEFINIssuedByIRS)))
                        {
                            //Required Entry #18
                            errorMessage = errorMessages[Constants.EFILE_REQUIRED_PRIMARY_PIN];

                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }

                        if ((!irsTransmission.TaxpayerDateIssuedByIRS.HasValue) || (!irsTransmission.SpouseDateIssuedByIRS.HasValue))
                        {
                            //Required Entry #19
                            errorMessage = errorMessages[Constants.EFILE_REQUIRED_PRIOR_IRS_DATE];

                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }

                    }

                }
            }

            if (irsTransmission != null)
            {
                if (irsTransmission.HavePriorYearPIN.HasValue && irsTransmission.HavePriorYearPIN.Value)
                {
                    //Rquired Entry #14
                    if ((string.IsNullOrEmpty(irsTransmission.PrimaryPIN)) || (string.IsNullOrEmpty(irsTransmission.SpousePIN)))
                    {
                        errorMessage = errorMessages[Constants.EFILE_REQUIRED_PRIMARY_PIN];

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }
                }
                else if (irsTransmission.HavePriorYearAGI.HasValue && irsTransmission.HavePriorYearAGI.Value)
                {
                    //Required Entry #15
                    if ((((!irsTransmission.PrimaryPriorYearAGI.HasValue || Double.IsNaN(irsTransmission.PrimaryPriorYearAGI.Value)) || (!irsTransmission.SpousePriorYearAGI.HasValue ||Double.IsNaN(irsTransmission.SpousePriorYearAGI.Value))) ||
                        ((string.IsNullOrEmpty(irsTransmission.PrimaryPriorYearPIN)) || (string.IsNullOrEmpty(irsTransmission.SpousePriorYearPIN)))))
                    {

                        errorMessage = errorMessages[Constants.EFILE_REQUIRED_PRIOR_YEAR_AGI];

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                    }

                }
                else if (irsTransmission.HavePriorYearAGIAndPIN.HasValue && irsTransmission.HavePriorYearAGIAndPIN.Value)
                {
                    //Required Entry #16
                    if ((string.IsNullOrEmpty(irsTransmission.PrimaryTaxpayerEFIN)) || (string.IsNullOrEmpty(irsTransmission.SpouseEFIN)))
                    {
                        errorMessage = errorMessages[Constants.EFILE_REQUIRED_PRIMARY_PIN];

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }
                }

                if ((!irsTransmission.PrimaryTaxPayerFilingDate.HasValue) || (!irsTransmission.SpouseFilingDate.HasValue))
                {
                    //Required Entry #17
                    errorMessage = errorMessages[Constants.EFILE_REQUIRED_PRIOR_IRS_DATE];

                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

                if (irsTransmission.HasReceivedIPINFromIRS.HasValue && irsTransmission.HasReceivedIPINFromIRS.Value)
                {
                    if ((string.IsNullOrEmpty(irsTransmission.PrimaryTaxPayerIPIN)) || (string.IsNullOrEmpty(irsTransmission.SpouseIPIN)))
                    {
                        //Required Entry #17
                        errorMessage = errorMessages[Constants.EFILE_REQUIRED_PRIMARY_IPIN];

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);


                    }


                }

            }
        }

        #endregion
    }
}
