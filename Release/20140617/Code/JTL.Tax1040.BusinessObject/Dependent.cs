/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Dependent.cs 
    Description     :   Business object for Dependent. 
    Author          :   Vivek 
    Created Date    :   07 March 2014

    Modification History:
    ---------------------
 */

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Contains Dependent related properties.
    /// </summary>
    public class Dependent
    {
        #region Properties
        public Person Person { get; set; }
        public int RelationshipId { get; set; }
        public long DependentId { get; set; }
        public int MonthsLivedInUS { get; set; }
        public int MonthsLivedOutsideUS { get; set; }
        #endregion
    }
}

