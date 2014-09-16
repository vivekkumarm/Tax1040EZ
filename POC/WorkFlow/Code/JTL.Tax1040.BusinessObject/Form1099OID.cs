/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Form1099OID.cs 
    Description     :   Business object for Address 
    Author          :   Vivek 
    Created Date    :   

    Modification History:
    ---------------------
 * 21 Feb 2014 T.Praveen Included Property AcquisitionPremium
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 * 31Mar2014 Ashok Kumar Added new property Form1099OIDId to replace OIDId 
 * 8thApr2014 Vincent Added 2 new properties 
 * 10 Apr 14 Vincent Added new Properties Owner & Tax Exempt interest
 * 17 Apr 14 Changed int to long for Form1099OID.TaxExemptInterestStateId because state id is long
 * 21 Apr 14 Vincent, changed long to int for Form1099OIDId.
 * 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.  
 */

using JTL.Tax1040.Core.Object;
using System.Collections.Generic;

namespace JTL.Tax1040.BusinessObject
{
    public class Form1099OID
    {
        public int Form1099OIDId { get; set; }

        public Payer Payer { get; set; }

        public string AccountNumber { get; set; }

        public double? OriginalIssueDiscount { get; set; }

        public double? OtherPeriodicInterest { get; set; }

        public double? EarlyWithdrawalPenalty { get; set; }

        public double? IncomeMarketDiscount { get; set; }

        public double? ForeignTaxPaid { get; set; }

        public int ForeignCountryId { get; set; }

        public bool? IsMutualFundRegulatedInvestment { get; set; }

        public double? USTreasuryObligations { get; set; }

        public double? InvestmentExpenses { get; set; }

        public bool? IsStateInformationAvailable { get; set; }

        public double? InterestReceivedAsNominee { get; set; }

        public double? AdjustmentAmount { get; set; }

        public double? TaxableInterestAmount { get; set; }

        public double? FederalTaxWithHoldingAmount { get; set; }

        public string Description { get; set; }

        public List<Form1099StateInformation> Form1099StateInfo { get; set; }

        public double? AcquisitionPremium { get; set; }

        //1-4-14 property have been added by vivek

        public bool? HasToReportTaxExempt { get; set; }

        public bool? HasToReportAdjustment { get; set; }

        public long TaxExemptInterestStateId { get; set; }

        public double? StateExemptInterest { get; set; }

        //10 Apr 14 Vincent Added new Properties
        public OwnerType Owner { get; set; }

        public double? TaxExemptInterest { get; set; }
    }

}

