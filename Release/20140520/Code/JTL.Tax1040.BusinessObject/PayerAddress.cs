/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   PayerAddress.cs 
    Description     :   Business object for PayerAddress 
    Author          :   Saravanan N. 
    Created Date    :   1st April, 2014

 * Modification History:
    ---------------------
 */

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Contains PayerAddress details used in Form 1099-G.
    /// </summary>
    public class PayerAddress
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public long StateId { get; set; }
        public string ZipCode { get; set; }
    }
}
