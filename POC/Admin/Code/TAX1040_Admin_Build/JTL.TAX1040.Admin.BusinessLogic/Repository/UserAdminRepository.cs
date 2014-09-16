//23 July 2014 Praveen T Added Repository for Admin User

using System;
using System.Security.Cryptography;
using System.Web.Security;
using JTL.TAX1040.Admin.BusinessObject;
using JTL.TAX1040.Admin.DataAccess;
using System.Collections.Generic;

namespace JTL.TAX1040.Admin.BusinessLogic
{
    public class UserAdminRepository
    {
        #region Declaration
        private readonly UserAdminDataService userAdminDataService;
        #endregion

        #region Constructor
        public UserAdminRepository()
        {
            userAdminDataService = new UserAdminDataService();
        }
        #endregion

        #region Persist User Admin

        /// <summary>
        /// Persists the user admin.
        /// </summary>
        /// <param name="userAdmin">The user admin.</param>
        /// <returns></returns>
        public long PersistUserAdmin(UserAdmin userAdmin)
        {
            var result = 0L;
            try
            {
                var salt = CreateSalt(7);
                userAdmin.Salt = salt;

                var encryptedPassword = EncryptMessage(userAdmin.Password, salt);
                userAdmin.Password = encryptedPassword;
                result = userAdminDataService.PersistUserAdmin(userAdmin);
         
            }
            catch (Exception ex)
            {
            }
            return result;
        }
        #endregion

        #region Get All User Admin
        /// <summary>
        /// Gets all user admin.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserAdmin> GetAllUserAdmin()
        {
            return userAdminDataService.GetAllUserAdmin();
        }
        #endregion

        #region Get All Admin Roles

        /// <summary>
        /// Gets all admin roles list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserRole> GetAllAdminRoles()
        {
            return userAdminDataService.GetAdminRoles();
        }
        #endregion

        #region Get  User Admin by user admin Id

        /// <summary>
        /// Gets the user admin by user admin id.
        /// </summary>
        /// <param name="userAdminId">The user admin id.</param>
        /// <returns></returns>
        public UserAdmin GetUserAdminByUserAdminId(long userAdminId)
        {
            return userAdminDataService.GetUserAdminByUserAdminId(userAdminId);
        }
        #endregion

        #region Update User Admin

        /// <summary>
        /// Updates the user admin.
        /// </summary>
        /// <param name="userAdmin">The user admin.</param>
        public void UpdateUserAdmin(UserAdmin userAdmin)
        {
            userAdminDataService.UpdateUserAdmin(userAdmin);
        }
        #endregion

        #region Reset Password 
     
        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="userAdmin">The user admin.</param>
        /// <returns></returns>
        public int ResetPassword(UserAdmin userAdmin)
        {
            var encryptedPassword = EncryptMessage(userAdmin.Password, userAdmin.Salt);
            userAdmin.NewPassword = encryptedPassword;
            return userAdminDataService.ResetPasswordUser(userAdmin);
        }

       

        #endregion

        #region User Sign-In
        /// <summary>
        /// Signs the in user.
        /// </summary>
        /// <param name="userAdmin">The user admin.</param>
        /// <returns></returns>
        public UserAdmin SignInUser(UserAdmin userAdmin)
        {
            UserAdmin useradminDetails = null;
            try
            {
                useradminDetails = userAdminDataService.SignInUser(userAdmin.UserName);
                if (useradminDetails.UserAdminId > 0)
                    {
                        var salt = useradminDetails.Salt;
                        var encryptedPassword = EncryptMessage(userAdmin.Password, salt);
                        if (encryptedPassword != useradminDetails.Password)
                        {
                            return null;
                        }
                    }
               
            }
            catch (Exception ex)
            {
                //ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:SignInUser", ex);
            }

            return useradminDetails;
        }

        #endregion

        #region Delete User Admin

        /// <summary>
        /// Deletes the user admin.
        /// </summary>
        /// <param name="useradmin">The useradmin.</param>
        public void DeleteUserAdmin(UserAdmin useradmin)
        {
            userAdminDataService.DeleteUserAdmin(useradmin);
        }
        #endregion

        #region Helper Methords
        private string CreateSalt(int salt)
        {
            var rngCryptoService = new RNGCryptoServiceProvider();
            var buff = new byte[7];
            rngCryptoService.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        private string EncryptMessage(string message, string salt = "")
        {
            var saltMessage = String.IsNullOrEmpty(salt) ? message : String.Concat(message, salt);
            var encryptedMessage = FormsAuthentication.HashPasswordForStoringInConfigFile(saltMessage, "SHA1");
            return encryptedMessage;
        }

        #endregion

    }
}
