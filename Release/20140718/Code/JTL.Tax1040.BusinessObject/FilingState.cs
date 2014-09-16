/*
Copyright       : Copyright Jeevan Technologies
File Name       : TaxableState.cs
Description     : Business object for state. 
Author          : Rajadurai.S
Created Date    : 08 May 2014
 
Modification History:
---------------------
 
 */

namespace JTL.Tax1040.BusinessObject
{
    public class FilingState
    {
       // public long StateId { get; set; }

       // public string StateName { get; set; }

        public State State { get; set; }  //10Jul2014 Sathish removed state id and state ane refered state BO

        public string ResidentType { get; set; }
    }
}
