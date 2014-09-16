/*
Copyright   : Copyright Jeevan Technologies
File Name   : DeductionRepository.cs 
Description : Deduction
Author      : Sathish
Created Date : 21Apr2014

 * Modification History:
 * 10Jun2014 Ashok Kumar Persisted tax object with Personal details If Null and invoked utility method to get PrimaryTaxPayerName 
 * 11Jun2014 Ashok Kumar Invoked Deduction No Validation Workflow instead of Deduction Workflow
 */

using System;
using System.Activities;
using System.Dynamic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;


namespace JTL.Tax1040.BusinessLogic
{
    public class DeductionRepository : IDeductionRepository
    {

        #region Local variable declaration

        IPersonalInfoRepository personalInfoRepository;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="W2Repository"/> class.
        /// </summary>
        public DeductionRepository()
        {
            personalInfoRepository = new PersonalInfoRepository();
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
