/*
Copyright       : Copyright Jeevan Technologies
File Name       : StateBO.cs
Description     : Business object for state. 
Author          : Rajadurai.S
Created Date    : 08 May 2014
 
Modification History:
---------------------
 * 25Jul2014 Sathish Changed property name FilingState to Filer States
 
 */

using System.Collections.Generic;

namespace JTL.Tax1040.BusinessObject
{
    public class StateBO
    {
        public StateCA StateCA;
        public List<FilerState> FilerStates;
    }
}
