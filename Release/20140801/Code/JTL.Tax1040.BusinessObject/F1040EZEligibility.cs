/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   F1040EZEligibility.cs 
    Description     :   Business objects for F1040EZEligibility Check 
    Author          :   Ashok Kumar 
    Created Date    :   04 April 2014

    Modification History:
    ---------------------
 */

namespace JTL.Tax1040.BusinessObject
{
    public class F1040EZEligibility
    {
         public InterestIncomeEligibility InterestIncomeEligibility { get; set; }

         public CommonEligibility CommonEligibility { get; set; }
    }
}
