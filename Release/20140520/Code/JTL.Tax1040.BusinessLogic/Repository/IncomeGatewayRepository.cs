/*
Copyright   : Copyright Jeevan Technologies
File Name   : IncomeGatewayRepository.cs 
Description : Business Logic for Income Gateway
Author      : Saravanan N.
Created Date : 16th April, 2014.

 * Modification History:
-------------------------
 * 28Apr2014 Sathish chnaged PersistIncomeGateway method to return user data id
 */
using System;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;

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
        public Tuple<bool, bool, bool, bool, string> GetIncomeGatewayData(long userId, long userDataId)
        {
            bool hasW2 = false, hasInterestIncome = false, hasUnemployment = false, hasOtherIncome = false;
            string nickName = string.Empty;

            //Get TaxObject.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

            if (taxObject != null)
            {
                //Get Nick Name.
                if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null && taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                {
                    nickName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName;
                }

                //Get IncomeGateway checkbox status.
                if (taxObject.Income != null)
                {
                    hasW2 = taxObject.Income.HasW2Wages;
                    hasInterestIncome = taxObject.Income.HasInterestIncome;
                    hasUnemployment = taxObject.Income.HasUnemploymentCompensation;
                    hasOtherIncome = taxObject.Income.HasOherIncome;
                }
            }

            return new Tuple<bool, bool, bool, bool, string>(hasW2, hasInterestIncome, hasUnemployment, hasOtherIncome, nickName);
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
            taxObject.Income.HasOherIncome = incomeGatewayCheckBoxStatus.Item4;

            //Persist TaxObject.
           return  Utilities.PersistTaxObject(userId, userDataId, taxObject);
        }
        #endregion
    }
}
