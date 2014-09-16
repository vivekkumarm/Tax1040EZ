/*
Copyright       : Copyright Jeevan Technologies
File Name       : State.cs
Description     : Business object for state. 
Author          : vivekkumar
Created Date    : 14 Mar 2014
 
Modification History:
---------------------
 
 */

namespace JTL.Tax1040.BusinessObject
{
    // Get All State.
    public class State
    {
        public long StateId { get; set; }

        public string StateCode { get; set; }

        public string StateName { get; set; }

    }

}