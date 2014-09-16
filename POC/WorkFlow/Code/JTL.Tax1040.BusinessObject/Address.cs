/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Address.cs 
    Description     :   Business object for Address 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 */

using System;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Contains Address related properties.
    /// </summary>

    public class Address
    {
        #region Member variables

        #endregion

        #region Properties
        //TODO: Have to decide whether this field is needed ?
        public long AddressId { get; set; }

        public AddressType AddressType { get; set; }

        public State ResidenceState { get; set; }

        public bool? HasLivedInMoreThanOneState { get; set; }

        public bool? HasEarnedIncomeFromNonLivedState { get; set; }

        public long LivedInAnotherStateId { get; set; }

        public DateTime? LivedInAnotherStateFrom { get; set; }

        public DateTime? LivedInAnotherStateTo { get; set; }

        public long EarnedIncomeFromNonLivedStateId { get; set; }

        public PersonalAddress PersonalAddress { get; set; }

        public ForeignAddress ForeignAddress { get; set; }

        public CompanyAddress CompanyAddress { get; set; }

        public PayerAddress PayerAddress { get; set; }
        
        #endregion
    }
}

