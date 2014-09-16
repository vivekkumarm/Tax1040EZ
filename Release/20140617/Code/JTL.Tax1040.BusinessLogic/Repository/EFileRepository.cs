

/*
Copyright   : Copyright Jeevan Technologies
File Name   : EFileRepository.cs 
Description : EFile Repository 
Author      : Sathish 
Created Date : 13May2014

 * Modification History:
------------------------
 */


using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;

namespace JTL.Tax1040.BusinessLogic
{
    public class EFileRepository : IEFileRepository
    {
        BusinessObject.Tax1040 taxObject;

        public System.Tuple<string, PersonalDetails,IRSTransmission> GetPersonAndIRSTransmission(long userId, long userDataId)
        {
            //Retreiving TaxObject from database
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

            IRSTransmission irsTransmission = new IRSTransmission();
            return new System.Tuple<string, PersonalDetails, IRSTransmission>(Utilities.GetTaxPayerFirstNameOrNickName(taxObject),
                                                            ((taxObject.PersonalDetails != null) ? taxObject.PersonalDetails : null),
                                                            irsTransmission);
        }


        public IRSTransmission GetIRSTranmission(long userId, long userDataId)
        {
            return new IRSTransmission();
        }
    }
}
