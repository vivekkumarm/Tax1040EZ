/*
Copyright   : Copyright Jeevan Technologies
File Name   : W2LocalTaxInfo.cs 
Description : Bo for W2LocalTaxInfo. 
Author      : 
Created Date : 17 Mar 2014

 *  Modification History:
----------------------------
* 16Apr2014 Bala Modified StateCode type as long.
* 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JTL.Tax1040.BusinessObject
{
    public class W2LocalTaxInfo
    {
        public string LocalityName { get; set; }

        public long StateCode { get; set; }

        public double? LocalWagesAmount { get; set; }

        public double? LocalTaxWithholdingAmount { get; set; }

    }
}

