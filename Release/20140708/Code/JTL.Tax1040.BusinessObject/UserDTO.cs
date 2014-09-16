/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   UserDTO.cs 
    Description     :   Business object for User related Ids. 
    Author          :   Saravanan N.
    Created Date    :   05th May, 2014

    Modification History:
    ---------------------
Saravanan N - 7th May, 2014 - FormId Added.
 */

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Constains Id for the Current User.
    /// </summary>
    public class UserDTO
    {
        #region Properties
        public long UserId { get; set; }
        public long UserDataId { get; set; }
        public long FormId { get; set; }
        #endregion
    }

}

