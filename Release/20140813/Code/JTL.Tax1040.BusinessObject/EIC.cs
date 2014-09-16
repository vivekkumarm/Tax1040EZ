﻿/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   EIC.cs 
    Description     :   Business object for Address 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 * 23Apr2014 Ashok Kumar commented the EIC worksheet properties and moved to EICWorksheet.cs
 * 30Jul2014 Sathish set nullable object for the following property NumberOfDaysTaxPayerLivedInUS,NumberOfDaysSpouseLivedInUS,TaxableScholarshipCredit,PensionAnnuity,PenalInstitutionInmateWages
 * HasTaxableScholarshipCredits and HasPensionAnnuity Busniness Objects need to Removed and not needed as per Credit Spec(Spec Version V1.4)
 * 11August2014 Ashok Kumar - Removed unwanted Bool Varaibales of EIC
 */

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Contains properties required for Earned Income Credit
    /// </summary>
    public class EIC
    {

        public bool? HasValidSSN { get; set; }

        public bool? IsInUSMorethanHalfYear { get; set; }

        public bool? HasClaimedAsQualifyingChild { get; set; }
        
        public bool? IsProhibitedFromClaimingEIC { get; set; }

        public bool? HasReceivedIRSNoticeOnFiling8862 { get; set; }


        public bool? HasEICForPriorYearDisallowance { get; set; }

        public bool? HasIncorrectlyReportedEarnedIncome { get; set; }

        public int? NumberOfDaysTaxPayerLivedInUS { get; set; }

        public int? NumberOfDaysSpouseLivedInUS { get; set; }

        //This BO need to Removed and not needed as per Credit Spec(Spec Version V1.4) to do
        //public bool? HasTaxableScholarshipCredits { get; set; }

        public double? TaxableScholarshipCredit { get; set; }

        //This BO need to Removed and not needed as per Credit Spec(Spec Version V1.4) to do
        //public bool? HasPensionAnnuity { get; set; }

        public double? PensionAnnuity { get; set; }

        public bool? HasPenalInstitutionInmateWages { get; set; }

        public double? PenalInstitutionInmateWages { get; set; }

        //------------------------------------------

        //TODO: As of now, the following properties usage not yet identified. - Saravanan N.

        public bool? IsNonResidentAlien     
        {
            get;
            set;
        }
        ////Need to remove - Added to EICWorksheet.Cs
        //public double EICWorksheetEarnedIncome
        //{
        //    get;
        //    set;
        //}

        ////Need to remove - Added to EICWorksheet.Cs
        //public double EICWorkSheetLine1Credit
        //{
        //    get;
        //    set;
        //}
        ////Need to remove - Added to EICWorksheet.Cs
        //public double EICWorkSheetLine5Credit
        //{
        //    get;
        //    set;
        //}
        ////Need to remove - Added to EICWorksheet.Cs
        //public double EICWorksheetEarnedIncomeCredit
        //{
        //    get;
        //    set;
        //}

        public bool? HasReceivedIRSNoticeOnEICNotEligible
        {
            get;
            set;
        }
    }
}
