/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   W2EmployeeAddress.cs 
    Description     :   Business object for Employee Address. 
    Author          :   Bala 
    Created Date    :   08 Apr 2014

    Modification History:
    ---------------------
 */

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// This class contains EmployeeAddress related properties.
    /// </summary>
    public class W2EmployeeAddress 
    {
        #region Properties

        public State State { get; set; }  //10Jul2014 Sathish changed state id to State BO
      
        public string City { get; set; }
       
        public string ZipCode { get; set; }
       
        public string StreetAddress { get; set; }
        
        #endregion
    }
}
