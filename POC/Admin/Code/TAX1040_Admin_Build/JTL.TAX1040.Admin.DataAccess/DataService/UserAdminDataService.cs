//23 July 2014 Praveen T Added Data Service for Admin User
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System;
using JTL.TAX1040.Admin.BusinessObject;

namespace JTL.TAX1040.Admin.DataAccess
{
    public class UserAdminDataService
    {
        #region Declaration

        private UserAdmin userAdmin;
        private UserAdminRole userAdminRole;
        private UserRole userRole;
        private readonly TAX1040UserAdminDB tax1040UserAdminDBContext;

        #endregion

        #region Constructor

        public UserAdminDataService()
        {
            tax1040UserAdminDBContext = new TAX1040UserAdminDB();
           // userAdmin = new UserAdmin();
        }

        #endregion

        #region Persist Admin User

        /// <summary>
        /// Persists the admin user.
        /// </summary>
        /// <param name="userAdmin">The admin user.</param>
        /// <returns></returns>
        public long PersistUserAdmin(UserAdmin userAdmin)
        {
            var userAdminRoles  = new user_admin_role();
            var useradmin = new user_admin()
                {
                    username = userAdmin.UserName,
                    email = userAdmin.Email,
                    password = userAdmin.Password,
                    salt = userAdmin.Salt
                    //is_active = userAdmin.IsActive
                };

            tax1040UserAdminDBContext.user_admin.Add(useradmin);

            //foreach (var roles in userAdmin.AdminRoles)
            //{
            //    userAdminRoles.role_name = roles.RoleName;
            //}

            //tax1040UserAdminDBContext.user_admin_role.Add(userAdminRoles);
            return tax1040UserAdminDBContext.SaveChanges();
        }

        #endregion

        #region Get All Admin User

        /// <summary>
        /// Gets all admin user.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserAdmin> GetAllUserAdmin()
        {
            var lstUserAdmin = new List<UserAdmin>();
            var searchResult = tax1040UserAdminDBContext.user_admin.Select(p => p);
            foreach (var userSearch in searchResult)
            {
                userAdmin = new UserAdmin
                    {
                        UserAdminId = userSearch.user_admin_Id,
                        UserName = userSearch.username,
                        Email = userSearch.email
                    };
                // userAdmin.AdminRoles = userSearch.role_name;
                lstUserAdmin.Add(userAdmin);
            }

            return lstUserAdmin;
        }

        #endregion

        #region Get All Admin Roles

        /// <summary>
        /// Gets all roles list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserRole> GetAdminRoles()
        {
            var lstAdminRoles = new List<UserRole>();
            var adminRoles = tax1040UserAdminDBContext.admin_role.Select(p => p);
            foreach (var role in adminRoles)
            {
                userRole = new UserRole
                {
                    AdminRoleId = role.admin_role_Id,
                    RoleName = role.role_name
                };
                lstAdminRoles.Add(userRole);
            }
            return lstAdminRoles;
        }

        #endregion

        #region Get Admin By Admin Id

        /// <summary>
        /// Gets the admin by admin user id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public UserAdmin GetUserAdminByUserAdminId(long userAdminId)
        {
            UserAdmin userAdmin = null;
            userAdmin = (tax1040UserAdminDBContext.user_admin.Where(a => a.user_admin_Id == userAdminId).Select(a => new UserAdmin
                {
                    UserAdminId = a.user_admin_Id,
                    UserName = a.username,
                    Password = a.password,
                    Salt = a.salt,
                    Email = a.email
                })).FirstOrDefault();

            return userAdmin;
        }

        #endregion

        #region Update Admin User

        /// <summary>
        /// Updates the admin user.
        /// </summary>
        /// <param name="userAdmin">The admin user.</param>
        public void UpdateUserAdmin(UserAdmin userAdmin)
        {
            var userAdmins = new user_admin
                {
                    user_admin_Id = userAdmin.UserAdminId,
                    username = userAdmin.UserName,
                    password = userAdmin.Password,
                    salt = userAdmin.Salt,
                    email = userAdmin.Email
                };
          
            tax1040UserAdminDBContext.Entry(userAdmins).State = EntityState.Modified;
            tax1040UserAdminDBContext.SaveChanges();
        }

        #endregion

        #region Delete Admin User
        /// <summary>
        /// Deletes the admin user.
        /// </summary>
        /// <param name="userAdmin">The admin user.</param>
        public void DeleteUserAdmin(UserAdmin userAdmin)
        {
            var useradmin = new user_admin
                {
                    user_admin_Id = userAdmin.UserAdminId,
                    username = userAdmin.UserName
                };
            useradmin.password = useradmin.password;
            useradmin.email = userAdmin.Email;
            useradmin.is_active = false;
            useradmin.is_deleted = true;
            tax1040UserAdminDBContext.Entry(useradmin).State = EntityState.Modified;
            tax1040UserAdminDBContext.SaveChanges();
        }
        #endregion

        /// <summary>
        /// Reset password for the logged in user.
        /// </summary>
        /// <param name="userAdmin">The admin user.</param>
        public int ResetPasswordUser(UserAdmin userAdmin)
        {
            var useradmin = new user_admin
            {
                user_admin_Id = userAdmin.UserAdminId,
                username = userAdmin.UserName,
                password = userAdmin.NewPassword,
                salt = userAdmin.Salt,
                email = userAdmin.Email
            };
            tax1040UserAdminDBContext.Entry(useradmin).State = EntityState.Modified;
            return tax1040UserAdminDBContext.SaveChanges();
        }

        #region Login Authentication

        /// <summary>
        /// Signs the in user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        public UserAdmin SignInUser(string userName)
        {

            UserAdmin userAdmin = null;
            userAdmin = (tax1040UserAdminDBContext.user_admin.Where(a => a.username == userName).Select(a => new UserAdmin
            {
                UserAdminId = a.user_admin_Id,
                UserName = a.username,
                Password = a.password,
                Salt = a.salt
            })).FirstOrDefault();

            return userAdmin;
        }


        #endregion

    }
}
