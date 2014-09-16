/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   EICWorkSheet.cs 
    Description     :   Business object for Form 1040EZ - EIC worksheet 
    Author          :   Ashok kumar 
    Created Date    :   22 April 2014 
 
  Modification History:
  ---------------------

 */

namespace JTL.Tax1040.BusinessObject
{
    public class EICWorkSheet
    {
        public double Line1Amount { get; set; }

        public double Line2Amount { get; set; }

        public double Line3Amount { get; set; }

        //public double Line4Amount { get; set; }

        public bool IsLine4AmountsSame { get; set; }

        public double Line5Amount { get; set; }

        public bool IsLine5Blank { get; set; }

        public double Line6Amount { get; set; }

    }
}
