/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   F1040EZEligibility.cs 
    Description     :   Business objects for Interest Income Eligibility(Form 1099 Int and Form 1099 OID)  Check 
    Author          :   Ashok Kumar 
    Created Date    :   04 April 2014

    Modification History:
    ---------------------
 *  21  April, 2014 - Bala - Added two properties for 'Early withdrawal penalty' and 'Foreign tax credit'. 
 */


namespace JTL.Tax1040.BusinessObject
{
    public class InterestIncomeEligibility
    {
        //Added new bool Type objects for Interest Income Checklist (both for OID and INT)

        public bool? HasInterestReceivedAsNominee { get; set; }

        public bool? HasPreviousYearsUSBondsInterest { get; set; }

        public bool? HasOwnedForeignFinancialAccounts { get; set; }

        public bool? HasSellerFinancedMortageInterest { get; set; }

        public bool? IsReportingLesserOID { get; set; }

        public bool? IsExemptByAmortizableBond { get; set; }

        public bool? IsClaimingEEOrIUSBondsInterestAfter1989 { get; set; }
                
        public bool? HasNoneOfOptions { get; set; }

        public bool? HasEarlyWithdrawalPenalty { get; set; }

        public bool? HasForeignTaxCredit { get; set; }
    }
}
