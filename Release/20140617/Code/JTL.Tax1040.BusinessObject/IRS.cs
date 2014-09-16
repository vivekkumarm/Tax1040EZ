﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   IRS.cs 
    Description     :   Business object for IRS. 
    Author          :    
    Created Date    :   

    Modification History:
    ---------------------
  *  7  May, 2014 - Ashok Kumar- Added new properties for IRS Payment options
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    public class IRS
    {
        public BankDetails BankDetails { get; set; }

        public double Amount { get; set; }

        public IRSPaymentOption IRSPaymentOption { get; set; }

        public DateTime PaymentDate { get; set; }

        public bool IsIRSPaymentOptionAgreed { get; set; }

    }

}
