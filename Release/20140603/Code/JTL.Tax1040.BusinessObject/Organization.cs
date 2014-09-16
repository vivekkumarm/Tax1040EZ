/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Organization.cs 
    Description     :   Business object for Address 
    Author          :    
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 * 08Apr2014 Bala commented the fields which are not in use.
 */

namespace JTL.Tax1040.BusinessObject
{
    public class Organization
    {
        public string Name { get; set; }

        public Address Address { get; set; }

        public string EIN { get; set; }

    }

}

