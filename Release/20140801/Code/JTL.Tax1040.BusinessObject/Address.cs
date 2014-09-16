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
using System.Collections.Generic;

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

        //public State LivedInAnotherState { get; set; } // 09Jul2014 Sathsih  changed state id to state BO

        //public DateTime? LivedInAnotherStateFrom { get; set; }

        //public DateTime? LivedInAnotherStateTo { get; set; }

        //public State EarnedIncomeFromNonLivedState { get; set; } // 09Jul2014 Sathsih  changed state id to state BO

        //Bala, 28,Jul 2014 , State list added instead state based on the updated spec
        public List<State> EarnedIncomeFromNonLivedStates { get; set; }
        public List<State> LivedInAnotherStates { get; set; } 

        public PersonalAddress PersonalAddress { get; set; }

        public ForeignAddress ForeignAddress { get; set; }

        public CompanyAddress CompanyAddress { get; set; }

        public PayerAddress PayerAddress { get; set; }

        //Saravanan N - 27th June, 2014 - Payment Voucher (Form 1040V) PDF binding this field added.
        public string AddressForPdfOutput { get; set; }
        public string StreetAddressForPdfOutput { get; set; }
        public string ApartmentNumberForPdfOutput { get; set; }

        //Saravanan N - 27th June, 2014 - Payment Voucher (Form 1040V) PDF binding this field added.
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        #endregion
    }
}

