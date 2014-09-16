/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   RailroadRetirementIncome.cs
    Description     :   Business object for RRB
    Author          :   
    Created Date    :   
 
  Modification History:
  ---------------------
 *  * 10 Apr 2014 added RRB properities by vivek  
 *  vivek -7-July-14 null checked 
 */

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// RRB Business objects
    /// </summary>
    public class RailroadRetirementIncome
    {

        //TODO - To be removed - Ashok Kumar
        public double? NetBenefits { get; set; }

        //TODO - To be removed - Ashok Kumar
        public double? FederalTaxWithholdingAmount { get; set; }

        public double? TaxpayerNetBenefits { get; set; }

        public double? TaxPayerFederalTaxWithheld { get; set; }

        public double? SpouseNetBenefits { get; set; }

        public double? SpouseFederalTaxWithheld { get; set; }
    }
}
