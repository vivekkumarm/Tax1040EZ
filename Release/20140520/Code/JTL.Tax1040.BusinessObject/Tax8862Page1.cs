/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Tax8862Page1.cs 
    Description     :   Business object for Person. 
    Author          :   Vivek 
    Created Date    :   

    Modification History:
    ---------------------
 * 26.02.2014 Vincent changed the variable type fpr Days lived in US for both Taxpayer and Spouse.
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 */

namespace JTL.Tax1040.BusinessObject
{
    public class Tax8862Page1
    {
        public int YearOfFiling { get; set; }

        public bool? HasIncorrectIncomeReported { get; set; }

        public bool? HasClaimedAsDependent { get; set; }

        public bool? HasQualifyingChild { get; set; }

        public bool? IsChild1Child2SameAddress { get; set; }

        public bool? IsChild1Child3SameAddress { get; set; }

        public bool? IsChild2Child3SameAddress { get; set; }

        public bool? IsPersonLivedWithChild { get; set; }

        public bool? IsChild1Child2SamePersonLived { get; set; }

        public bool? IsChild1Child3SamePersonLived { get; set; }

        public bool? IsChild2Child3SamePersonLived { get; set; }

        public double DaysPrimaryTaxPayerLivedInUS { get; set; }

        public double DaysSpouseLivedInUS { get; set; }

        public QualifyingChild QualifyingChild { get; set; }

    }
}

