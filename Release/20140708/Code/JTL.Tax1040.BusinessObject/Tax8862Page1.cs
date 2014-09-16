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
 * 27Jun2014 Bala modified the double type to int type.
 */

namespace JTL.Tax1040.BusinessObject
{
    public class Tax8862Page1
    {
        public int YearOfFiling { get; set; }

        public bool HasReportedIncorrectIncome { get; set; }

        public bool HasClaimedAsDependent { get; set; }

        public bool HasClaimedAsQualifyingChild { get; set; }

        public int DaysTaxPayerLivedInUS { get; set; }

        public int DaysSpouseLivedInUS { get; set; }
    }
}

