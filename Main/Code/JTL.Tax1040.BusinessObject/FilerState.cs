/*
Copyright       : Copyright Jeevan Technologies
File Name       : TaxableState.cs
Description     : Business object for state. 
Author          : Rajadurai.S
Created Date    : 08 May 2014
 
Modification History:
---------------------
// 23Jul2014 Sathish changed class name from FilingState to FilerState
 */

using JTL.Tax1040.Core.Object;
using System.ComponentModel;

namespace JTL.Tax1040.BusinessObject
{
    public class FilerState
    {
       // public long StateId { get; set; }

       // public string StateName { get; set; }

        public State State { get; set; }  //10Jul2014 Sathish removed state id and state ane refered state BO

        public string ResidentType { get; set; }
    }
}
