/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   BillingDetails.cs 
    Description     :   Business object for Billing Details. 
    Author          :   Ashok Kumar 
    Created Date    :   07 May 2014

    Modification History:
    ---------------------
 * 
 */
using System;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    public class BillingDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime PaymentDate { get; set; }

        public BillingAddress BillingAddress { get; set; }

        public CreditCard CreditCard { get; set; }

        public string Email { get; set; }

    }
}
