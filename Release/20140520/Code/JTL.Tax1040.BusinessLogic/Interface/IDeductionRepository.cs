/*
Copyright   : Copyright Jeevan Technologies
File Name   : IDeductionRepository.cs 
Description : Deduction
Author      : Sathish
Created Date : 21Apr2014

 * Modification History:
 */
namespace JTL.Tax1040.BusinessLogic
{
    public interface IDeductionRepository
    {

        /// <summary>
        /// Get Person First Name or Nick Name and Total Worksheet Standard Deduction By User Id and User Data Id
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns>Return Person First Name or Nick Name and Deduction Work Sheet Field 7</returns>
        dynamic GetDeductionSummary(long userId, long userDataId);
    }
}
