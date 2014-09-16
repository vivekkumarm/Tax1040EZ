/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   CreditCardType.cs 
    Description     :   Business object for Credit Card Type . 
    Author          :   Ashok Kumar 
    Created Date    :   22 May 2014

    Modification History:
    ---------------------
 * 
 */

using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    public class CreditCardType
    {
        public CardType CardType { get; set; }
        public string CreditCardTypeName { get; set; }
    }
}
