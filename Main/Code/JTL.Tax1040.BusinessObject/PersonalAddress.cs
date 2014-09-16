/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   PersonalAddress.cs 
    Description     :   Business object for PersonalAddress 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 * 17Apr2014 Sathish Changed Zipcode data type to long
 */
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// This class Contains PersonalAddress related properties.
    /// </summary>
    public class PersonalAddress 
    {
        #region Private Member variables

        #endregion

        #region Properties

        public string StreetAddress { get; set; }

        public string ApartmentNumber { get; set; }

        public string City { get; set; }

        public State State { get; set; } // 09Jul2014 Sathsih  changed state id to state

        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        #endregion
    }
}

