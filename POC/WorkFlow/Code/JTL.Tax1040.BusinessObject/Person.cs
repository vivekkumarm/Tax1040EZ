/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Person.cs 
    Description     :   Business object for Person. 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 * 15Apr2014 Sathish Set nullable for MiddleInitial
 * 17Apr2014 Ashok Kumar Added Name Control property
 */

using System;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Contains PrimaryTaxPayer related properties.
    /// </summary>
    public class Person
    {
        public long PersonId { get; set; }
        public string FirstName { get; set; }
        public char? MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Occupation { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SSN { get; set; }
        public bool? HasPrimaryFilerEcfContributed { get; set; }
        public bool? HasSpouseEcfContributed { get; set; }
        public bool? IsLegallyBlind { get; set; }
        public bool? IsDisabled { get; set; }
        public bool? HasClaimedAsDependent { get; set; }
        public bool? IsDied { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public bool? IsStudent { get; set; }
        public bool? IsFullTimeStudent { get; set; }
        //public bool? IsOtherInfoNone { get; set; }
        public PersonType PersonType { get; set; }
        public Address Address { get; set; }

        //TODO: Has following fields required ?
        public bool? IsPersonalRepresentative { get; set; }
        public bool? IsBankruptcyDebtor { get; set; }

        public string NameControl { get; set; }
    }
}
