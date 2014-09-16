/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   OtherIncome.cs 
    Description     :   Business object for OtherIncome 
    Author          :   Praveen T 
    Created Date    :   04 April 2014 
 
  Modification History:
  ---------------------
 * 7 Apr 2014 Vincent added the Alaska property method.
 * 9 Apr 2014 vivek added new class for state tax refund and SSB&RRB
 * 10 Apr 2014 added StateLocalTaxRefund, SSB and RRB properities by vivek  
 * 22 Apr 2014 Ashok kumar commented the List type Properties for SSB and RRB
 */

using System.Collections.Generic;

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Other Income business objects
    /// </summary>
    public class OtherIncome
    {
        //public List<SocialSecurityBenefits> SocialSecurityBenefits { get; set; }

        //public List<RailroadRetirementIncome> RailroadRetirementBenefits { get; set; }

        public bool HasSsbAndRrb { get; set; }

        public bool HasAlaskaPermanantFund { get; set; }

        public bool HasStateTaxRefund { get; set; }

        public bool HasClaimedItemizedDeductionPriorYear { get; set; }

        public bool HasStateAndLocalTaxDeductionPriorYear { get; set; }

        public AlaskaPermanentFundDividend AlaskaPermanentFundDividend { get; set; }

        public StateOrLocalIncomeTaxRefunds StateOrLocalIncomeTaxRefunds { get; set; }

        public SocialSecurityBenefits SSB { get; set; }

        public RailroadRetirementIncome RRB { get; set; }

    }
}
