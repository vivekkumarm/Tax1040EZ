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
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    public class W2EmployerCode
    {
        //Yogalakshmi - 27th August 2014 - Made Employer Code nullable
        public EmployerCode? EmployerCode { get; set; }

        //24Jun2014-Vincent-Added a null check for Amount
        public double? Amount { get; set; }

    }
}

