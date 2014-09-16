/*
Copyright   : Copyright Jeevan Technologies
File Name   : IUnemploymentRepository.cs 
Description : Business Logic Interface for Unemployment
Author      : 
Created Date : 

 * Modification History:
------------------------
 * 21 Apr 14 Vincent, changed long to int for Form1099GId.
 * 23 Apr 14 Vincent, Remove the StateOrLocalIncomeTaxRefunds property.
 * 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.
 * 5th April, 2014 - Saravanan N - New property TaxPayerName added.
 */

using System.Collections.Generic;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Contains all the Form1099G - Unemployment related properties.
    /// </summary>
    public class Form1099G
    {
        public int Form1099GId { get; set; }
        public OwnerType OwnerType { get; set; }
        public Payer Payer { get; set; }
        public double? UnEmploymentCompensation { get; set; }
        public double? FederalTaxWithHoldingAmount { get; set; }
        public bool? IsCurrentYearUnemploymentRepaid { get; set; }
        public double? CurrentYearUnemploymentRepaid { get; set; }
        public bool? IsPriorYearUnEmploymentRepaid { get; set; }
        public double? PriorYearUnEmploymentRepaid { get; set; }
        public List<Form1099StateInformation> Form1099StateInfo { get; set; }
        public string TaxPayerName { get; set; }
    }
}
