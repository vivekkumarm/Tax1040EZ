/*
Copyright   : Copyright Jeevan Technologies
File Name   : W2StateLocalTaxInfo.cs 
Description : BO for W2StateLocalTaxInfo  
Author      : 
Created Date : 

 * Modification History:
-------------------------
* 16Apr2014 Bala Modified StateId type as long. 
* 22 Apr 14-Vincent- Moved w2LocalTaxInfo List to W2StateLocalTaxInfo BO.
* 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JTL.Tax1040.BusinessObject
{
    public class W2StateLocalTaxInfo
    {
        public State State { get; set; }  //10Jul2014 Sathish changed state id to State BO
        //public string StateCode { get; set; }
        public double? StateWagesAmount { get; set; }
        public double? StateTaxWithholdingAmount { get; set; }
        public List<W2LocalTaxInfo> W2LocalTaxInfo { get; set; }

    }

}

