/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   TaxesAndPenalties.cs 
    Description     :   Business object for Person. 
    Author          :   Vivek 
    Created Date    :   

    Modification History:
    ---------------------
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 * 28Apr2014 Ashok Kumar Added New Propeties
 */
using System;

namespace JTL.Tax1040.BusinessObject
{
    public class TaxesAndPenalties
    {
        public bool? HasOwedHouseholdEmploymentTax { get; set; }

        public bool? HasAlternativeMinimumTax { get; set; }

        public bool? HasAdditionalSocialSecurityOrMedicareTax { get; set; }

        public bool? HasFederalQuarterlyEstimatesPaid { get; set; }

        public bool? HasFiledForm4868{ get; set; }

        public bool? HasPaidFederalExtensionWithForm4868 { get; set; }

        public bool? IsFilingReturnAfterDueDate { get; set; }

        public double? FederalExtensionAmount { get; set; }

        public DateTime? FederalExtensionAmountPaidDate { get; set; }

        public DateTime? FilingDate { get; set; }

        public bool? HasToDepositTaxRefundsToBankAccount { get; set; }

        public BankDetails BankDetails { get; set; }

        public string InCareOf { get; set; }

        public string InCareOfPhoneNumber { get; set; }

        public bool? HasThirdPartyDesignee { get; set; }

        public ThirdPartyDesignee ThirdPartyDesignee { get; set; }

        public double? PenaltiesAndInterest { get; set; }
    }
}

