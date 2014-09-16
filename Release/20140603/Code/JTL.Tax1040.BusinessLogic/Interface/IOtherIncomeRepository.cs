/*
Copyright   : Copyright Jeevan Technologies
File Name   : IOtherIncomeRepository.cs 
Description : Other Income Repository Interface for Tax Return  
Author      : Vivek
Created Date : 7 Apr 2014

 * Modification History:
---------------------
 * Sathish 03May2014 change PersistOtherIncome to use Tax Return Data Bo
 * Saravanan N - 20th May, 2014 - Code refactored from its controller.

 */

using System.Collections.Generic;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.BusinessObject;

namespace JTL.Tax1040.BusinessLogic
{
    public interface IOtherIncomeRepository
    {
        long PersistOtherIncome(long userId, TaxReturnData taxReturnData);

        void DeleteAndPersistOtherIncome(long userId, long userDataId, OtherIncomeType otherIncomeType);

        //Saravanan N - 20th May, 2014 - Code refactored from its controller.
        System.Tuple<OtherIncome, FilingStatus> GetOtherIncome(UserDTO userDTO);
        //Saravanan N - 20th May, 2014 - Code refactored from its controller.
        System.Tuple<OtherIncome, IEnumerable<ErrorMessage>, string, string, string, string> GetOtherIncomeSummary(dynamic userInputData);
    }
}
