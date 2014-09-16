/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   StateDTO.cs 
    Description     :   Business object for state related information. 
    Author          :   Sathish N.
    Created Date    :   31 July, 2014

    Modification History:
    ---------------------
 */
namespace JTL.Tax1040.BusinessObject
{
   public class StateDTO
    {
        #region Properties
        public long UserId { get; set; }
        public long UserDataId { get; set; }
        public long StateId { get; set; } //31Jul2014 Sathish added the property for efile state selection
        public string TaxData { get; set; }
        public string HistoryData { get; set; }
        #endregion
    }
}
