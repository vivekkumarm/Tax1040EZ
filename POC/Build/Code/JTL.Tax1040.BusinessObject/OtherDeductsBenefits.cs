/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   OtherDeductsBenefits.cs 
    Description     :   Business object for OtherDeductsBenefits 
    Author          :   ? 
    Created Date    :   ?

    Modification History:
    ---------------------
 * 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.   
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JTL.Tax1040.BusinessObject
{
    public class OtherDeductsBenefits
    {
        public double? Amount { get; set; }

        public string Description { get; set; }

        public long W2OtherId { get; set; }

    }
}

