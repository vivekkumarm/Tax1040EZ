/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   OtherIncome.cs 
    Description     :   Business object for State or Local Tax Refund
    Author          :   Vivekkumar
    Created Date    :   09 April 2014 
 
  Modification History:
  ---------------------
 * 
 */

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Property for state or local refund
    /// </summary>
    public class StateOrLocalIncomeTaxRefunds
    {
        public bool? HasClaimedItemizedDeductionPriorYear { get; set; }

        public bool? HasStateAndLocalTaxDeductionPriorYear { get; set; }
    }
}
