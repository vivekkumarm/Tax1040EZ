/*
Copyright   : Copyright Jeevan Technologies
File Name   : DeductionRepository.cs 
Description : Deduction
Author      : Sathish
Created Date : 21Apr2014

 * Modification History:
 * 10Jun2014 Ashok Kumar Persisted tax object with Personal details If Null and invoked utility method to get PrimaryTaxPayerName 
 * 11Jun2014 Ashok Kumar Invoked Deduction No Validation Workflow instead of Deduction Workflow
 * 20Aug2014-Thileep changed and added code in Get method for Taxableincomecheck,Refundoptioncheck and (Income,Refund,Taxes all are Zeros check) 
 */

using System;
using System.Activities;
using System.Dynamic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;
using System.Runtime.CompilerServices;


namespace JTL.Tax1040.BusinessLogic
{
    public class DeductionRepository : IDeductionRepository
    {

        #region Local variable declaration

        IPersonalInfoRepository personalInfoRepository;
        //To Do
        //private readonly MessagesRepository messageRepository;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="W2Repository"/> class.
        /// </summary>
        public DeductionRepository()
        {
            personalInfoRepository = new PersonalInfoRepository();
            //To Do
            //messageRepository = new MessagesRepository();
        }
        #endregion

        #region Get

       public dynamic GetDeductionSummary(UserDTO userDTO)
        {
            try
            {
                BusinessObject.Tax1040 taxObject;
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                dynamic deductionSummaryData = new ExpandoObject();

                if (taxObject == null || taxObject.PersonalDetails == null || taxObject.PersonalDetails.PrimaryTaxPayer == null)
                {
                    if (taxObject == null)
                        taxObject = new BusinessObject.Tax1040()
                        {
                            PersonalDetails = new PersonalDetails()
                            {
                                PrimaryTaxPayer = new PrimaryTaxPayer()
                                {
                                    FilingStatus = FilingStatus.Single,
                                    Person = new Person()
                                }
                            }
                        };

                    if (taxObject.PersonalDetails == null)
                    {
                        taxObject.PersonalDetails = new PersonalDetails()
                        {
                            PrimaryTaxPayer = new PrimaryTaxPayer()
                            {
                                FilingStatus = FilingStatus.Single,
                                Person = new Person()
                            }
                        };
                    }

                    if (taxObject.PersonalDetails.PrimaryTaxPayer == null)
                    {
                        taxObject.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer()
                        {
                            FilingStatus = FilingStatus.Single,
                            Person = new Person()
                        };
                    }

                    Tuple<long, bool> userDataId = personalInfoRepository.PersistPrimaryTaxPayer(taxObject.PersonalDetails.PrimaryTaxPayer, userDTO.UserId, userDTO.UserDataId);

                    deductionSummaryData.UserDataId = userDataId.Item1;

                    //Retrieving TaxObject from database
                    //26Aug2014 Sathish Get Tax object after personal info persist to get the error message list
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, deductionSummaryData.UserDataId);

                }
                else
                {
                    deductionSummaryData.UserDataId = userDTO.UserDataId;
                }



                deductionSummaryData.PrimaryTaxPayerName = Utilities.GetTaxPayerFirstNameOrNickName(taxObject);



                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
                var output =
                    Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                        WorkflowInvoker.Invoke(new F1040EZStandardDeductionWithNoValidation(), input));

                deductionSummaryData.TotalWorksheetStandardDeduction = output.TotalWorksheetStandardDeduction;

                //To DO
                //20Aug2014-Code Added by Thileep to Obtain the List of Error Messages from DB.
                //var errorMessagesFromDB = messageRepository.GetErrorMessages();
                //var errorMessagesAll = new ErrorMessages(errorMessagesFromDB);

                //taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME);
                //taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL);
                //taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_MISSING_INCOME);

                //dynamic federalSummaryInput = new Microsoft.Activities.Extensions.WorkflowArguments();
                //federalSummaryInput.Tax1040Object = taxObject;
                //federalSummaryInput.IsTaxableIncomeExceedCheck = true;
                //federalSummaryInput.IsRefundAvailableCheck = true;
                //federalSummaryInput.IsIncomeAndRefundAllZeros = true;
                //federalSummaryInput.ErrorMessages = errorMessagesAll;
                //output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                //                                         WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), federalSummaryInput));

                ////Persist TaxObject.
                //Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);


                //Bala, 1-sep-14, Get Audit information
                string description = "Get Deduction Summary, ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.Tab_DEDUCTION_INFO, string.Empty);

                return deductionSummaryData;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
       
    }
}
