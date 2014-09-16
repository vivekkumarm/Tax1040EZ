/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Credits.cs 
    Description     :   Business object for Address 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 */

namespace JTL.Tax1040.BusinessObject
{
    public class Credits
    {
        public EIC EIC { get; set; }

        public bool? HasCreditsToClaim { get; set; }        

        public bool? HasEarnedIncomeCredits { get; set; }

        public bool? HasEstimatedTaxPayments { get; set; }

    }

}

