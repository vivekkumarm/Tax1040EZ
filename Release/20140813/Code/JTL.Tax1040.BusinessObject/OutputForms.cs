﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JTL.Tax1040.BusinessObject
{
    public class OutputForms
    {
        public Tax1040EZPage1 Tax1040EZPage1 { get; set; }

        public Tax8879Page1 Tax8879Page1 { get; set; }

        public Tax8862Page1 Tax8862Page1 { get; set; }

        public Tax8879Page1 Tax8879 { get; set; }

        public string LateFilingPenalty { get; set; }
        public string LatePaymentPenalty { get; set; }
        public string Interest { get; set; }
        public string TaxOweAmountPDF { get; set; }

        public StateForms StateForms { get; set; }
    }

}

