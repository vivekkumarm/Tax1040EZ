/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   PrimaryTaxPayer.cs 
    Description     :   Business object for PrimaryTaxPayer. 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 *  08Apr2014 Sathish Added filing status description used internally
 */

using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Contains PrimaryTaxPayer related properties.
    /// </summary>
    public class PrimaryTaxPayer
    {
        public Person Person { get; set; }
        public FilingStatus FilingStatus { get; set; }
        public string FilingStatusDescription { get; set; } // Used Internally

        
    }
}