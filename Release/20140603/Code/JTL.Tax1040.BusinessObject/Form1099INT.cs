/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Form1099INT.cs 
    Description     :   Business object for Address 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 * 31stMar2014 Ashok Kumar Added new property Form1099INTId
 * 1stApr2014 Ashok Kumar Added new properties for Interest Income (Form 1099 Int and Form 1099 OID)
 * 4thApr2014 Ashok Kumar Removed properties for Interest Income (Form 1099 Int and Form 1099 OID) and moved to new class 'InterestIncomeEligibility.cs'
 * 7thApr2014 Ashok Kumar Added 2 new properties for Interest Income
 * 17Mar2014 Bala modified the Boolean type to Boolean nullable type.
 * 21 Apr 14 Vincent, changed long to int for Form1099INTId.
 * 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.  
 */
using System;
using System.Collections.Generic;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    public class Form1099INT
    {
        public  int Form1099INTId { get; set; }

        public double? ForeignTaxPaid { get; set; }

        public double? EarlyWithdrawalPenalty { get; set; }

        public double? USBondsTreasury { get; set; }

        public double? FederalTaxWithHoldingAmount { get; set; }

        public double? InvestmentExpenses { get; set; }

        public long ForeignCountryId { get; set; }

        public double? TaxExemptInterest { get; set; }

        public double? TaxExemptAccuredInterest { get; set; }

        public double? SpecifiedPrivateActivityBond { get; set; }

        public string TaxExemptBondCUSIPNumber { get; set; }

        public double? BothFederalStateExemptInterest { get; set; }

        public bool? IsStateInformationAvailable { get; set; }

        public double? InterestReceivedAsNominee { get; set; }

        public DateTime AccuredInterestInpaymentDates { get; set; }

        public double? AmortizableBondPremium { get; set; }

        public double? InterestIncome { get; set; }

        public double? TaxableInterestAmount { get; set; }

        public double? WithholdingTaxAmount { get; set; }

        public string AccountNumber { get; set; }

        public Payer Payer { get; set; }

        public List<Form1099StateInformation> Form1099StateInfo { get; set; }

        public OwnerType Owner { get; set; }

        public FormType Form { get; set; }

        public int TaxExemptInterestStateId { get; set; }

        public double? StateExemptInterest { get; set; }

        //Saravanan N - 21st May, 2014 - Property added to store Recipient Name.
        public string RecipientName { get; set; }
    }

}

