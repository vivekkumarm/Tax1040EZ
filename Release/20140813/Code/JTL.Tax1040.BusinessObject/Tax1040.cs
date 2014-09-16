/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : Tax1040.cs
Description                 : Contains TaxData.
Author                      : Praveen
Created Date                : 
 
Modification History:
---------------------
 *  * 17Apr2014 Ashok kumar added new  Class object for Transmission BO.
 *  * 22Apr2014 Ashok kumar added new Class object for F1040EZ.
*/

using System.Collections.Generic;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    public class Tax1040
    {
        public long UserDataId { get; set; } //Saravanan N. - 26th Mar, 2014 - UserDataId property included.

        public PersonalDetails PersonalDetails { get; set; }

        public Income Income { get; set; }

        //TODO: Have to rename this BO to represent Static table information for State
        public State State { get; set; }

        public StateBO StateBO { get; set; }

        public Deductions Deductions { get; set; }

        public Credits Credits { get; set; }

        public TaxesAndPenalties TaxesAndPenalties { get; set; }

        public WrapUp WrapUp { get; set; }            

        public PaidTaxReturnPreparers PaidTaxReturnPreparers { get; set; }

        //Need to analyse further on Bank details object
        //23Jul2014 Sathish commented since IRS / IRS Transmission used in the federal filling
        //public Settlement Settlement { get; set; }

        //Ashok Kumar TODO Need to be Removed since moved it to the TaxesAndPenalties class
        public ThirdPartyDesignee ThirdPartyDesignee { get; set; }

        public OutputForms OutputForms { get; set; }

        public List<ErrorMessage> ErrorMessages { get; set; }

        // Ashok Kumar- TODO - Need to be removed - Added into F1040EZ class Object
        public F1040EZEligibility F1040EZEligibility { get; set; }

        //23Jul2014 Sathish commented since IRS Transmission is used in IRS BO
        //public IRSTransmission IRSTransmission { get; set; }

        public F1040EZ F1040EZ { get; set; }

        public Filing Filing { get; set; }

    }
}

