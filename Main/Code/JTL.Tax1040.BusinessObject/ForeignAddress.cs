/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   ForeignAddress.cs 
    Description     :   Business object for ForeignAddress 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 */
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// This class Contains ForeignAddress related properties.
    /// </summary>
    public class ForeignAddress 
    {
        public string StreetAddress { get; set; }

        public string ApartmentNumber { get; set; }

        public string City { get; set; }

        public string StateOrProvince { get; set; }

        public Country Country { get; set; } // 09Jul2014 Sathsih  changed country id to country BO

        public string PostalCode { get; set; }

        public string PhoneNumber { get; set; }
        
    }
}

