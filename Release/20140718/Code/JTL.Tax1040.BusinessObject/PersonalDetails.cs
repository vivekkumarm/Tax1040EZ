/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   PersonalDetails.cs 
    Description     :   Business object for Personal Details. 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 */
using System.Collections.Generic;

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Contains Personal Details related properties.
    /// </summary>
    public class PersonalDetails
    {
        #region Properties
        public List<Dependent> Dependents { get; set; }
        public PrimaryTaxPayer PrimaryTaxPayer { get; set; }
        public Spouse Spouse { get; set; }
        #endregion
    }
}

