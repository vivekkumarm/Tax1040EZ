/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   F1040EZWorkSheets.cs 
    Description     :   Business object for Form 1040EZ worksheets 
    Author          :   Ashok kumar 
    Created Date    :   22 April 2014 
 
  Modification History:
  ---------------------

 */


namespace JTL.Tax1040.BusinessObject
{
    public class F1040EZWorkSheets
    {
        public DeductionsWorkSheet DeductionsWorkSheet { get; set; }

        public SSBWorkSheet SSBWorkSheet { get; set; }

        public EICWorkSheet EICWorkSheet { get; set; }
    }
}
