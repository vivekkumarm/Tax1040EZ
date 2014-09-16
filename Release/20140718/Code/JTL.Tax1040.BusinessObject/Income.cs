/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Income.cs 
    Description     :   Business object for Address 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 * Saravanan N. - 16th April, 2014 - Below fields added to handle chekced items in IncomeGateway page.
 * 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.   
 * 29May2014 Ashok Kumar Spell check of property Name for HasOtherIncome
 * 16thJuly2014 Ashok Kumar Added new property to check whether to display Form8862 or not 
 */

using System.Collections.Generic;

namespace JTL.Tax1040.BusinessObject
{
    public class Income
    {
        public List<W2> W2Wages { get; set; }

        public double? WithholdingTaxAmount { get; set; }

        public List<Form1099INT> Form1099INT { get; set; }

        public List<Form1099OID> Form1099OID { get; set; }

        public List<Form1099G> Form1099G { get; set; }

        public OtherIncome OtherIncome { get; set; }

        public bool? HasIncomeFromOtherSources { get; set; }

        //Bala. - 27th June, 2014 - List Removed.
        public Form8862 Form8862 { get; set; }

        //Ashok Kumar - 16th July 2014 - Added for displaying Form8862
        public bool? IsForm8862Required {get; set;}

        //Saravanan N. - 16th April, 2014 - Below four BOOLEAN fields added to handle chekced items in IncomeGateway page.
        public bool HasW2Wages { get; set; }

        public bool HasInterestIncome { get; set; }

        public bool HasUnemploymentCompensation { get; set; }

        public bool HasOtherIncome { get; set; }
    }

}

