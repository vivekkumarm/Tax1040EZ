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


namespace JTL.Tax1040.BusinessLogic
{
    public class OtherIncomeRepository : IOtherIncomeRepository
    {
        #region Private variables
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
                 if (taxObject != null && taxObject.Income != null && taxObject.Income.OtherIncome!= null)
                 {
                     switch (otherIncomeType)
                     {
                         case OtherIncomeType.SocialSecurityAndRailRoadBenefits:
                            taxObject.Income.OtherIncome.SSB = null;
                            taxObject.Income.OtherIncome.RRB = null;
                            // Clear the Error messages
                            messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_OTHER_INCOME);
                            break;

                         case OtherIncomeType.AlaskaDividendIncome:
                            taxObject.Income.OtherIncome.AlaskaPermanentFundDividend = null;
                            // Clear the Error messages
                            messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_OTHER_INCOME);
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
         public dynamic PersistOtherIncome(long userId, TaxReturnData taxReturnData)
        {
            try
            {
                JTL.Tax1040.BusinessObject.Tax1040 taxObject;

                //Retrieving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);

                //Converting Json to OtherIncome by DeSerializing
                OtherIncome otherIncome = JsonConvert.DeserializeObject<OtherIncome>(taxReturnData.TaxData);

                if (taxObject != null && otherIncome != null)
                {
                    if (taxObject.Income == null)
                        taxObject.Income = new Income();

                    taxObject.Income.OtherIncome = otherIncome;
                }

                if (taxObject.ErrorMessages == null)
                {
                taxObject.ErrorMessages = new List<ErrorMessage>();
                }

              

                // Clear the Error messages
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_OTHER_INCOME);

                //Workflow Validation Section
                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
               
                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);
                input.ErrorMessages = errorMessages;

                BusinessFieldValidations(otherIncome, taxObject.ErrorMessages, errorMessages);

                if (taxObject != null && (taxObject.Income.OtherIncome.HasSsbAndRrb || taxObject.Income.OtherIncome.HasAlaskaPermanantFund == null 
                    || taxObject.Income.OtherIncome.HasStateTaxRefund == null))
                {
                    //TODO vivek - 7-4-14 need to be change the work flow.
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new OtherIncomeBusinessRuleValidation(), input));
                }
                if (taxObject!=null)
                {
                    taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);
                }

                return taxReturnData.UserDataId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Business Validations

        //Vivekkumar - 10th April, 2014 - Business validations added.
        public void BusinessFieldValidations(OtherIncome otheIncome, List<ErrorMessage> errorMessageList, ErrorMessages errorMessages)
        {
            ErrorMessage errorMessage;

            //Required field validations 1.
            if (otheIncome == null || otheIncome.SSB == null || otheIncome.SSB.TaxpayerNetBenefits == null || double.IsNaN(otheIncome.SSB.TaxpayerNetBenefits))
            {
                errorMessage = errorMessages[Constants.OTHERINCOME_NET_BENEFITS];
                errorMessageList.Add(errorMessage);
            }

            if (otheIncome == null || otheIncome.RRB == null || otheIncome.RRB.NetBenefits == null || double.IsNaN(otheIncome.RRB.NetBenefits))
            {
                errorMessage = errorMessages[Constants.OTHERINCOME_NET_BENEFITS];
                errorMessageList.Add(errorMessage);
            }
            if (otheIncome == null || otheIncome.AlaskaPermanentFundDividend == null || otheIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend == null 
                || double.IsNaN(otheIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend.Value))
            {
                errorMessage = errorMessages[Constants.OTHERINCOME_ALASKA_DIVIDEND_INCOME_MISSING];
                errorMessageList.Add(errorMessage);
            }
            if (otheIncome == null || otheIncome.AlaskaPermanentFundDividend == null || otheIncome.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend == null 
                || double.IsNaN(otheIncome.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend.Value))
            {
                errorMessage = errorMessages[Constants.OTHERINCOME_ALASKA_DIVIDEND_INCOME_MISSING];
                errorMessageList.Add(errorMessage);
            }
            if (otheIncome == null || otheIncome.HasClaimedItemizedDeductionPriorYear != null)
            {
                errorMessage = errorMessages[Constants.OTHERINCOME_WHOSE_TAXREFUND_IS_THIS];
                errorMessageList.Add(errorMessage);
            }
            if (otheIncome == null || otheIncome.HasStateAndLocalTaxDeductionPriorYear != null)
            {
                errorMessage = errorMessages[Constants.OTHERINCOME_STATE_CODE];
                errorMessageList.Add(errorMessage);
            }



        }
        #endregion
    }
}
