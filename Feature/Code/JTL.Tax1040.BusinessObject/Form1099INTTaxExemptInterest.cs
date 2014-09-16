/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Form1099INTTaxExemptInterest.cs 
    Description     :   Business object for TaxExemptInterest 
    Author          :   Yogalakshmi Rangan 
    Created Date    :   21 August 2014

    Modification History:
    ---------------------
 * 
 */
namespace JTL.Tax1040.BusinessObject
{
    public class Form1099INTTaxExemptInterest
    {
        public State TaxExemptInterestState { get; set; } //10Jul2014 Sathish state id to state BO

        public double? StateExemptInterest { get; set; }
    }
}
