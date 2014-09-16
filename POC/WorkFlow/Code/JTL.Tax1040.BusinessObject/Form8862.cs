/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Form8862.cs 
    Description     :   Business object for Address 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 */


namespace JTL.Tax1040.BusinessObject
{
    public class Form8862
    {
        //20.2.14 Vincent Added the new property and the class
         public double FormFilingTaxYear { get; set; }

         public bool? HasReportedIncorrectIncome { get; set; }
         
         public bool? HasClaimedAsQualifyingChild { get; set; }

         public bool? HasDaysLivedInUS { get; set; }

         public double DaysLivedInUS { get; set; }

         public double DaysSpouseLivedInUS { get; set; }

         public bool? HasDaysSpouseLivedInUS { get; set; }

         public bool? HasEICdisallowed { get; set; }
    }
}
