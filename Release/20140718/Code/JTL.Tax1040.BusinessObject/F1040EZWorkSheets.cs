/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   F1040EZWorkSheets.cs 
    Description     :   Business object for Form 1040EZ worksheets 
    Author          :   Ashok kumar 
    Created Date    :   22 April 2014 
 
  Modification History:
  ---------------------
 * 16thJuly2014 Ashok Kumar Added new properties to check whether to display Worksheet or not 
 */


namespace JTL.Tax1040.BusinessObject
{
    public class F1040EZWorkSheets
    {
        public DeductionsWorkSheet DeductionsWorkSheet { get; set; }

        public SSBWorkSheet SSBWorkSheet { get; set; }

        public EICWorkSheet EICWorkSheet { get; set; }

        public bool? IsDeductionBWorkSheetRequired { get; set; }

        public bool? IsSSBWorkSheetRequired { get; set; }

        public bool? IsEICWorkSheetRequired { get; set; }


    }
}
