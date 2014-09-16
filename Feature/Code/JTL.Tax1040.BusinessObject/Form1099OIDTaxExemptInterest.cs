/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Form1099OIDTaxExemptInterest.cs 
    Description     :   Business object for TaxExemptInterest 
    Author          :   Vincent
    Created Date    :   25 August 2014

    Modification History:
    ---------------------
 * 
 */

using System;
using System.Collections.Generic;

namespace JTL.Tax1040.BusinessObject
{
    public  class Form1099OIDTaxExemptInterest
    {
        public State TaxExemptInterestState { get; set; } 

        public double? StateExemptInterest { get; set; }
    }
}
