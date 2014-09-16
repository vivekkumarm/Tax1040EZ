/*
Copyright   : Copyright Jeevan Technologies
File Name   : DeductionRepository.cs 
Description : Deduction
Author      : Sathish
Created Date : 21Apr2014

 * Modification History:
 */

using System;
using System.Activities;
using System.Dynamic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using Tax1040WorkFlow.WorkFlow;


namespace JTL.Tax1040.BusinessLogic
{
    public class DeductionRepository : IDeductionRepository
    {

        #region Get

        public dynamic GetDeductionSummary(UserDTO userDTO)
        {
            try
            {
                BusinessObject.Tax1040 taxObject;
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                dynamic deductionSummaryData = new ExpandoObject();
                deductionSummaryData.PrimaryTaxPayerName = Constants.TAXPAYER_DEFAULT_DISPAY_NAME ;

                if (taxObject != null)
                {
                    PersonalDetails personalDetails = taxObject.PersonalDetails;

                    if (personalDetails != null)
                {
                        if (personalDetails.PrimaryTaxPayer != null && personalDetails.PrimaryTaxPayer.Person != null)
                    {
                            if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.NickName))
                                deductionSummaryData.PrimaryTaxPayerName = personalDetails.PrimaryTaxPayer.Person.NickName;
                            else if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.FirstName))
                                deductionSummaryData.PrimaryTaxPayerName = personalDetails.PrimaryTaxPayer.Person.FirstName;
                    }
                }
                }

                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
                var output =
                    Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                        WorkflowInvoker.Invoke(new F1040EZStandardDeduction(), input));

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
