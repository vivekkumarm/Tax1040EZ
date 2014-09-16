

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
 * Thileep-22July2014 Added and changed some business validation in IRSTranmissionBusinessValidation method 
 * Thileep-22July2014 changed PersistIRSTranmission  method to return Error messages
 * Thileep-24July2014 changed PersistIRSTranmission  and Businessvalidation depend on Filingstatus * 
 * Sathsih-25Jul2014 Implemented new BO functionality
 * Bhavani - 23 July 2014 - Removed unused variables taxObjectErrorList
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
        //25Jul2014 Sathish return only filling because filling will have IRS Transmission
        //31Jul2014 Sathish changed parameter user Id and User Data Id to User DTO
        public System.Tuple<string, PersonalDetails, Filing, bool> GetPersonAndIRSTransmission(UserDTO userDTO)
        {
            bool hasEfileErrors = false;
            //Retreiving TaxObject from database
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
            //IRSTransmission irsTransmission = new IRSTransmission();
            //Filing filing = new Filing();

            if (taxObject.ErrorMessages != null)
            {
                //If ErrorMessages doesn't have any object it returns count as 1 for NULL object. So removing this NULL object from the list.
                taxObject.ErrorMessages.RemoveAll(err => err == null);

                if (taxObject.ErrorMessages.Count > 0)
                {
                    //Get EFile related error messages.
                    hasEfileErrors = taxObject.ErrorMessages.Any(err => err.Topic == Constants.TOPIC_FILING);

                }
            }
            //25Jul2014 Sathish return only filling because filling will have IRS Transmission
            return new System.Tuple<string, PersonalDetails, Filing, bool>(Utilities.GetTaxPayerFirstNameOrNickName(taxObject),
                                                                           ((taxObject.PersonalDetails != null) ? taxObject.PersonalDetails : null),
                                                ((taxObject.Filing != null) ? taxObject.Filing : null), hasEfileErrors);

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
                    errorMessage = taxObject.ErrorMessages.FindAll(err => err.Topic == Constants.TOPIC_FILING);
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
        /// vivek 15-july-14 Delete federal Efile Information
        public bool DeleteEfileInformation(UserDTO UserData)
        {
            bool IsDeleted = false;
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(UserData.UserId, UserData.UserDataId);
            if (taxObject != null && taxObject.Filing.FederalFiling != null)
            {
                //TODO: Commented by vivek for deleting the e file information
                //28Jul2014 Sathish Delete efile information 
                //04Aug2014 Sathish cleared filing option and AGI/IRSTransmission detail On cancel file or if it has error
                //12Aug2014 Sathish as per discussion with BA only IRS Transmission is cleared while cance E-File
                //taxObject.Filing.FederalFiling.IsEfile = null;
                //taxObject.Filing.FederalFiling.ReturnStatus = ReturnStatus.None;
                if (taxObject.Filing.FederalFiling.IRS != null && taxObject.Filing.FederalFiling.IRS.IRSTransmission != null)
                    taxObject.Filing.FederalFiling.IRS.IRSTransmission = null;
                Utilities.PersistTaxObject(UserData.UserId, UserData.UserDataId, taxObject);
                IsDeleted = true;
            }
            return IsDeleted;
        }

        public bool DeleteIRSTransmissionDetail(UserDTO UserData)
        {
            bool IsDeleted = false;
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(UserData.UserId, UserData.UserDataId);
            if (taxObject != null && taxObject.Filing != null && taxObject.Filing.FederalFiling != null
                && taxObject.Filing.FederalFiling.IRS != null
                && taxObject.Filing.FederalFiling.IRS.IRSTransmission != null)
            {
                taxObject.Filing.FederalFiling.IRS.IRSTransmission = null;
                Utilities.PersistTaxObject(UserData.UserId, UserData.UserDataId, taxObject);
                IsDeleted = true;
            }
            return IsDeleted;
        }


        // Vincent- 3 July 2014 - Added the methed form Payment repository.
        public System.Tuple<double, Filing> GetIRSPaymentOption(UserDTO userDTO)
        {

            //Retreiving TaxObject from database
            System.Tuple<double, Filing> irsPaymentOption = null;
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                //Vincent-2/7/2014-Added the Federal Summary workflow to get TaxOweAmount.
                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
                var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                            WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), input));

                var totalTaxOweAmount = taxObject.OutputForms.Tax1040EZPage1.TaxOweAmount;

                irsPaymentOption = new System.Tuple<double, Filing>(totalTaxOweAmount, taxObject.Filing);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:PaymentRepository,Method Name:GetPaymentDetails", ex);
            }
            return irsPaymentOption;
        }
        //25Jul2014 Sathish return dynamic for filling and filling state
        public dynamic GetFilingOptionSummary(UserDTO userDTO)
        {
            dynamic userData = new ExpandoObject();
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                if (taxObject != null && taxObject.Filing != null)
                {
                    userData.Filing = taxObject.Filing;
                }

                //25Jul2014 Sathish return selected state from state filing and state gate way
                if (taxObject != null
                    && taxObject.StateBO != null
                    && taxObject.StateBO.FilerStates != null
                    && taxObject.Filing != null
                    && taxObject.Filing.StateFiling != null
                    && taxObject.Filing.StateFiling.Count > 0
                    && taxObject.Filing.StateFiling[0].State != null)
                {

                    var stateFiling = (from fillerState in taxObject.StateBO.FilerStates
                                       join stateFilling in taxObject.Filing.StateFiling on fillerState.State.StateId
                                       equals stateFilling.State.StateId into ft
                                       from st in ft.DefaultIfEmpty()
                                       select new
                                       {
                                           fillerState.State.StateId,
                                           fillerState.State.StateName,
                                           st.IsEfile,
                                           ReturnStatusDescription = st.ReturnStatusDescription
                                       }).ToList();

                    userData.StateFiling = stateFiling;

                }

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:EFileRepository,Method Name:GetFilingOptionSummary", ex);
            }
            return userData;


        }

        //25Jul2014 Sathish return selected state from state filing and state gate way
        public dynamic GetEFilingOption(UserDTO userDTO)
        {
            dynamic userData = new ExpandoObject();
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                if (taxObject != null && taxObject.Filing != null)
                {
                    userData.Filing = taxObject.Filing;
                }
                //25Jul2014 Sathish return selected state from state filing and state gate way
                if (taxObject != null
                    && taxObject.StateBO != null
                    && taxObject.StateBO.FilerStates != null
                    && taxObject.Filing != null
                    && taxObject.Filing.StateFiling != null
                    && taxObject.Filing.StateFiling.Count > 0
                    && taxObject.Filing.StateFiling[0].State != null)
                {

                    var stateFiling = (from fillerState in taxObject.StateBO.FilerStates
                                       join stateFilling in taxObject.Filing.StateFiling on fillerState.State.StateId
                                       equals stateFilling.State.StateId into ft
                                       from st in ft.DefaultIfEmpty(new StateFiling() { IsEfile = null, ReturnStatus = ReturnStatus.None }) //30Jul2014 Sathish created default value if state not persisted
                                       select new
                                       {
                                           fillerState.State.StateId,
                                           fillerState.State.StateName,
                                           st.IsEfile,
                                           st.ReturnStatusDescription
                                       }).ToList();

                    userData.StateFiling = stateFiling;

                }
                else if (taxObject != null
                    && taxObject.StateBO != null
                    && taxObject.StateBO.FilerStates != null)
                {
                    var stateFiling = (from fillerState in taxObject.StateBO.FilerStates
                                       select new
                                       {
                                           fillerState.State.StateId,
                                           fillerState.State.StateName,
                                           IsEfile = DBNull.Value,
                                           ReturnStatusDescription = ReturnStatus.None
                                       }).ToList();

                    userData.StateFiling = stateFiling;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:EFileRepository,Method Name:GetEFilingOption", ex);
            }
            return userData;
        }

        //25Jul2014 Sathish return status for hiding control in UI
        public ReturnStatus GetIRSReturnStatus(UserDTO userDTO)
        {
            ReturnStatus returnStatus = ReturnStatus.None;
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                if (taxObject != null && taxObject.Filing != null && taxObject.Filing.FederalFiling != null)
                {
                    //filing = new Filing();
                    returnStatus = taxObject.Filing.FederalFiling.ReturnStatus;
                }

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:EFileRepository,Method Name:GetFilingOptionSummary", ex);
            }
            return returnStatus;
        }

        #endregion

        #region Persist

        /// <summary>
        /// Persists the IRS tranmission before efile.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="taxReturnData">The tax return data.</param>
        /// <returns></returns>
        public Tuple<BusinessObject.Tax1040, string, List<ErrorMessage>> PersistIRSTransmissionBeforeEfile(long userId, TaxReturnData taxReturnData)
        {
            BusinessObject.Tax1040 taxObject = new BusinessObject.Tax1040();
            List<ErrorMessage> taxObjectErrorList = new List<ErrorMessage>();
            string encryptedstring = string.Empty;
            string strTaxObject = string.Empty;

            Tuple<long, string> encryptedTaxObject = new Tuple<long, string>(0, "");

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
                //25Jul2014 Sathish added null reference check based on new BO
                else if (taxObject.Filing == null)
                {
                    taxObject.Filing = new Filing() { FederalFiling = new FederalFiling() { IRS = new IRS() } };
                }
                else if (taxObject.Filing.FederalFiling == null)
                {
                    taxObject.Filing.FederalFiling = new FederalFiling() { IRS = new IRS() };
                }
                else if (taxObject.Filing.FederalFiling.IRS == null)
                {
                    taxObject.Filing.FederalFiling.IRS = new IRS();
                }

                //Retrieving Error Message list from Database
                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);

                // Clear the Error messages exist for this topic.
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FILING);
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EFILESERVICE);

                //Deserialize IRSTransmission object
                IRSTransmission irsTransmission = JsonConvert.DeserializeObject<IRSTransmission>(taxReturnData.TaxData);
                taxObject.Filing.FederalFiling.IRS.IRSTransmission = irsTransmission;

                var filing = taxObject.Filing;
                if (taxObject.ErrorMessages == null)
                    taxObject.ErrorMessages = new List<ErrorMessage>();
                IRSTranmissionBusinessValidation(taxObject.Filing.FederalFiling.IRS.IRSTransmission,
                                                 taxObject.ErrorMessages, errorMessages, filing,
                                                 ((taxObject != null && taxObject.PersonalDetails != null &&
                                                   taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                                                   taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus != null)
                                                      ? taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus
                                                      : FilingStatus.None));

                if (taxObject.ErrorMessages != null)
                {
                    taxObjectErrorList = taxObject.ErrorMessages.FindAll(em => em.Topic == Constants.TOPIC_FILING);
                }

                if (taxObjectErrorList.Count == 0 && taxObject.Filing.FederalFiling.IsEfile.HasValue &&
                    taxObject.Filing.FederalFiling.IsEfile.Value)
                {
                    strTaxObject = Utilities.ConvertTaxObjectToJSON(taxObject);

                    encryptedstring = Utilities.Encrypt(strTaxObject,
                                                        ConfigurationManager.AppSettings[Constants.EncryptionKey]);
                }

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:EFileRepository,Method Name:PersistIRSTranmission", ex);
            }

            return new Tuple<BusinessObject.Tax1040, string, List<ErrorMessage>>(taxObject, encryptedstring, taxObjectErrorList);
        }


        /// <summary>
        /// Persist for IRS Transmission
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taxReturnData"></param>
        /// <returns></returns>
        /// Swapnesh 8/aug/2014
        public long PersistIRSTransmissionEfile(long userId, JTL.Tax1040.BusinessObject.Tax1040 taxObject, EfileErrorCollection efileerrorcollection)
        {
            //  List<ErrorMessage> taxObjectErrorList = null;
            try
            {
                if (efileerrorcollection.Count > 0)
                {
                    var errorMessage = messageRepository.GetEfileErrorMessage(efileerrorcollection);

                    if (taxObject.ErrorMessages == null)
                    {
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }

                    taxObject.ErrorMessages = taxObject.ErrorMessages.Concat(errorMessage).ToList();
                }


                taxObject.UserDataId = Utilities.PersistTaxObject(userId, taxObject.UserDataId, taxObject);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:EFileRepository,Method Name:PersistIRSTranmission", ex);
            }
            return taxObject.UserDataId;
        }


        /// <summary>
        /// Get E-file Service Error Message
        /// </summary>
        /// <param name="UserData"></param>
        /// <returns></returns>
        /// Swapnesh  8-August-14 Geting efile Service Error Messages
        public IEnumerable<ErrorMessage> GetEfileErrorMessage(UserDTO UserData)
        {
            IEnumerable<ErrorMessage> errorMessage = null;
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(UserData.UserId, UserData.UserDataId);
                if (taxObject.ErrorMessages != null)
                {
                    errorMessage = taxObject.ErrorMessages.FindAll(err => err.Topic == Constants.TOPIC_EFILESERVICE).OrderBy(er => er.FieldName);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(UserData.UserId, "Class:EFileRepository,Method Name:GetEfileErrorMessage", ex);
            }
            return errorMessage;
        }

        //   OLD
        /// <summary>
        /// Persist for IRS Transmission
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taxReturnData"></param>
        /// <returns></returns>
        /// ///vivek 2-july-2014 persist method for the irs transmission 
        /// //25Jul2014 Sathish added null reference check based on new BO
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
                //25Jul2014 Sathish added null reference check based on new BO
                else if (taxObject.Filing == null)
                {
                    taxObject.Filing = new Filing() { FederalFiling = new FederalFiling() { IRS = new IRS() } };
                }
                else if (taxObject.Filing.FederalFiling == null)
                {
                    taxObject.Filing.FederalFiling = new FederalFiling() { IRS = new IRS() };
                }
                else if (taxObject.Filing.FederalFiling.IRS == null)
                {
                    taxObject.Filing.FederalFiling.IRS = new IRS();
                }

                //Retrieving Error Message list from Database
                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);

                // Clear the Error messages exist for this topic.
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FILING);

                //Deserialize IRSTransmission object
                IRSTransmission irsTransmission = JsonConvert.DeserializeObject<IRSTransmission>(taxReturnData.TaxData);
                taxObject.Filing.FederalFiling.IRS.IRSTransmission = irsTransmission;

                var filing = taxObject.Filing;
                if (taxObject.ErrorMessages == null)
                    taxObject.ErrorMessages = new List<ErrorMessage>();
                IRSTranmissionBusinessValidation(taxObject.Filing.FederalFiling.IRS.IRSTransmission,
                                                 taxObject.ErrorMessages, errorMessages,
                    filing,
                                                 ((taxObject != null && taxObject.PersonalDetails != null &&
                                                   taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                                                   taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus != null)
                                                      ? taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus
                                                      : FilingStatus.None));

                if (taxObject.ErrorMessages != null)
                {
                    taxObjectErrorList = taxObject.ErrorMessages.FindAll(em => em.Topic.Equals(Constants.TOPIC_FILING));
                }

                //persist tax object
                taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:EFileRepository,Method Name:PersistIRSTranmission", ex);
            }
            //11Aug2014 Sathish return user data id instead of user id and stored in session
            return new Tuple<long, List<ErrorMessage>>(taxReturnData.UserDataId, taxObjectErrorList);
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
                    taxObject = new BusinessObject.Tax1040 { Filing = new Filing() };
                }
                else if (taxObject.Filing == null)
                {
                    taxObject.Filing = new Filing();
                }

                //Retrieving Error Message list from Database
                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);

                //Deserialize IRSTransmission object
                Filing filling = JsonConvert.DeserializeObject<Filing>(taxReturnData.TaxData);
                taxObject.Filing = filling;
                //persist tax object
                if (taxObject.ErrorMessages == null)
                    taxObject.ErrorMessages = new List<ErrorMessage>();


                //// Clear the Error messages
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FILING);


                FilingBusinessValidation(taxObject.Filing, taxObject.ErrorMessages, errorMessages);
                taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);

                //31Jul2014 Sathish returned error message associated to efile
                if (taxObject.ErrorMessages != null)
                {
                    taxObjectErrorList = taxObject.ErrorMessages.FindAll(em => em.Topic.Equals(Constants.TOPIC_FILING));
                }

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:EFileRepository,Method Name:PersistFiling", ex);
            }
            //11Aug2014 Sathish returned user data id and saved in session
            return new Tuple<long, List<ErrorMessage>>(taxReturnData.UserDataId, taxObjectErrorList);
        }

        /// <summary>
        /// Vincent- 3 July 2014 - Added the methed form Payment repository.
        /// </summary>
        /// <param name="paymentDTO"></param>
        /// <returns></returns>
        public Tuple<long, List<ErrorMessage>> PersistIRSPaymentOption(PaymentDTO paymentDTO)
        {
            List<ErrorMessage> lstErrorMessage = null;
            Tuple<long, List<ErrorMessage>> irsPaymentOption = null;
            try
            {
                IRS irs = paymentDTO.IRS;

                if (irs != null)
                {
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(paymentDTO.UserId, paymentDTO.UserDataId);

                    //25Jul2014 Sathish checked null reference based on new bo
                    if (taxObject == null)
                    {
                        taxObject = new BusinessObject.Tax1040()
                            {
                                Filing = new Filing() { FederalFiling = new FederalFiling() { IRS = new IRS() } }
                            };
                    }
                    else if (taxObject.Filing == null)
                    {
                        taxObject.Filing = new Filing() { FederalFiling = new FederalFiling() { IRS = new IRS() } };
                    }
                    else if (taxObject.Filing.FederalFiling == null)
                    {
                        taxObject.Filing.FederalFiling = new FederalFiling() { IRS = new IRS() };
                    }
                    else if (taxObject.Filing.FederalFiling.IRS == null)
                    {
                        taxObject.Filing.FederalFiling.IRS = new IRS();
                    }
                    taxObject.Filing.FederalFiling.IRS = irs;

                    //Retrieving Error Message list from Database
                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessages = new ErrorMessages(errorMessage);

                    //// Clear the Error messages
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FILING);
                    if (taxObject.ErrorMessages == null)
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    IRSPaymentOptionBusinessValidation(taxObject.Filing.FederalFiling.IRS, taxObject.ErrorMessages,
                                                       errorMessages);

                    paymentDTO.UserDataId = Utilities.PersistTaxObject(paymentDTO.UserId, paymentDTO.UserDataId,
                                                                       taxObject);

                    //28Jul2014 Sathish returned error message associated to efile
                    if (taxObject.ErrorMessages != null)
                    {
                        lstErrorMessage = taxObject.ErrorMessages.FindAll(em => em.Topic.Equals(Constants.TOPIC_FILING));
                    }
                }

                irsPaymentOption = new Tuple<long, List<ErrorMessage>>(paymentDTO.UserDataId, lstErrorMessage);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(paymentDTO.UserId,
                                               "Class:PaymentRepository,Method Name:PersistIRSPaymentOption", ex);
            }
            return irsPaymentOption;

        }
        #endregion

        #region E-mail
        public bool SendEMail(long userId, long userDataId)
        {
            //string userDataId = null;
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
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

                //errorMessage = BusinessValidationRepository.AssertGreaterThanZero(irs.PaymentOption.GetHashCode(),
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
                if (irs.PaymentOption == PaymentOption.None)
                {
                    errorMessage = errorMessages[Constants.FILING_IRS_PAYEMENT_OPTION_NULL];
                    errorMessageList.Add(errorMessage);
                }
                switch (irs.PaymentOption)
                {
                    case PaymentOption.DirectDebit:
                        if (irs.BankDetails != null)
                        {
                            if (irs.BankDetails.BankAccountTypeCode == AccountType.None)
                            {
                                //Required Entry #1
                                errorMessage = errorMessages[Constants.FILING_REQUIRED_TYPE_OF_ACCOUNT];
                                errorMessageList.Add(errorMessage);
                            }

                            //Required Entry #2
                            errorMessage =
                            BusinessValidationRepository.AssertIsNotNullOrEmpty(irs.BankDetails.AccountNumber,
                                                                                        Constants
                                                                                            .FILING_REQUIRED_ACCOUNT_NUMBER,
                                                                                        errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                            else
                            {
                                errorMessage = BusinessValidationRepository.AssertIsAccountNumber(irs.BankDetails.AccountNumber,
                                                   Constants.FILING_VALIDATION_ACCOUNT_NUMBER, errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }

                            //Required Entry #3
                            errorMessage =
                                    BusinessValidationRepository.AssertIsNotNullOrEmpty(
                                        irs.BankDetails.RoutingTransitNumber,
                                                                               Constants.FILING_REQUIRED_ROUTING_NUMBER, errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                            else  //12Aug2014 Sathish validate routing number if value is not empty
                            {
                                errorMessage = BusinessValidationRepository.AssertIsValidRTN(irs.BankDetails.RoutingTransitNumber,
                                                                                              Constants.FILING_ROUTING_NUMBER_VALIDATION, errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }

                            //Required Entry #4
                            errorMessage =
                           BusinessValidationRepository.AssertIsNotNullOrEmpty(irs.BankDetails.BankName,
                                                                                        Constants.FILING_REQUIRED_BANK_NAME,
                                                                                        errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }
                        errorMessage = BusinessValidationRepository.AssertIsTrue(irs.IsIRSPaymentOptionAgreed,
                                                                                     Constants
                                                                                         .FILING_REQUIRED_INSTRUCTION_DIRECT_DEBIT,
                                                                                     errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                        break;
                    case PaymentOption.EFTPS:
                        errorMessage = BusinessValidationRepository.AssertIsTrue(irs.IsIRSPaymentOptionAgreed,
                                                                                     Constants
                                                                                         .FILING_REQUIRED_INSTRUCTION_EFTPS,
                                                                                     errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                        break;
                    case PaymentOption.CheckByMail:
                        errorMessage = BusinessValidationRepository.AssertIsTrue(irs.IsIRSPaymentOptionAgreed,
                                                                                     Constants
                                                                                         .FILING_REQUIRED_INSTRUCTION_CHECK_OR_MONEY_ORDER,
                                                                                     errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                        break;
                }
            }
        }

        private void FilingBusinessValidation(Filing filing, List<ErrorMessage> errorMessageList,
           ErrorMessages errorMessages)
        {
            ErrorMessage errorMessage = null;
            if (filing != null)
            {
                if ((filing.FederalFiling != null &&
                    filing.FederalFiling.IsEfile.HasValue
                    && filing.FederalFiling.IsEfile.Value) ||
                    (filing.StateFiling != null &&
                    filing.StateFiling.Count > 0 &&
                    filing.StateFiling.Any(ef => ef.IsEfile.HasValue && ef.IsEfile.Value)))
                {
                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(filing.Email,
                                                            Constants.FILING_REQUIRED_EMAIL,
                                                            errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }
                if (filing.Email != string.Empty)
                {
                    errorMessage = BusinessValidationRepository.AssertIsValidEmail(filing.Email,
                                                                                         Constants.FILING_VALIDATION_EMAIL,
                                                                                         errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                }




                bool isFederalFile = false;
                bool isStateFile = false;
                if (filing.FederalFiling != null
                    && filing.FederalFiling.IsEfile.HasValue)
                    isFederalFile = true;

                if (filing.StateFiling != null
                    && filing.StateFiling.Any(ef => ef.IsEfile.HasValue))
                    isStateFile = true;

                if (!isFederalFile && !isFederalFile)
                    errorMessageList.Add(errorMessages[Constants.FILING_REQUIRED_FILING_OPTION]);

                if (!filing.HaveFiledPriorYearReturnElectronically.HasValue)
                {
                    errorMessage =
                        BusinessValidationRepository.AssertIsTrue(filing.HaveFiledPriorYearReturnElectronically.HasValue,
                                                              Constants.FILING_REQUIRED_FILED_MODE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }
            }
        }


        private void IRSTranmissionBusinessValidation(IRSTransmission irsTransmission, List<ErrorMessage> errorMessageList,
           ErrorMessages errorMessages, Filing filing, FilingStatus filingStatus)
        {
            ErrorMessage errorMessage = null;
            if (filing != null)
            {
                //VAlidation Entry #9

                if (irsTransmission != null)
                {
                    if (filing.HaveFiledPriorYearReturnElectronically.HasValue && filing.HaveFiledPriorYearReturnElectronically.Value)
                    {

                        if (irsTransmission.HavePriorYearAGIAndPIN.HasValue &&
                            irsTransmission.HavePriorYearAGIAndPIN.Value)
                        {
                            if (filingStatus != null && filingStatus == FilingStatus.MarriedFilingJointly)
                            {
                                if ((!string.IsNullOrEmpty(irsTransmission.PrimaryTaxpayerEFIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(irsTransmission.PrimaryTaxpayerEFIN, 5,
                                                                                 Constants.FILING_VALIDATION_PAYER_EFIN,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }

                                if ((!string.IsNullOrEmpty(irsTransmission.SpouseEFIN)))
                                {

                                    errorMessage = BusinessValidationRepository.AssertIsPIN(irsTransmission.SpouseEFIN,
                                                                                            5,
                                                                                            Constants
                                                                                                .FILING_VALIDATION_SPOUSE_EFIN,
                                                                                            errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                //30Jul2014 Sathish commented since this option removed in the spec #1.3
                                //if ((irsTransmission.PrimaryTaxPayerFilingDate.HasValue &&
                                //     irsTransmission.PrimaryTaxPayerFilingDate.Value.Date != DateTime.Now.Date))
                                //{
                                //    errorMessage = errorMessages[Constants.EFILE_VALIDATION_PAYER_AGI_PIN_TODAY_DATE];
                                //    if (errorMessage != null)
                                //        errorMessageList.Add(errorMessage);
                                //}
                                //if ((!irsTransmission.PrimaryTaxPayerFilingDate.HasValue) ||
                                //    (!irsTransmission.SpouseFilingDate.HasValue))
                                //{
                                //    //Required Entry #17
                                //    errorMessage = errorMessages[Constants.EFILE_REQUIRED_PRIOR_IRS_DATE];

                                //    if (errorMessage != null)
                                //        errorMessageList.Add(errorMessage);
                                //}
                                //if ((irsTransmission.SpouseFilingDate.HasValue &&
                                //     irsTransmission.SpouseFilingDate.Value.Date != DateTime.Now.Date))
                                //{
                                //    errorMessage = errorMessages[Constants.EFILE_VALIDATION_SPOUSE_AGI_PIN_TODAY_DATE];
                                //    if (errorMessage != null)
                                //        errorMessageList.Add(errorMessage);
                                //}
                            }

                            else if (filingStatus != null && filingStatus == FilingStatus.Single)
                            {
                                if ((!string.IsNullOrEmpty(irsTransmission.PrimaryTaxpayerEFIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(irsTransmission.PrimaryTaxpayerEFIN, 5,
                                                                                 Constants.FILING_VALIDATION_PAYER_EFIN,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);

                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }

                                //if ((irsTransmission.PrimaryTaxPayerFilingDate.HasValue &&
                                //     irsTransmission.PrimaryTaxPayerFilingDate.Value.Date != DateTime.Now.Date))
                                //{
                                //    errorMessage = errorMessages[Constants.EFILE_VALIDATION_PAYER_AGI_PIN_TODAY_DATE];
                                //    if (errorMessage != null)
                                //        errorMessageList.Add(errorMessage);
                                //}
                                //if ((!irsTransmission.PrimaryTaxPayerFilingDate.HasValue))
                                //{
                                //    //Required Entry #17
                                //    errorMessage = errorMessages[Constants.EFILE_REQUIRED_PRIOR_IRS_DATE];

                                //    if (errorMessage != null)
                                //        errorMessageList.Add(errorMessage);
                                //}
                            }
                            //Required Entry #

                        }

                        else if (irsTransmission.HavePriorYearAGI.HasValue && irsTransmission.HavePriorYearAGI.Value)
                        {
                            if (filingStatus != null && filingStatus == FilingStatus.MarriedFilingJointly)
                            {
                                if ((!string.IsNullOrEmpty(irsTransmission.PrimaryPriorYearPIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(irsTransmission.PrimaryPriorYearPIN, 5,
                                                                                 Constants
                                                                                     .FILING_VALIDATION_PAYER_PRIORYEAR_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIOR_YEAR_AGI];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                if ((!string.IsNullOrEmpty(irsTransmission.SpousePriorYearPIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(irsTransmission.SpousePriorYearPIN, 5,
                                                                                 Constants
                                                                                     .FILING_VALIDATION_SPOUSE_PRIORYEAR_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIOR_YEAR_AGI];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);

                                }
                            }
                            else if (filingStatus != null && filingStatus == FilingStatus.Single)
                            {
                                if ((!string.IsNullOrEmpty(irsTransmission.PrimaryPriorYearPIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(irsTransmission.PrimaryPriorYearPIN, 5,
                                                                                 Constants
                                                                                     .FILING_VALIDATION_PAYER_PRIORYEAR_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIOR_YEAR_AGI];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                            }
                        }

                        else if (irsTransmission.HavePriorYearPIN.HasValue && irsTransmission.HavePriorYearPIN.Value)
                        {

                            if (filingStatus != null && filingStatus == FilingStatus.MarriedFilingJointly)
                            {
                                if ((!string.IsNullOrEmpty(irsTransmission.PrimaryPIN)))
                                {

                                    errorMessage = BusinessValidationRepository.AssertIsPIN(irsTransmission.PrimaryPIN,
                                                                                            5,
                                                                                            Constants
                                                                                                .FILING_VALIDATION_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                            errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);


                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                if ((!string.IsNullOrEmpty(irsTransmission.SpousePIN)))
                                {

                                    errorMessage = BusinessValidationRepository.AssertIsPIN(irsTransmission.SpousePIN, 5,
                                                                                            Constants
                                                                                                .FILING_VALIDATION_SPOUSE_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                            errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                            }
                            else if (filingStatus != null && filingStatus == FilingStatus.Single)
                            {
                                if ((!string.IsNullOrEmpty(irsTransmission.PrimaryPIN)))
                                {

                                    errorMessage = BusinessValidationRepository.AssertIsPIN(irsTransmission.PrimaryPIN,
                                                                                            5,
                                                                                            Constants
                                                                                                .FILING_VALIDATION_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                            errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                            }
                        }


                        errorMessage = BusinessValidationRepository.AssertIsTrue(irsTransmission.HasReceivedIPINFromIRS.HasValue,
                                                                                Constants.FILING_REQUIRED_IRS_PIN,
                                                                                errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                        else
                        {
                            if (irsTransmission.HasReceivedIPINFromIRS.HasValue &&
                                irsTransmission.HasReceivedIPINFromIRS.Value)
                            {
                                if (filingStatus != null && filingStatus == FilingStatus.MarriedFilingJointly)
                                {
                                    if ((!string.IsNullOrEmpty(irsTransmission.PrimaryTaxPayerIPIN)))
                                    {

                                        errorMessage =
                                            BusinessValidationRepository.AssertIsPIN(irsTransmission.PrimaryTaxPayerIPIN, 6,
                                                                                     Constants
                                                                                             .FILING_VALIDATION_IDENTITY_PRODECTION_PIN,
                                                                                     errorMessages);
                                        if (errorMessage != null)
                                            errorMessageList.Add(errorMessage);


                                    }
                                    else
                                    {
                                        errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_IPIN];

                                        if (errorMessage != null)
                                            errorMessageList.Add(errorMessage);

                                    }
                                    if ((!string.IsNullOrEmpty(irsTransmission.SpouseIPIN)))
                                    {

                                        errorMessage = BusinessValidationRepository.AssertIsPIN(irsTransmission.SpouseIPIN,
                                                                                                6,
                                                                                                Constants
                                                                                                        .FILING_VALIDATION_SPOUSE_IDENTITY_PRODECTION_PIN,
                                                                                                errorMessages);
                                        if (errorMessage != null)
                                            errorMessageList.Add(errorMessage);


                                    }
                                    else
                                    {

                                        errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_IPIN];

                                        if (errorMessage != null)
                                            errorMessageList.Add(errorMessage);

                                    }

                                }
                                else if (filingStatus != null && filingStatus == FilingStatus.Single)
                                {
                                    if ((!string.IsNullOrEmpty(irsTransmission.PrimaryTaxPayerIPIN)))
                                    {

                                        errorMessage =
                                            BusinessValidationRepository.AssertIsPIN(irsTransmission.PrimaryTaxPayerIPIN, 6,
                                                                                     Constants
                                                                                             .FILING_VALIDATION_IDENTITY_PRODECTION_PIN,
                                                                                     errorMessages);
                                        if (errorMessage != null)
                                            errorMessageList.Add(errorMessage);
                                    }
                                    else
                                    {
                                        errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_IPIN];

                                        if (errorMessage != null)
                                            errorMessageList.Add(errorMessage);
                                    }
                                }
                            }


                        }

                        if ((irsTransmission.HavePriorYearAGI.HasValue ||
                             irsTransmission.HavePriorYearAGIAndPIN.HasValue ||
                             irsTransmission.HavePriorYearPIN.HasValue) &&
                            (irsTransmission.FilingDate == null || !irsTransmission.FilingDate.HasValue))
                        {
                            errorMessage = errorMessages[Constants.FILING_REQUIRED_FILING_DATE];
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }
                        if ((irsTransmission.HavePriorYearAGI.HasValue ||
                             irsTransmission.HavePriorYearAGIAndPIN.HasValue ||
                             irsTransmission.HavePriorYearPIN.HasValue) &&
                            (irsTransmission.FilingDate != null &&
                             irsTransmission.FilingDate.Value.Date != DateTime.Now.Date))
                        {
                            errorMessage = errorMessages[Constants.FILING_VALIDATION_TODAY_DATE];
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }

                        if (((!irsTransmission.HavePriorYearAGI.HasValue &&
                              !irsTransmission.HavePriorYearAGIAndPIN.HasValue &&
                              !irsTransmission.HavePriorYearPIN.HasValue &&
                              filing.HaveFiledPriorYearReturnElectronically.HasValue &&
                              filing.HaveFiledPriorYearReturnElectronically.Value)))
                        {
                            errorMessage = errorMessages[Constants.FILING_REQUIRED_PIN_DETAILS];
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }
                    }
                    else
                    {

                        if (filingStatus != null && filingStatus == FilingStatus.MarriedFilingJointly)
                        {
                            if ((!string.IsNullOrEmpty(irsTransmission.TaxpayerEFINIssuedByIRS)))
                            {

                                errorMessage =
                                    BusinessValidationRepository.AssertIsPIN(irsTransmission.TaxpayerEFINIssuedByIRS, 5,
                                                                             Constants
                                                                                 .FILING_VALIDATION_PAYER_EFIN_ISSUEDBYIRS,
                                                                             errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);

                            }
                            else
                            {
                                errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);

                            }
                            if ((!string.IsNullOrEmpty(irsTransmission.SpouseEFINIssuedByIRS)))
                            {

                                errorMessage =
                                    BusinessValidationRepository.AssertIsPIN(irsTransmission.SpouseEFINIssuedByIRS, 5,
                                                                             Constants
                                                                                 .FILING_VALIDATION_SPOUSE_EFIN_ISSUEDBYIRS,
                                                                             errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }

                            else
                            {

                                errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);


                            }

                            if ((!irsTransmission.TaxpayerDateIssuedByIRS.HasValue) ||
                                (!irsTransmission.SpouseDateIssuedByIRS.HasValue))
                            {

                                errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIOR_IRS_DATE];

                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }

                            if ((irsTransmission.TaxpayerDateIssuedByIRS.HasValue &&
                                 irsTransmission.TaxpayerDateIssuedByIRS.Value.Date != DateTime.Now.Date))
                            {

                                errorMessage = errorMessages[Constants.FILING_VALIDATIONTAX_PAYER_TODAY_DATE_ISSUEDBYIRS];
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }
                            if ((irsTransmission.SpouseDateIssuedByIRS.HasValue &&
                                 irsTransmission.SpouseDateIssuedByIRS.Value.Date != DateTime.Now.Date))
                            {

                                errorMessage = errorMessages[Constants.FILING_VALIDATION_SPOUSE_TODAY_DATE_ISSUEDBYIRS];
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }

                        }
                        else if (filingStatus != null && filingStatus == FilingStatus.Single)
                        {
                            if ((!string.IsNullOrEmpty(irsTransmission.TaxpayerEFINIssuedByIRS)))
                            {

                                errorMessage =
                                    BusinessValidationRepository.AssertIsPIN(irsTransmission.TaxpayerEFINIssuedByIRS, 5,
                                                                             Constants
                                                                                 .FILING_VALIDATION_PAYER_EFIN_ISSUEDBYIRS,
                                                                             errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);

                            }
                            else
                            {
                                errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);

                            }
                            if ((!irsTransmission.TaxpayerDateIssuedByIRS.HasValue))
                            {

                                errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIOR_IRS_DATE];

                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }
                            if ((irsTransmission.TaxpayerDateIssuedByIRS.HasValue &&
                                 irsTransmission.TaxpayerDateIssuedByIRS.Value.Date != DateTime.Now.Date))
                            {

                                errorMessage = errorMessages[Constants.FILING_VALIDATIONTAX_PAYER_TODAY_DATE_ISSUEDBYIRS];
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }
                        }

                    }

                }
            }
        }

        #endregion

        #region StateFiling
        #region Get
        // Vincent- 3 July 2014 - Added the methed form Payment repository.
        public System.Tuple<double, StateFiling> GetStatePaymentDetail(StateDTO stateDTO)
        {

            //Retreiving TaxObject from database
            System.Tuple<double, StateFiling> irsPaymentOption = null;
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(stateDTO.UserId, stateDTO.UserDataId);

                //Vincent-2/7/2014-Added the Federal Summary workflow to get TaxOweAmount.
                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
                var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                            WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), input));

                var totalTaxOweAmount = taxObject.OutputForms.Tax1040EZPage1.TaxOweAmount;

                irsPaymentOption = new System.Tuple<double, StateFiling>(totalTaxOweAmount,
                                                                        (taxObject.Filing != null
                                                                          && taxObject.Filing.StateFiling != null
                                                                          && taxObject.Filing.StateFiling.Any()
                                                                          && taxObject.Filing.StateFiling[0].State != null) ?
                                                                        taxObject.Filing.StateFiling.Find(sf => sf.State.StateId.Equals(stateDTO.StateId))
                                                                        : null);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(stateDTO.UserId, "Class:PaymentRepository,Method Name:GetStatePaymentDetail", ex);
            }
            return irsPaymentOption;
        }

        public System.Tuple<string, PersonalDetails, StateFiling, bool, bool> GetPersonAndStateTransmission(StateDTO stateDTO)
        {
            bool hasEfileErrors = false;
            //Retreiving TaxObject from database
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(stateDTO.UserId, stateDTO.UserDataId);
            //IRSTransmission irsTransmission = new IRSTransmission();
            //Filing filing = new Filing();

            if (taxObject.ErrorMessages != null)
            {
                //If ErrorMessages doesn't have any object it returns count as 1 for NULL object. So removing this NULL object from the list.
                taxObject.ErrorMessages.RemoveAll(err => err == null);

                if (taxObject.ErrorMessages.Count > 0)
                {
                    //Get EFile related error messages.
                    hasEfileErrors = taxObject.ErrorMessages.Any(err => err.Topic == Constants.TOPIC_FILING);

                }
            }
            //25Jul2014 Sathish return only filling because filling will have IRS Transmission
            return new System.Tuple<string, PersonalDetails, StateFiling, bool, bool>(Utilities.GetTaxPayerFirstNameOrNickName(taxObject),
                                                                           ((taxObject.PersonalDetails != null) ? taxObject.PersonalDetails : null),
                                                                        (taxObject.Filing != null
                                                                          && taxObject.Filing.StateFiling != null
                                                                          && taxObject.Filing.StateFiling.Any()
                                                                          && taxObject.Filing.StateFiling[0].State != null) ?
                                                                        taxObject.Filing.StateFiling.Find(sf => sf.State.StateId.Equals(stateDTO.StateId))
                                                                        : null, hasEfileErrors,
                                                                        ((taxObject.Filing != null && taxObject.Filing.HaveFiledPriorYearReturnElectronically.HasValue) ? taxObject.Filing.HaveFiledPriorYearReturnElectronically.Value : false));

        }

        #endregion Get
        #region Persist

        public Tuple<long, List<ErrorMessage>> PersistStatePaymentDetail(StateDTO stateDTO)
        {
            List<ErrorMessage> lstErrorMessage = null;
            Tuple<long, List<ErrorMessage>> statePaymentDetail = null;
            try
            {


                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(stateDTO.UserId, stateDTO.UserDataId);
                StateFiling stateFiling = JsonConvert.DeserializeObject<StateFiling>(stateDTO.TaxData);
                //25Jul2014 Sathish checked null reference based on new bo

                if (taxObject.Filing != null
                    && taxObject.Filing.StateFiling != null
                    && taxObject.Filing.StateFiling.Any()
                    && taxObject.Filing.StateFiling[0].State != null)
                {
                    int index = taxObject.Filing.StateFiling.FindIndex(sf => sf.State.StateId.Equals(stateDTO.StateId));
                    if (index >= 0)
                    {
                        //Retrieving Error Message list from Database
                        var errorMessage = messageRepository.GetErrorMessages();
                        var errorMessages = new ErrorMessages(errorMessage);

                        //// Clear the Error messages
                        messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FILING);

                        if (taxObject.ErrorMessages == null)
                            taxObject.ErrorMessages = new List<ErrorMessage>();
                        StatePaymentDetailBusinessValidation(taxObject.Filing.StateFiling[index], taxObject.ErrorMessages,
                                                           errorMessages);

                        taxObject.Filing.StateFiling[index] = stateFiling;

                        stateDTO.UserDataId = Utilities.PersistTaxObject(stateDTO.UserId, stateDTO.UserDataId,
                                                                   taxObject);
                    }
                }

                //28Jul2014 Sathish returned error message associated to efile
                if (taxObject.ErrorMessages != null)
                {
                    lstErrorMessage = taxObject.ErrorMessages.FindAll(em => em.Topic.Equals(Constants.TOPIC_FILING));
                }


                statePaymentDetail = new Tuple<long, List<ErrorMessage>>(stateDTO.UserDataId, lstErrorMessage);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(stateDTO.UserId,
                                               "Class:PaymentRepository,Method Name:PersistStatePaymentDetail", ex);
            }
            return statePaymentDetail;

        }

        public dynamic PersistStateTranmission(StateDTO stateDTO)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            List<ErrorMessage> taxObjectErrorList = null;
            dynamic userData = new ExpandoObject();
            try
            {
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(stateDTO.UserId, stateDTO.UserDataId);
                StateTransmission stateTransmission = JsonConvert.DeserializeObject<StateTransmission>(stateDTO.TaxData);
                if (taxObject.Filing != null
                  && taxObject.Filing.StateFiling != null
                  && taxObject.Filing.StateFiling.Any()
                  && taxObject.Filing.StateFiling[0].State != null)
                {
                    int index = taxObject.Filing.StateFiling.FindIndex(sf => sf.State.StateId.Equals(stateDTO.StateId));
                    if (index >= 0)
                    {
                        //Retrieving Error Message list from Database
                        var errorMessage = messageRepository.GetErrorMessages();
                        var errorMessages = new ErrorMessages(errorMessage);

                        // Clear the Error messages exist for this topic.
                        messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FILING);
                        taxObject.Filing.StateFiling[index].StateTransmission = stateTransmission;

                        if (taxObject.ErrorMessages == null)
                            taxObject.ErrorMessages = new List<ErrorMessage>();

                        StateTranmissionBusinessValidation(taxObject.Filing.StateFiling[index].StateTransmission,
                                 taxObject.ErrorMessages, errorMessages,
                                 (taxObject.Filing != null ? taxObject.Filing : null),
                                 ((taxObject != null && taxObject.PersonalDetails != null &&
                                   taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                                   taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus != null)
                                      ? taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus
                                      : FilingStatus.None));


                        //persist tax object
                        stateDTO.UserDataId = Utilities.PersistTaxObject(stateDTO.UserId, stateDTO.UserDataId, taxObject);
                    }

                }

                if (taxObject.ErrorMessages != null)
                {
                    taxObjectErrorList = taxObject.ErrorMessages.FindAll(em => em.Topic.Equals(Constants.TOPIC_FILING));
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(stateDTO.UserId, "Class:EFileRepository,Method Name:PersistIRSTranmission", ex);
            }
            return new Tuple<long, List<ErrorMessage>>(stateDTO.UserId, taxObjectErrorList);
        }

        #endregion

        #region BusinessValidation
        /// <summary>
        /// Business Fields Validations (Required and Validation) checked.
        /// </summary>
        /// <param name="eic"></param>
        /// <param name="errorMessageList"></param>
        /// <param name="errorMessages"></param>
        private void StatePaymentDetailBusinessValidation(StateFiling stateFiling, List<ErrorMessage> errorMessageList,
           ErrorMessages errorMessages)
        {

            ErrorMessage errorMessage;

            if (stateFiling != null)
            {
                //Required Entry #10
                if (stateFiling.PaymentOption == PaymentOption.None)
                {
                    errorMessage = errorMessages[Constants.FILING_IRS_PAYEMENT_OPTION_NULL];
                    errorMessageList.Add(errorMessage);
                }
                switch (stateFiling.PaymentOption)
                {
                    case PaymentOption.DirectDebit:
                        if (stateFiling.BankDetails != null)
                        {
                            if (stateFiling.BankDetails.BankAccountTypeCode == AccountType.None)
                            {
                                //Required Entry #1
                                errorMessage = errorMessages[Constants.FILING_REQUIRED_TYPE_OF_ACCOUNT];
                                errorMessageList.Add(errorMessage);
                            }

                            //Required Entry #2
                            errorMessage =
                            BusinessValidationRepository.AssertIsNotNullOrEmpty(stateFiling.BankDetails.AccountNumber,
                                                                                        Constants
                                                                                            .FILING_REQUIRED_ACCOUNT_NUMBER,
                                                                                        errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);

                            //Required Entry #3
                            errorMessage =
                                    BusinessValidationRepository.AssertIsNotNullOrEmpty(
                                        stateFiling.BankDetails.RoutingTransitNumber,
                                                                               Constants.FILING_REQUIRED_ROUTING_NUMBER, errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);

                            //Required Entry #4
                            errorMessage =
                           BusinessValidationRepository.AssertIsNotNullOrEmpty(stateFiling.BankDetails.BankName,
                                                                                        Constants.FILING_REQUIRED_BANK_NAME,
                                                                                        errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }
                        errorMessage = BusinessValidationRepository.AssertIsTrue(stateFiling.IsIRSPaymentOptionAgreed,
                                                                                     Constants
                                                                                         .FILING_REQUIRED_INSTRUCTION_DIRECT_DEBIT,
                                                                                     errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                        errorMessage = BusinessValidationRepository.AssertIsValidRTN(
                                               stateFiling.BankDetails.RoutingTransitNumber,
                                                  Constants.FILING_ROUTING_NUMBER_VALIDATION, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                        break;
                    case PaymentOption.EFTPS:
                        errorMessage = BusinessValidationRepository.AssertIsTrue(stateFiling.IsIRSPaymentOptionAgreed,
                                                                                     Constants
                                                                                         .FILING_REQUIRED_INSTRUCTION_EFTPS,
                                                                                     errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                        break;
                    case PaymentOption.CheckByMail:
                        errorMessage = BusinessValidationRepository.AssertIsTrue(stateFiling.IsIRSPaymentOptionAgreed,
                                                                                     Constants
                                                                                         .FILING_REQUIRED_INSTRUCTION_CHECK_OR_MONEY_ORDER,
                                                                                     errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                        break;
                }
            }
        }

        private void StateTranmissionBusinessValidation(StateTransmission stateTransmission, List<ErrorMessage> errorMessageList,
                                                ErrorMessages errorMessages, Filing filing, FilingStatus filingStatus)
        {
            ErrorMessage errorMessage;
            if (filing != null)
            {
                //VAlidation Entry #9

                if (stateTransmission != null)
                {
                    if (filing.HaveFiledPriorYearReturnElectronically.HasValue && filing.HaveFiledPriorYearReturnElectronically.Value)
                    {

                        if (stateTransmission.HavePriorYearAGIAndPIN.HasValue &&
                            stateTransmission.HavePriorYearAGIAndPIN.Value)
                        {
                            if (filingStatus != null && filingStatus == FilingStatus.MarriedFilingJointly)
                            {
                                if ((!string.IsNullOrEmpty(stateTransmission.PrimaryTaxpayerEFIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(stateTransmission.PrimaryTaxpayerEFIN, 5,
                                                                                 Constants.FILING_VALIDATION_PAYER_EFIN,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }

                                if ((!string.IsNullOrEmpty(stateTransmission.SpouseEFIN)))
                                {

                                    errorMessage = BusinessValidationRepository.AssertIsPIN(stateTransmission.SpouseEFIN,
                                                                                            5,
                                                                                            Constants
                                                                                                .FILING_VALIDATION_SPOUSE_EFIN,
                                                                                            errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                            }

                            else if (filingStatus != null && filingStatus == FilingStatus.Single)
                            {
                                if ((!string.IsNullOrEmpty(stateTransmission.PrimaryTaxpayerEFIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(stateTransmission.PrimaryTaxpayerEFIN, 5,
                                                                                 Constants.FILING_VALIDATION_PAYER_EFIN,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);

                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }

                                //if ((irsTransmission.PrimaryTaxPayerFilingDate.HasValue &&
                                //     irsTransmission.PrimaryTaxPayerFilingDate.Value.Date != DateTime.Now.Date))
                                //{
                                //    errorMessage = errorMessages[Constants.EFILE_VALIDATION_PAYER_AGI_PIN_TODAY_DATE];
                                //    if (errorMessage != null)
                                //        errorMessageList.Add(errorMessage);
                                //}
                                //if ((!irsTransmission.PrimaryTaxPayerFilingDate.HasValue))
                                //{
                                //    //Required Entry #17
                                //    errorMessage = errorMessages[Constants.EFILE_REQUIRED_PRIOR_IRS_DATE];

                                //    if (errorMessage != null)
                                //        errorMessageList.Add(errorMessage);
                                //}
                            }
                            //Required Entry #

                        }

                        else if (stateTransmission.HavePriorYearAGI.HasValue && stateTransmission.HavePriorYearAGI.Value)
                        {
                            if (filingStatus != null && filingStatus == FilingStatus.MarriedFilingJointly)
                            {
                                if ((!string.IsNullOrEmpty(stateTransmission.PrimaryPriorYearPIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(stateTransmission.PrimaryPriorYearPIN, 5,
                                                                                 Constants
                                                                                     .FILING_VALIDATION_PAYER_PRIORYEAR_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIOR_YEAR_AGI];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                if ((!string.IsNullOrEmpty(stateTransmission.SpousePriorYearPIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(stateTransmission.SpousePriorYearPIN, 5,
                                                                                 Constants
                                                                                     .FILING_VALIDATION_SPOUSE_PRIORYEAR_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIOR_YEAR_AGI];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);

                                }
                            }
                            else if (filingStatus != null && filingStatus == FilingStatus.Single)
                            {
                                if ((!string.IsNullOrEmpty(stateTransmission.PrimaryPriorYearPIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(stateTransmission.PrimaryPriorYearPIN, 5,
                                                                                 Constants
                                                                                     .FILING_VALIDATION_PAYER_PRIORYEAR_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIOR_YEAR_AGI];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                            }
                        }

                        else if (stateTransmission.HavePriorYearPIN.HasValue && stateTransmission.HavePriorYearPIN.Value)
                        {

                            if (filingStatus != null && filingStatus == FilingStatus.MarriedFilingJointly)
                            {
                                if ((!string.IsNullOrEmpty(stateTransmission.PrimaryPIN)))
                                {

                                    errorMessage = BusinessValidationRepository.AssertIsPIN(stateTransmission.PrimaryPIN,
                                                                                            5,
                                                                                            Constants
                                                                                                .FILING_VALIDATION_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                            errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);


                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                if ((!string.IsNullOrEmpty(stateTransmission.SpousePIN)))
                                {

                                    errorMessage = BusinessValidationRepository.AssertIsPIN(stateTransmission.SpousePIN, 5,
                                                                                            Constants
                                                                                                .FILING_VALIDATION_SPOUSE_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                            errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                            }
                            else if (filingStatus != null && filingStatus == FilingStatus.Single)
                            {
                                if ((!string.IsNullOrEmpty(stateTransmission.PrimaryPIN)))
                                {

                                    errorMessage = BusinessValidationRepository.AssertIsPIN(stateTransmission.PrimaryPIN,
                                                                                            5,
                                                                                            Constants
                                                                                                .FILING_VALIDATION_PERSONAL_IDENTIFICATION_NUMBER,
                                                                                            errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                            }
                        }


                        if (stateTransmission.HasReceivedIPINFromIRS.HasValue &&
                            stateTransmission.HasReceivedIPINFromIRS.Value)
                        {
                            if (filingStatus != null && filingStatus == FilingStatus.MarriedFilingJointly)
                            {
                                if ((!string.IsNullOrEmpty(stateTransmission.PrimaryTaxPayerIPIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(stateTransmission.PrimaryTaxPayerIPIN, 6,
                                                                                 Constants
                                                                                     .FILING_VALIDATION_IDENTITY_PRODECTION_PIN,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);


                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_IPIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);

                                }
                                if ((!string.IsNullOrEmpty(stateTransmission.SpouseIPIN)))
                                {

                                    errorMessage = BusinessValidationRepository.AssertIsPIN(stateTransmission.SpouseIPIN,
                                                                                            6,
                                                                                            Constants
                                                                                                .FILING_VALIDATION_SPOUSE_IDENTITY_PRODECTION_PIN,
                                                                                            errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);


                                }
                                else
                                {

                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_IPIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);

                                }

                            }

                            else if (filingStatus != null && filingStatus == FilingStatus.Single)
                            {
                                if ((!string.IsNullOrEmpty(stateTransmission.PrimaryTaxPayerIPIN)))
                                {

                                    errorMessage =
                                        BusinessValidationRepository.AssertIsPIN(stateTransmission.PrimaryTaxPayerIPIN, 6,
                                                                                 Constants
                                                                                     .FILING_VALIDATION_IDENTITY_PRODECTION_PIN,
                                                                                 errorMessages);
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                                else
                                {
                                    errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_IPIN];

                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                            }
                        }

                        if ((stateTransmission.HavePriorYearAGI.HasValue ||
                             stateTransmission.HavePriorYearAGIAndPIN.HasValue ||
                             stateTransmission.HavePriorYearPIN.HasValue) &&
                            (stateTransmission.FilingDate == null || !stateTransmission.FilingDate.HasValue))
                        {
                            errorMessage = errorMessages[Constants.FILING_REQUIRED_FILING_DATE];
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }
                        if ((stateTransmission.HavePriorYearAGI.HasValue ||
                             stateTransmission.HavePriorYearAGIAndPIN.HasValue ||
                             stateTransmission.HavePriorYearPIN.HasValue) &&
                            (stateTransmission.FilingDate != null &&
                             stateTransmission.FilingDate.Value.Date != DateTime.Now.Date))
                        {
                            errorMessage = errorMessages[Constants.FILING_VALIDATION_TODAY_DATE];
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }

                        if (((!stateTransmission.HavePriorYearAGI.HasValue &&
                              !stateTransmission.HavePriorYearAGIAndPIN.HasValue &&
                              !stateTransmission.HavePriorYearPIN.HasValue && !filing.HaveFiledPriorYearReturnElectronically.HasValue
                               && !filing.HaveFiledPriorYearReturnElectronically.Value)))
                        {
                            errorMessage = errorMessages[Constants.FILING_REQUIRED_PIN_DETAILS];
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }
                    }
                    else
                    {

                        if (filingStatus != null && filingStatus == FilingStatus.MarriedFilingJointly)
                        {
                            if ((!string.IsNullOrEmpty(stateTransmission.TaxpayerEFINIssuedByIRS)))
                            {

                                errorMessage =
                                    BusinessValidationRepository.AssertIsPIN(stateTransmission.TaxpayerEFINIssuedByIRS, 5,
                                                                             Constants
                                                                                 .FILING_VALIDATION_PAYER_EFIN_ISSUEDBYIRS,
                                                                             errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);

                            }
                            else
                            {
                                errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);

                            }
                            if ((!string.IsNullOrEmpty(stateTransmission.SpouseEFINIssuedByIRS)))
                            {

                                errorMessage =
                                    BusinessValidationRepository.AssertIsPIN(stateTransmission.SpouseEFINIssuedByIRS, 5,
                                                                             Constants
                                                                                 .FILING_VALIDATION_SPOUSE_EFIN_ISSUEDBYIRS,
                                                                             errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }

                            else
                            {

                                errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);


                            }

                            if ((!stateTransmission.TaxpayerDateIssuedByIRS.HasValue) ||
                                (!stateTransmission.SpouseDateIssuedByIRS.HasValue))
                            {

                                errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIOR_IRS_DATE];

                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }

                            if ((stateTransmission.TaxpayerDateIssuedByIRS.HasValue &&
                                 stateTransmission.TaxpayerDateIssuedByIRS.Value.Date != DateTime.Now.Date))
                            {

                                errorMessage = errorMessages[Constants.FILING_VALIDATIONTAX_PAYER_TODAY_DATE_ISSUEDBYIRS];
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }
                            if ((stateTransmission.SpouseDateIssuedByIRS.HasValue &&
                                 stateTransmission.SpouseDateIssuedByIRS.Value.Date != DateTime.Now.Date))
                            {

                                errorMessage = errorMessages[Constants.FILING_VALIDATION_SPOUSE_TODAY_DATE_ISSUEDBYIRS];
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }

                        }
                        else if (filingStatus != null && filingStatus == FilingStatus.Single)
                        {
                            if ((!string.IsNullOrEmpty(stateTransmission.TaxpayerEFINIssuedByIRS)))
                            {

                                errorMessage =
                                    BusinessValidationRepository.AssertIsPIN(stateTransmission.TaxpayerEFINIssuedByIRS, 5,
                                                                             Constants
                                                                                 .FILING_VALIDATION_PAYER_EFIN_ISSUEDBYIRS,
                                                                             errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);

                            }
                            else
                            {
                                errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIMARY_PIN];

                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);

                            }
                            if ((!stateTransmission.TaxpayerDateIssuedByIRS.HasValue))
                            {

                                errorMessage = errorMessages[Constants.FILING_REQUIRED_PRIOR_IRS_DATE];

                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }
                            if ((stateTransmission.TaxpayerDateIssuedByIRS.HasValue &&
                                 stateTransmission.TaxpayerDateIssuedByIRS.Value.Date != DateTime.Now.Date))
                            {

                                errorMessage = errorMessages[Constants.FILING_VALIDATIONTAX_PAYER_TODAY_DATE_ISSUEDBYIRS];
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }
                        }

                    }

                }
            }
        }

        #endregion BusinessValidation
        #endregion
    }
}
