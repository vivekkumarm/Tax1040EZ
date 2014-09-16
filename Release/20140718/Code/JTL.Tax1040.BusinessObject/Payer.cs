/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Payer.cs 
    Description     :   Business object for Payer 
    Author          :   
    Created Date    :   
    Remarks         :   This BO already exists. It is existing BO, started this by refactoring properties.

 * Modification History:
    ---------------------
 * 22Apr2014 Bala, changed PayerAddress property name to Address.
 */

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Contains details common for all forms in "Interest" section.
    /// </summary>
    public class Payer
    {
        public string PayerIdentificationNumber { get; set; }
        public string PayerName { get; set; }
        public Address Address { get; set; }
    }
}

