/*
Copyright   : Copyright Jeevan Technologies
File Name   : ITaxReturnDataService.cs 
Description : Business Logic for Tax Return  
Author      : Ashok Kumar
Created Date : 17 Mar 2014

 * Modification History:
-------------------------
 * 
Author        : Ashok Kumar
Modified Date : 17 Mar 2014
Decription    : Added input parameter to Get Method  - GetTaxReturnDatabyUserDataId

Author        : Ashok Kumar
Modified Date : 26 Mar 2014
Decription    : Receiving W2 instead of whole TaxObject for persisting 
 
Author        : Bala
Modified Date : 10 Apr 14
Decription    : Added DeleteAndPersistW2 method to delete and persist the w2 object. 
 
Author        : Vincent
Modified Date : 16th April 2014
Decription    : Added a error message navigation for required user control.

Author          : Vincent
Modified Date  : 22th April 2014
Decription      : Added W2LocalTaxInfomethod in W2StateLocalTaxInfo validation.
 
Author         : Bala
Modified Date : 23 Apr 14
Decription     : Moved W2 wages related methods into W2Repository class. 
 * 
Author : Vincent
Modified Date : 28 Apr 2014 
Decription : Added GetIncomeandErrorList method for income summary
 
Author : Vincent
Modified Date : 30 Apr 2014 
Decription : changes GetIncomeandErrorList method for income summary
 * 
Author : Swapnesh
Modified Date : 06 May 2014 
Decription : Added Error Log Method for Exception Handling
 * 
 * 28 July 2014 Swapnesh - Changes done to display all Income diagnostics
 * 
 */

using System;
using System.Linq;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.DataAccess;
using System.Activities;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.PDFBinding;
using System.Collections.Generic;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Business class for Tax Return Data
    /// </summary>
    public class TaxReturnRepository : ITaxReturnRepository
    {
        ITaxReturnDataService taxReturnDataService;
        private readonly MessagesRepository messageRepository;

        IPaymentDataService paymentDataService;

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxReturnRepository"/> class.
        /// </summary>
        public TaxReturnRepository()
        {
            taxReturnDataService = new TaxReturnDataService();
            messageRepository = new MessagesRepository();

            paymentDataService = new PaymentDataService();
        }
        #endregion

        #region Persit Tax Return Data
        /// <summary>
        /// Persist session data in TaxObject.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="sessionData"></param>
        public void PersistSessionData(long userId, long userDataId, string sessionData)
        {
            taxReturnDataService.PersistSessionData(userId, userDataId, sessionData);
        }
        #endregion

        #region Get Methods
        /// <summary>
        /// Gets the tax return databy user data identifier.
        /// </summary>
        /// <param name="userDataId">The user data identifier.</param>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public string GetTaxReturnDatabyUserDataId(long userDataId, long userId)
        {
            var taxReturnData = string.Empty;
            try
            {
                taxReturnData = taxReturnDataService.GetTaxReturnDatabyUserDataId(userDataId, userId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return taxReturnData;
        }

        /// <summary>
        /// Gets the SessionData by UserId and UserDataId.
        /// </summary>
        /// <param name="userDataId">The user data identifier.</param>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public string GetSessionDatabyUserIdAndUserDataId(UserDTO userDTO)
        {
            string sessionData = string.Empty;
            try
            {
                sessionData = taxReturnDataService.GetSessionDataByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sessionData;
        }

        /// <summary>
        /// Gets the userDataId by userId.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>The user data id.</returns>
        public long GetUserDataIdByUserId(long userId)
        {
            var userDataId = 0L;
            try
            {
                userDataId = taxReturnDataService.GetUserDataIdByUserId(userId);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:TaxReturnRepository,Methord Name:GetUserDataIdByUserId", ex);
            }

            return userDataId;
        }
        #endregion


        #region Get Income

        // 18Jun2014 Sathish Return returned selected income to show or hide 
        public System.Tuple<double, double, double, double, string, System.Tuple<bool, bool, bool, bool>, IEnumerable<ErrorMessage>> GetIncomeSummary(long userId, long userDataId)
        {
            double wagesAmount = 0;
            double interestIncomeAmount = 0;
            IEnumerable<ErrorMessage> lstErrorMessages = null;
            double unemploymentCompensationAmount = 0;
            double otherIncomeAmount = 0;
            string nickName = "";

            bool hasW2Wages = false;
            bool hasInterestIncome = false;
            bool hasUnemploymentCompensation = false;
            bool hasOtherIncome = false;

            var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);




            //Get Nick Name.
            if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                taxObject.PersonalDetails.PrimaryTaxPayer.Person != null && taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName != null &&
                taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName != string.Empty)
            {
                nickName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName;
            }
            else if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                taxObject.PersonalDetails.PrimaryTaxPayer.Person != null && taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName != null &&
                taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName != string.Empty)
            {
                nickName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName;
            }

            if (taxObject != null)
            {
                if (taxObject.Income != null)
                {
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new IncomeSummaryCalculation(), input));
                    wagesAmount = output.TotalWagesAmount;
                    interestIncomeAmount = output.TotalInterestIncomeAmount;
                    unemploymentCompensationAmount = output.TotalUnemploymentAmount;
                    otherIncomeAmount = output.TotalOtherIncomeAmount;

                    hasW2Wages = taxObject.Income.HasW2Wages;
                    hasInterestIncome = taxObject.Income.HasInterestIncome;
                    hasUnemploymentCompensation = taxObject.Income.HasUnemploymentCompensation;
                    hasOtherIncome = taxObject.Income.HasOtherIncome;
                }

                //Swapnesh - 28th July, 2014 - Get ErrorMessage if exists.
                if (taxObject.ErrorMessages != null)
                {
                    //If ErrorMessages doesn't have any object it returns count as 1 for NULL object. So removing this NULL object from the list.
                    taxObject.ErrorMessages.RemoveAll(err => err == null);

                    if (taxObject.ErrorMessages.Count > 0)
                    {
                        lstErrorMessages = taxObject.ErrorMessages
                            .Where(a => a.Tab == Constants.Tab_INCOME)
                            .OrderBy(x => x.ErrorType).ThenBy(a => a.Topic);
                    }
                   
                }

            }

            // 18Jun2014 Sathish Return returned selected income to show or hide 
            System.Tuple<bool, bool, bool, bool> incomeSummary = new System.Tuple<bool, bool, bool, bool>
                                                             (hasW2Wages, hasInterestIncome, hasUnemploymentCompensation, hasOtherIncome);
            return new System.Tuple<double, double, double, double, string, System.Tuple<bool, bool, bool, bool>, IEnumerable<ErrorMessage>>(wagesAmount, interestIncomeAmount,
                                                            unemploymentCompensationAmount, otherIncomeAmount,
                                                                nickName,
                                                        incomeSummary,
                                                        lstErrorMessages);
        }
        #endregion




        public double GetFederalSummaryDetails(UserDTO userDTO)
        {
            //Retreiving TaxObject from database
            double totalAmount = 0;
            try
            {
                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                if (taxObject.PersonalDetails != null)
                {

                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                                WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), input));


                    if (taxObject.OutputForms.Tax1040EZPage1.RefundAmount > 0)
                    {
                        totalAmount = -Math.Abs(taxObject.OutputForms.Tax1040EZPage1.RefundAmount);
                    }
                    else
                    {
                        totalAmount = taxObject.OutputForms.Tax1040EZPage1.TaxOweAmount;
                    }
                }

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:PaymentRepository,Method Name:GetFederalSummaryDetails", ex);
            }
            return totalAmount;
        }

        #region OrderExistByUserDataId
        public bool IsOrderExistByUserDataId(PaymentDTO paymentDTO)
        {
            bool isOrderExist = false;
            try
            {
                if (paymentDTO.UserDataId != 0)
                {
                    paymentDTO.ProductType = ProductType.Form1040EZ;
                    isOrderExist = paymentDataService.IsOrderExistByUserDataId(paymentDTO);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(paymentDTO.UserId, "Class:PaymentRepository,Method Name:IsOrderExistByUserDataId", ex);
            }
            return isOrderExist;
        }
        #endregion OrderExistByUserDataId



        #region GetWorksheet
        /// <summary>
        /// Get the work sheet
        /// will be removed after testing
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        public byte[] GetWorksheet(UserDTO userInputData, string worksheetName)
        {
            var tax1040Object = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.UserId,
                                                                            userInputData.UserDataId);
            F1040EZPDFBinding bind = new F1040EZPDFBinding();
            return bind.OutPutForm(tax1040Object, worksheetName);
        }
        #endregion

        #region UserReferralAndRating

        /// <summary>
        /// Get User Rating
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        /// 22Jul2014 Sathish return user rating BO contains comment and rating
        public UserRating GetUserRating(UserDTO userDTO)
        {
            UserRating userRating = null;
            try
            {
                userRating = taxReturnDataService.GetUserRating(userDTO);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:PaymentRepository,Method Name:GetUserRating", ex);
            }
            return userRating;
        }

        /// <summary>
        /// Persist User Rating
        /// </summary>
        /// <param name="userDTO"></param>
        /// <param name="userRating"></param>
        public void PersistUserRating(UserDTO userDTO, UserRating userRating)
        {
            try
            {
                if (userDTO.UserId != 0) // 22Jul2014 Sathish checked user ID not equal to zero 
                    taxReturnDataService.PersistUserRating(userDTO, userRating);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:PaymentRepository,Method Name:GetUserRating", ex);
            }
        }

        /// <summary>
        /// Persist User Referal
        /// </summary>
        /// <param name="userDTO"></param>
        /// <param name="userReferral"></param>
        // 22Jul2014 Sathish changed user referral to Referral rating
        public void PersistUserReferral(UserDTO userDTO, ReferralRating referralRating)
        {
            try
            {
                if (userDTO.UserId != 0) // 22Jul2014 Sathish checked user ID not equal to zero 
                    taxReturnDataService.PersistUserReferral(userDTO, referralRating);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:PaymentRepository,Method Name:PersistUserReferral", ex);
            }
        }
        #endregion

    }
}
