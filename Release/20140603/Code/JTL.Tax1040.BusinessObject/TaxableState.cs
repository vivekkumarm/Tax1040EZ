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
    public class TaxableState
    {
        public long StateId { get; set; }

        public string StateName { get; set; }

        public string ResidentType { get; set; }
    }
}
