/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   AlaskaPermanentFundDividend.cs 
    Description     :   Business object for Alaska Permanent Fund 
    Author          :   Vincent 
    Created Date    :   07 April 2014

    Modification History:
    ---------------------
  * 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.  
 */

namespace JTL.Tax1040.BusinessObject
{
    public class AlaskaPermanentFundDividend
    {
        public double? PrimaryTaxpayerAlaskaFundDividend { get; set; }
        public double? SpouseAlaskaFundDividend { get; set; }
    }
}
