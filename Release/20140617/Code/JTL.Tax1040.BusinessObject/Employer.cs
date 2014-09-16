/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Employer.cs 
    Description     :   Business object for Employer. 
    Author          :   Bala 
    Created Date    :   

    Modification History:
    ---------------------
 * 08Apr2014 Bala Added new fields("HouseholdEmployeeWages" and "TaxableScholarshipAmount").
  * 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.  
 */
using System;

namespace JTL.Tax1040.BusinessObject
{
    public class Employer
    {
        public Organization Organization { get; set; }
        public double? HouseholdEmployeeWages { get; set; }
        public double? TaxableScholarshipAmount { get; set; }
    }

}

