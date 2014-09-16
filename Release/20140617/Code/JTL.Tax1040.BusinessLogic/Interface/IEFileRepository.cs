

/*
Copyright   : Copyright Jeevan Technologies
File Name   : IEFileRepository.cs 
Description : Interface EFile Repository 
Author      : Sathish 
Created Date : 13May2014

 * Modification History:
------------------------
 */


using JTL.Tax1040.BusinessObject;
namespace JTL.Tax1040.BusinessLogic
{
    public interface IEFileRepository
    {
        /// <summary>
        /// Get the Person Detials
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns>Tax Payer Name, Personal Details and IRSTransmission</returns>
        System.Tuple<string, PersonalDetails, IRSTransmission> GetPersonAndIRSTransmission(long userId, long userDataId);

        IRSTransmission GetIRSTranmission(long userId, long userDataId);
    }
}
