/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   CreditCard.cs 
    Description     :   Business object for Credit Card Details. 
    Author          :   Ashok Kumar 
    Created Date    :   07 May 2014

    Modification History:
    ---------------------
 * 
 */


namespace JTL.Tax1040.BusinessObject
{
    public class CreditCard
    {
        public string CreditCardNo { get; set; }
        public CreditCardType CreditCardType { get; set; }
        public string SecurityCodeNo { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
    }
}
