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
 */

using System;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.DataAccess;
using System.Activities;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.PDFBinding;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Business class for Tax Return Data
    /// </summary>
    public class TaxReturnRepository : ITaxReturnRepository
    {
        ITaxReturnDataService taxReturnDataService;
        private readonly MessagesRepository messageRepository;

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxReturnRepository"/> class.
        /// </summary>
        public TaxReturnRepository()
        {
            taxReturnDataService = new TaxReturnDataService();
            messageRepository = new MessagesRepository();
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
        public System.Tuple<double, double, double, double, string, System.Tuple<bool, bool, bool, bool>> GetIncomeSummary(long userId, long userDataId)
        {
            double wagesAmount = 0;
            double interestIncomeAmount = 0;
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
            else if(taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null &&
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

            }

            // 18Jun2014 Sathish Return returned selected income to show or hide 
            System.Tuple<bool, bool, bool, bool> incomeSummary =  new System.Tuple<bool, bool, bool, bool>
                                                             (hasW2Wages, hasInterestIncome, hasUnemploymentCompensation, hasOtherIncome);
            return new System.Tuple<double, double, double, double, string, System.Tuple<bool, bool, bool, bool>>(wagesAmount, interestIncomeAmount,
                                                            unemploymentCompensationAmount, otherIncomeAmount,
                                                                nickName,
                                                        incomeSummary);
        }
        #endregion

        #region GetWorksheet
        /// <summary>
        /// Get the work sheet
        /// will be removed after testing
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        public byte[] GetWorksheet(UserDTO userInputData,string worksheetName)
        {
            var tax1040Object = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.UserId,
                                                                            userInputData.UserDataId);
            F1040EZPDFBinding bind = new F1040EZPDFBinding();
            return bind.OutPutForm(tax1040Object, worksheetName);
        }
        #endregion

    }
}
