/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   SocialSecurityBenefits.cs 
    Description     :   Business object for SSB. 
    Author          :   Vivek 
    Created Date    :   

    Modification History:
    ---------------------
 * 21 FEB 2014 T.Praveen Removed unused Fields.
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 * 10 Apr 2014 added the properity by vivek  
 * vivek -7-July-14 null checked 
 */

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// SSB Business objects
    /// </summary>
    public class SocialSecurityBenefits
    {
        //Need to be removed by Ashok Kumar
        //public double NetBenefits { get; set; }

        //Need to be removed by Ashok Kumar
        //public double FederalTaxWithholdingAmount { get; set; }

        public bool? HasTaxableSocialSecurityBenefits { get; set; }
       
        public double? TaxpayerNetBenefits { get; set; }

        public double? TaxPayerFederalTaxWithheld { get; set; }

        public double? SpouseNetBenefits { get; set; }

        public double? SpouseFederalTaxWithheld { get; set; }   
    }

}

