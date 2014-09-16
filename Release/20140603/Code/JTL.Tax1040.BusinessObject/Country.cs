/*
Copyright       : Copyright Jeevan Technologies
File Name       : Country.cs
Description     : Business object for country.
Author          : vivekkumar
Created Date    : 14 Mar 2014
 
Modification History:
---------------------
 
 */

namespace JTL.Tax1040.BusinessObject
{
    public class Country
    {
        public long CountryId { get; set; }

        public string CountryCode { get; set; }

        public string CountryName { get; set; }
    }
}
