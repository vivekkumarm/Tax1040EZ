/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   BillingAddress.cs 
    Description     :   Business object for Billing Address. 
    Author          :   Ashok Kumar 
    Created Date    :   07 May 2014

    Modification History:
    ---------------------
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.BusinessObject
{
    public class BillingAddress
    {
        public string StreetAddress { get; set; }

        public string ApartmentNumber { get; set; }

        public string City { get; set; }

        public State State { get; set; }

        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        public string StateOrProvince { get; set; }

        public Country Country { get; set; }

        public bool IsForeignAddress { get; set; }
    }
}
