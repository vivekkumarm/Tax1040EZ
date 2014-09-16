/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   CompanyAddress.cs 
    Description     :   Business object for CompanyAddress 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 *  08Apr2014 Bala Added new property "StreetAddress".
 *  10Apr2014 Sathish Modified the ZipCode type to string
 */
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// This class contains CompanyAddress related properties.
    /// </summary>
    public class CompanyAddress
    {

        public long StateId { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        public long CountryId { get; set; }

        //TODO : Following field not exists in Address table. Need to discuss. By Saravanan
        public string District { get; set; }

        public string StreetAddress { get; set; }

    }
}

