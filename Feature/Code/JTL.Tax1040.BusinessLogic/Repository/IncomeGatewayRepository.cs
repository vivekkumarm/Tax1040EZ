/*
Copyright   : Copyright Jeevan Technologies
File Name   : IncomeGatewayRepository.cs 
Description : Business Logic for Income Gateway
Author      : Saravanan N.
Created Date : 16th April, 2014.

 * Modification History:
-------------------------
 * 28Apr2014 Sathish chnaged PersistIncomeGateway method to return user data id
 * 29May2014 Ashok Kumar changed return type from Tuple to IncomeDTO for PersistIncomeGateway and retrival of total Count for all Income Section.
 * 02 Sep 2014 Bhavani Audit functionality Implementation.
 */
using System;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Contains IncomeGateway related methods.
    /// </summary>
    public class IncomeGatewayRepository : IIncomeGatewayRepository
    {
        #region Get and Persist Methods
        /// <summary>
        /// Get the checkboxes checkced status in IncomeGateway page and NickName.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        public IncomeDTO GetIncomeGatewayData(long userId, long userDataId)
        {
            //bool hasW2 = false, hasInterestIncome = false, hasUnemployment = false, hasOtherIncome = false, showInterestIncomeChkListPage = false;
            //string nickName = string.Empty;

            IncomeDTO incomeDTO = new IncomeDTO();

            //Get TaxObject.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

            if (taxObject != null)
            {
                //Get Nick Name.
                if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                    taxObject.PersonalDetails.PrimaryTaxPayer.Person != null && taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName != null &&
                    taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName != string.Empty)
                {
                    incomeDTO.NickName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName;
                }
                //Yogalakshmi - 2nd June 2014 - To bind the Firstname if Nickname is null.
                else if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                    taxObject.PersonalDetails.PrimaryTaxPayer.Person != null && taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName != null &&
                    taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName != string.Empty)
                {
                    incomeDTO.NickName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName;
                }

                //Get IncomeGateway checkbox status.
                if (taxObject.Income != null)
                {
                    incomeDTO.HasW2Wages = taxObject.Income.HasW2Wages;
                    incomeDTO.HasInterestIncome = taxObject.Income.HasInterestIncome;
                    incomeDTO.HasUnemploymentCompensation = taxObject.Income.HasUnemploymentCompensation;
                    incomeDTO.HasOtherIncome = taxObject.Income.HasOtherIncome;

                    //Saravanan N - 27th May, 2014 - It will decide whether IncomeGateway > InterestIncome link click functionality.
                    var form1099INTKnt = taxObject.Income.Form1099INT != null ? taxObject.Income.Form1099INT.Count : 0;
                    var form1099OIDKnt = taxObject.Income.Form1099OID != null ? taxObject.Income.Form1099OID.Count : 0;

                    //if (form1099INTKnt > 0 || form1099OIDKnt > 0)
                    //{
                    //    incomeDTO.ShowInterestIncomeChkListPage = false;
                    //}
                    //else
                    //{
                    //    incomeDTO.ShowInterestIncomeChkListPage = true;
                    //}

                    //Saravanan N - 6th Aug, 2014 - This property used to decide whether Interest Income Checklist or Interest Income Summary page.
                    incomeDTO.showInterestIncomeChecklist = ((form1099INTKnt > 0 || form1099OIDKnt > 0 || (taxObject.F1040EZEligibility != null && 
                        taxObject.F1040EZEligibility.InterestIncomeEligibility != null)) ? false : true);

                    incomeDTO.W2WagesCount = taxObject.Income.W2Wages != null ? taxObject.Income.W2Wages.Count : 0;
                    //Saravanan N - 6th Aug, 2014 - These two properties used to decide whether Interest Income Checklist or Interest Income Summary page.
                    //incomeDTO.Form1099INTCount = taxObject.Income.Form1099INT != null ? taxObject.Income.Form1099INT.Count : 0;
                    //incomeDTO.Form1099OIDCount = taxObject.Income.Form1099OID != null ? taxObject.Income.Form1099OID.Count : 0;
                    incomeDTO.Form1099GCount = taxObject.Income.Form1099G != null ? 1 : 0;
                    incomeDTO.OtherIncomeCount = taxObject.Income.OtherIncome != null ? 1 : 0;
                }
            }

            //02-Sep-2014 Bhavani Audit functionality implementation
            string description = "Get Income Gateway data, ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, userDataId, description, this.GetType().Name, Constants.Tab_INCOME, Constants.TOPIC_INCOME_GATEWAY);

            return incomeDTO;
            //return new Tuple<bool, bool, bool, bool, string, bool>(hasW2, hasInterestIncome, hasUnemployment, hasOtherIncome, 
            //nickName, showInterestIncomeChkListPage);
        }

        /// <summary>
        /// Persist Income Gateway CheckBox selected status into TaxObject.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="incomeGatewayCheckBoxStatus"></param>
        /// <returns>The User Data ID</returns>
        public long PersistIncomeGateway(long userId, long userDataId, Tuple<bool, bool, bool, bool> incomeGatewayCheckBoxStatus)
        {
            //Get TaxObject.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

            if (taxObject == null)
            {
                taxObject = new BusinessObject.Tax1040();
                taxObject.Income = new Income();
            }

            if (taxObject.Income == null)
            {
                taxObject.Income = new Income();
            }

            //Store the IncomeGateway check box values into Tax Object.
            taxObject.Income.HasW2Wages = incomeGatewayCheckBoxStatus.Item1;
            taxObject.Income.HasInterestIncome = incomeGatewayCheckBoxStatus.Item2;
            taxObject.Income.HasUnemploymentCompensation = incomeGatewayCheckBoxStatus.Item3;
            taxObject.Income.HasOtherIncome = incomeGatewayCheckBoxStatus.Item4;

            //02-Sep-2014 Bhavani Audit functionality implementation
            string description = "Persis Income Gateway, ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, userDataId, description, this.GetType().Name, Constants.Tab_INCOME, Constants.TOPIC_INCOME_GATEWAY);
            
            //Persist TaxObject.
            long id = Utilities.PersistTaxObject(userId, userDataId, taxObject);
            return id;
        }
        #endregion
    }
}
