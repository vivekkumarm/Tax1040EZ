/*
Copyright   : Copyright Jeevan Technologies
File Name   : OtherIncomeRepository.cs 
Description : Other Income Repository for Tax Return  
Author      : Vivek
Created Date : 7 Apr 2014

 * Modification History:
---------------------
* 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.  
 * 02May2014 Bala Modified code to clear the error messages from error message list. 
 * 22 May 2014-Vincent - Modified code in Persist method & Delete 
 * 22 May 2014-Vincent- Added Related error message code for other income
 * 23 May 2014-Vincent- Refatored the Required Validation entry and Review changes 
 * 29 May 2014-Vincent- Removed the unwanted null in other income persist method
 * 2 Jun 2014-Vincent-Worked on State & local required validation & error Message in Delete,Persist & get. 
 * 5 Jun 2014- Vincent- Worked on Hard Stopper.
 * Saravanan - 13th June 2014 - PersistOtherIncome parameter changed to dynamic type.
 */
using System;
using System.Collections.Generic;
using System.Activities;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.DataAccess;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.Core.Object;
using Newtonsoft.Json;
using Tax1040WorkFlow.WorkFlow.Activities;
using System.Linq;
using System.Dynamic;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;


namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Having OtherIncome related methods.
    /// </summary>
    public class OtherIncomeRepository : IOtherIncomeRepository
    {
        #region Private variables
        Tuple<string, string, string, string> taxPayerAndSpouseNames;
        ITaxReturnDataService taxReturnDataService;
        private readonly MessagesRepository messageRepository;
        #endregion

        #region Constructors
        public OtherIncomeRepository()
        {
            taxReturnDataService = new TaxReturnDataService();
            messageRepository = new MessagesRepository();
        }
        #endregion

        #region Persist Methods
        /// <summary>
        /// Delete and then Persist Form1099G.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="form1099GId"></param>
        /// <param name="errorMessageList"></param>
        public void DeleteAndPersistOtherIncome(long userId, long userDataId, OtherIncomeType otherIncomeType)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            try
            {
                //Retrieving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

                //Converting Json to Form1099G by DeSerializing
                if (taxObject != null && taxObject.Income != null && taxObject.Income.OtherIncome != null)
                {
                   
                    switch (otherIncomeType)
                    {
                        case OtherIncomeType.SocialSecurityAndRailRoadBenefits:
                            taxObject.Income.OtherIncome.SSB = null;
                            taxObject.Income.OtherIncome.RRB = null;
                            taxObject.Income.OtherIncome.HasSsbAndRrb = false;
                            // Clear the Error messages
                            messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_OTHER_INCOME_SSB_RRB);

                            //Vincent - 17 June, 2014 - Clear Eligibility HardStopper Errors.
                            messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_OTHER_INCOME, 0, "OtherIncome_ER2");
                            //Yogalakshmi - 2nd July 2014 - To clear the datas in SSB & RRB Worksheet when the records are deleted.
                            if (taxObject.F1040EZ != null && taxObject.F1040EZ.F1040EZWorkSheets != null &&
                            taxObject.F1040EZ.F1040EZWorkSheets.SSBWorkSheet != null)
                            {
                                taxObject.F1040EZ.F1040EZWorkSheets.SSBWorkSheet = null;
                                Utilities.PersistTaxObject(userId, userDataId, taxObject);
                            }
                            break;

                        case OtherIncomeType.AlaskaDividendIncome:
                            taxObject.Income.OtherIncome.AlaskaPermanentFundDividend = null;
                            taxObject.Income.OtherIncome.HasAlaskaPermanantFund = false;
                            // Clear the Error messages
                            messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_OTHER_INCOME_Alaska);
                            
                            break;
                    }

                   
                }


                //Persist latest TaxObject.
                taxReturnDataService.PersistTaxReturnData(userId, string.Empty, Utilities.ConvertTaxObjectToJSON(taxObject), string.Empty, userDataId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Saravanan N - 20th May, 2014 - Return type altered as long.
        /// <summary>
        /// Persist Other Income.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="sessionData"></param>
        /// <param name="otherIncomeData"></param>
        /// <param name="historyData"></param>
        /// <param name="userDataId"></param>
        /// <param name="errorMessageList"></param>
        /// <returns></returns>
        public Tuple<long,bool> PersistOtherIncome(dynamic taxReturn)
        {
            long userId = 0;
            TaxReturnData taxReturnData = null;
            JTL.Tax1040.BusinessObject.Tax1040 taxObject = null;
            bool hasEligibilityDiagnostics = false, fromIncomeGateway = false;
            OtherIncome otherIncome = null;

            try
            {
                if(taxReturn != null)
                {
                    taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(taxReturn.TaxReturnData.ToString());
                    userId = Utilities.ConvertToLong(taxReturn.userId);

                    //Retrieving TaxObject from database
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);

                    //Converting Json to OtherIncome by DeSerializing
                    otherIncome = JsonConvert.DeserializeObject<OtherIncome>(taxReturnData.TaxData);

                    //Check whether this Persist call coming from OtherIncomeGateway page.
                    fromIncomeGateway = taxReturn.fromIncomeGateway;
                }

                if (taxObject != null && otherIncome != null)
                {
                    if (taxObject.Income == null)
                        taxObject.Income = new Income();

                    taxObject.Income.OtherIncome = otherIncome;
                }

               
                if (!fromIncomeGateway)
                {
                    if (taxObject.ErrorMessages == null)
                    {
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }

                    // Clear the Error messages
                    //SSB & RRB
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_OTHER_INCOME_SSB_RRB);
                    //Alaska
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_OTHER_INCOME_Alaska);
                    //State & Local
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_OTHER_INCOME_State_And_Local);
                    //Other Income for Eligibility Section
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_OTHER_INCOME);
                    //Workflow Validation Section
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;

                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessages = new ErrorMessages(errorMessage);
                    input.ErrorMessages = errorMessages;

                    // TODO 4-June-14 vivek Added eligibility work flow

                    if (taxObject != null && taxObject.Income != null && taxObject.Income.OtherIncome != null && taxObject.Income.OtherIncome.SSB != null && taxObject.Income.OtherIncome.RRB != null)
                    {
                        //Checking if the SSB & RRB as value and not equal to Zero.
                        if (taxObject.Income.OtherIncome.SSB.TaxpayerNetBenefits != 0 || taxObject.Income.OtherIncome.RRB.TaxpayerNetBenefits != 0)
                        {
                        var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new
                                Form1040EZSSBEligibilityWithNoValidation(), input));
                        }

                    }

                    BusinessFieldValidations(otherIncome, taxObject.ErrorMessages, errorMessages);



                    //TODO vivek - 7-4-14 need to be change the work flow.
                    var output1 = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke
                                                                        (new OtherIncomeBusinessRuleValidation(), input));

                    //Hard Stopper Check
                    hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => em.Topic ==
                                Constants.TOPIC_OTHER_INCOME && em.ErrorCode.StartsWith("OtherIncome_ER"));
                }

                if (taxObject != null)
                {
                    taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);
                }

                return new Tuple<long, bool>(taxReturnData.UserDataId, hasEligibilityDiagnostics);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Saravanan N - 20th May, 2014 - Code refactored from its Controller.
        /// <summary>
        /// Get OtherIncome
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        public Tuple<OtherIncome, FilingStatus> GetOtherIncome(UserDTO userDTO)
        {
            try
            {
                FilingStatus filingStatus = FilingStatus.None;

                OtherIncome otherIncome = null;
                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId.ConvertToLong(),
                                                    userDTO.UserDataId.ConvertToLong());

                if (taxObject != null)
                {
                    if (taxObject.Income != null && taxObject.Income.OtherIncome != null)
                    {
                        otherIncome = taxObject.Income.OtherIncome;
                    }

                    if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null)
                    {
                        filingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                    }
                }

                return new Tuple<OtherIncome, FilingStatus>(otherIncome, filingStatus);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Saravanan N - 20th May, 2014 - Code refactored from its Controller.
        /// <summary>
        /// Get OtherIncome Summary
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        public System.Tuple<OtherIncome, IEnumerable<ErrorMessage>, string, string, string, string> GetOtherIncomeSummary(dynamic userInputData)
        {
            try
            {

                OtherIncome otherIncome = null;
                IEnumerable<ErrorMessage> lstErrorMessages = null;
                

                //Get TaxObject from Database.
                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(Utilities.ConvertToLong(userInputData.userId.Value),
                                                    Utilities.ConvertToLong(userInputData.userDataId.Value));

                if (taxObject != null)
                {
                    //Tax Payer and Spouse name
                    taxPayerAndSpouseNames = Utilities.GetTaxPayerAndSpouseName(taxObject);


                    if (taxObject.Income != null && taxObject.Income.OtherIncome != null)
                    {
                        otherIncome = taxObject.Income.OtherIncome;
                    }

                    if (taxObject.ErrorMessages != null)
                    {
                        //If ErrorMessages doesn't have any object it returns count as 1 for NULL object. So removing this NULL object from the list.
                        taxObject.ErrorMessages.RemoveAll(err => err == null);

                        if (taxObject.ErrorMessages.Count > 0)
                        {
                            //Get Other Income related error messages.
                            // 17Jun2014 Sathish reterived all the error message including eligibility rule for navigation to hot stop from summary
                            lstErrorMessages = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_OTHER_INCOME_SSB_RRB 
                                                                            || err.Topic == Constants.TOPIC_OTHER_INCOME_Alaska 
                                                                            || err.Topic == Constants.TOPIC_OTHER_INCOME_State_And_Local
                                                                            || err.Topic == Constants.TOPIC_OTHER_INCOME);
                        }
                    }

                    // Clearing the eligibility Error messages.
                    //SSB & RRB
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, topic: Constants.TOPIC_OTHER_INCOME, errorCode: "OtherIncome_ER2");
                   
                    //Workflow Validation Section
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;

                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessages = new ErrorMessages(errorMessage);
                    input.ErrorMessages = errorMessages;

                   //Vincent-30Jun2014-Rechecking the Eligibility Check For ER2

                    if (taxObject != null && taxObject.Income != null && taxObject.Income.OtherIncome != null && taxObject.Income.OtherIncome.SSB != null && taxObject.Income.OtherIncome.RRB != null)
                    {
                        //Checking if the SSB & RRB as value and not equal to Zero.
                        if (taxObject.Income.OtherIncome.SSB.TaxpayerNetBenefits != 0 || taxObject.Income.OtherIncome.RRB.TaxpayerNetBenefits != 0)
                        {
                            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new
                                    Form1040EZSSBEligibilityWithNoValidation(), input));
                        }

                    }

                    if (taxObject != null && taxObject.UserDataId != 0)
                    {
                        Utilities.PersistTaxObject(userInputData.userId.Value, userInputData.userDataId.Value, taxObject);
                    }

                }

                return new Tuple<OtherIncome, IEnumerable<ErrorMessage>, string, string, string, string>(otherIncome, lstErrorMessages, taxPayerAndSpouseNames.Item1, taxPayerAndSpouseNames.Item2, taxPayerAndSpouseNames.Item3, taxPayerAndSpouseNames.Item4);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Business Validations

        //Vivekkumar - 10th April, 2014 - Business validations added.
        public void BusinessFieldValidations(OtherIncome otherIncome, List<ErrorMessage> errorMessageList, ErrorMessages errorMessages)
        {

            ErrorMessage errorMessage;

            //Required field validations 1.
            if (otherIncome.HasSsbAndRrb)
            {
                //Vincent-6 jun 2014 - fixed the issue number -TAX1040-13971
                if (otherIncome == null || otherIncome.SSB == null || otherIncome.RRB == null || (otherIncome.SSB.TaxpayerNetBenefits == 0
                   && otherIncome.RRB.TaxpayerNetBenefits == 0))
                {
                    errorMessage = errorMessages[Constants.OTHERINCOME_NET_BENEFITS];
                    errorMessageList.Add(errorMessage);
                }

            }

            if (otherIncome.HasAlaskaPermanantFund)
            {
                //Required Entry 2

                if (otherIncome == null || otherIncome.AlaskaPermanentFundDividend == null || (otherIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend == null
                    && otherIncome.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend == null))
                {
                    errorMessage = errorMessages[Constants.OTHERINCOME_ALASKA_DIVIDEND_INCOME_MISSING];
                    errorMessageList.Add(errorMessage);
                }

            }

            //Vincent-2/6/14- Worked on State & local required validation
            if (otherIncome.HasStateTaxRefund)
            {
                //Required Entry 3
                if (otherIncome == null || otherIncome.StateOrLocalIncomeTaxRefunds == null || otherIncome.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear == null)
                {
                    errorMessage = errorMessages[Constants.OTHERINCOME_WHOSE_TAXREFUND_IS_THIS];
                    errorMessageList.Add(errorMessage);
                }

                //Required Entry 4
                if (otherIncome == null || otherIncome.StateOrLocalIncomeTaxRefunds == null || otherIncome.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear.HasValue &&
                    otherIncome.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear.Value)
                {
                    if (otherIncome == null || otherIncome.StateOrLocalIncomeTaxRefunds == null || otherIncome.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear == null)
                    {
                        errorMessage = errorMessages[Constants.OTHERINCOME_STATE_CODE];
                        errorMessageList.Add(errorMessage);
                    }
                }
            }



        }
        #endregion
    }
}
