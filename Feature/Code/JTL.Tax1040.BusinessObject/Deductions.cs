/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Deductions.cs 
    Description     :   Business object for Address 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 */

namespace JTL.Tax1040.BusinessObject
{
    public class Deductions
    {
        public bool? HasItemizedDeductions { get; set; }

        public bool? HasAGIDeductions { get; set; }

    }

}

