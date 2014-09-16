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
 * Saravanan - 13th June 2014 - PersistOtherIncome parameter changed to dynamic type.
 */

using System.Collections.Generic;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.BusinessObject;

namespace JTL.Tax1040.BusinessLogic
{
    public interface IOtherIncomeRepository
    {
        System.Tuple<long, bool> PersistOtherIncome(dynamic taxReturn);

        void DeleteAndPersistOtherIncome(long userId, long userDataId, OtherIncomeType otherIncomeType);

        //Saravanan N - 20th May, 2014 - Code refactored from its controller.
        //vivek - 6-Aug-14 -Added the error message enumerable for the error message focus 
        System.Tuple<OtherIncome, FilingStatus,IEnumerable<ErrorMessage>> GetOtherIncome(UserDTO userDTO);
        //Saravanan N - 20th May, 2014 - Code refactored from its controller.
        System.Tuple<OtherIncome, IEnumerable<ErrorMessage>, string, string, string, string> GetOtherIncomeSummary(dynamic userInputData);
    }
}
