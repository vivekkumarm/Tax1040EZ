/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Spouse.cs 
    Description     :   Business object for Spouse. 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 */

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Contains Spouse related properties.
    /// </summary>
    public class Spouse
    {
        public Person Person { get; set; }
        public bool? HasLivedInAnotherState { get; set; }
        public long LivedInAnotherStateId { get; set; }
    }
}

