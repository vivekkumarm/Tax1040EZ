﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//Added property TEI for MeF Mapping and PDF binding by Ashok Kumar 15thMar2014
//21 Apr 14 Vincent, Added new Property WagesPrefix.
//------------------------------------------------------------------------------

/*
 * Modification History
 * 23May2014 Sathish added PenaltiesAndInterest property
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JTL.Tax1040.BusinessObject
{
    public class Tax1040EZPage1
    {
        public double TotalWages { get; set; }

        public double TaxableInterest { get; set; }

        public double UnemploymentCompensation { get; set; }

        public double AdjustedGrossIncome { get; set; }

        public double TaxableIncome { get; set; }

        public double FederalTaxWithholdingAmount { get; set; }

        public double EarnedIncomeCredit { get; set; }

        public double NonTaxableCombatPayElection { get; set; }

        public double FederalExtensionAmount { get; set; }

        public double TotalPaymentsAndCredits { get; set; }

        public double TaxAmount { get; set; }

        public double RefundAmount { get; set; }

        public double TaxOweAmount { get; set; }

        public double PenaltiesAndInterest { get; set; }

        public double StandardDeduction { get; set; }

        public double PersonalDeduction { get; set; }
        
        public double TEI { get; set; }

        public string WagesPrefix { get; set; }

       


    }
}

