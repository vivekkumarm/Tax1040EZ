/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   F1040EZ.cs 
    Description     :   Business object for Form 1040EZ 
    Author          :   Ashok kumar 
    Created Date    :   22 April 2014 
 
  Modification History:
  ---------------------

 */


namespace JTL.Tax1040.BusinessObject
{
    public class F1040EZ
    {
        public F1040EZWorkSheets F1040EZWorkSheets { get; set; }

        public F1040EZEligibility F1040EZEligibility { get; set; }
    }
}
