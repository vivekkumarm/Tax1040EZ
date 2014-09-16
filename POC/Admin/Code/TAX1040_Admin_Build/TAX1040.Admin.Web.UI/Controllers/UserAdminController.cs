using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using JTL.TAX1040.Admin.BusinessObject;
using JTL.TAX1040.Admin.BusinessLogic;
using System;

namespace TAX1040.Admin.Web.UI.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class UserAdminController : Controller
    {

        #region Declaration
        private readonly UserAdminRepository userAdminRepository;
        #endregion

        #region Constructor

        public UserAdminController()
        {
            userAdminRepository = new UserAdminRepository();
        }

        #endregion
        
        
        [HttpGet]
        public ActionResult PersistUserAdmin()
        {
            if (Session["Username"] != null)
            {
                var userAdmin = new UserAdmin();
                var adminRoles = userAdminRepository.GetAllAdminRoles();
                var rolesList = adminRoles.Select(role => new SelectListItem() { Text = role.RoleName, Value = role.RoleName }).ToList();
                userAdmin.CheckboxList = rolesList;
                ViewBag.RolesCheckBoxList = rolesList;
                return View(userAdmin);
            }
            return RedirectToAction("SignInUser");
        }

        //[AllowAnonymous]
        //[HttpGet]
        //public ActionResult PersistUserAdmin()
        //{
        //    if (Session["Username"] != null)
        //    {
        //        var adminRoles = userAdminRepository.GetAllAdminRoles();
        //        ViewBag.AdminRolesList = adminRoles;
        //        return View();
        //    }
        //    return RedirectToAction("SignInUser");
        //}


        /// <summary>
        /// Persists the user admin.
        /// </summary>
        /// <param name="userAdmin">The user admin.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult PersistUserAdmin(UserAdmin userAdmin)
        {
            if (Session["Username"] != null)
            {
                if (ModelState.IsValid)
                {
                    long userAdminId = userAdminRepository.PersistUserAdmin(userAdmin);
                    //var role = new List<AdminRole> {new AdminRole {RoleName = }};
                    //userAdmin.AdminRoles = role;
                    //userAdminRepository.PersistUserAdmin(userAdmin);
                    if (userAdminId > 0)
                    {
                        ViewBag.Success = "User Created Successfully";
                    }
                }
                return View();
            }
            return RedirectToAction("SignInUser");
        }


        /// <summary>
        /// Gets all user admin.
        /// </summary>
        /// <returns></returns>
        public ActionResult GetAllUserAdmin()
        {
            if (Session["Username"] != null)
            {
                var userAdmin = userAdminRepository.GetAllUserAdmin();
                return View(userAdmin);
            }
            return RedirectToAction("SignInUser");
        }

        /// <summary>
        /// Updates the user admin.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult UpdateUserAdmin(int id = 0)
        {
            if (Session["Username"] != null)
            {
                var userAdminDetails = userAdminRepository.GetUserAdminByUserAdminId(id);
                TempData["UserAdminDetails"] = userAdminDetails;
                return View(userAdminDetails);
            }
            return RedirectToAction("SignInUser");
        }


        /// <summary>
        /// Updates the admin user.
        /// </summary>
        /// <param name="userAdmin">The user admin.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UpdateUserAdmin(UserAdmin userAdmin)
        {
            var userAdminDeatils = (UserAdmin)TempData["UserAdminDetails"];
            userAdmin.UserAdminId = userAdminDeatils.UserAdminId;
            userAdmin.Salt = userAdminDeatils.Salt;
            userAdminRepository.UpdateUserAdmin(userAdmin);
            return RedirectToAction("GetAllUserAdmin");
        }

        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="userAdminId">The user admin id.</param>
        /// <returns></returns>
         [HttpGet]
        public ActionResult ChangePassword(long userAdminId=0)
        {
            // Hardcoded for UserAdminId value for time being
            userAdminId= Convert.ToInt64(TempData["UserAdminId"]);
            var userAdminDetails = userAdminRepository.GetUserAdminByUserAdminId(userAdminId);
            TempData["UserAdminDetails"] = userAdminDetails;
            return View(userAdminDetails);
        }


         /// <summary>
         /// Changes the password.
         /// </summary>
         /// <param name="userAdmin">The user admin.</param>
         /// <returns></returns>
        [HttpPost]
        public ActionResult ChangePassword(UserAdmin userAdmin)
        {
            var userAdminDeatils = (UserAdmin)TempData["UserAdminDetails"];
            userAdmin.Email = userAdminDeatils.Email;
            userAdmin.Salt = userAdminDeatils.Salt;
            userAdmin.Password = userAdmin.NewPassword;
            userAdminRepository.ResetPassword(userAdmin);
            return RedirectToAction("GetAllUserAdmin");
        }

        /// <summary>
        /// Signs the in user.
        /// </summary>
        /// <param name="userAdmin">The user admin.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SignInUser(UserAdmin userAdmin)
        {
            UserAdmin userAdminDetails = userAdminRepository.SignInUser(userAdmin);
            if (userAdminDetails != null && userAdminDetails.UserAdminId > 0)
            {
                TempData["UserAdminId"] = userAdminDetails.UserAdminId;
                if (ControllerContext.HttpContext.Session != null)
                    ControllerContext.HttpContext.Session["Username"] = userAdminDetails.UserName;
                return RedirectToAction("Home");
            }
            else
            {
                ViewBag.Success = "Invalid credentials";
            }
            
            return View();
        }


        /// <summary>
        /// Signs the in user.
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult SignInUser()
        {
            return View();
        }


        /// <summary>
        /// Signs the in user.
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult SignOutUser()
        {
            System.Web.HttpContext.Current.Response.Cookies.Clear();
            Session["Username"] = null;
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
            return RedirectToAction("SignInUser");
        }

        /// <summary>
        /// Homes this instance.
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Home()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            return RedirectToAction("SignInUser");
        }


        /// <summary>
        /// Deletes the user admin.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult DeleteUserAdmin(int id = 0)
        {
            var userAdmin = userAdminRepository.GetUserAdminByUserAdminId(id);
            TempData["UserAdminId"] = userAdmin.UserAdminId;
            return View(userAdmin);

        }

        /// <summary>
        /// Deletes the admin user.
        /// </summary>
        /// <param name="userAdmin">The user admin.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DeleteUserAdmin(UserAdmin userAdmin)
        {
            userAdmin.UserAdminId = Convert.ToInt64(TempData["UserAdminId"]);
            userAdminRepository.DeleteUserAdmin(userAdmin);
            return RedirectToAction("GetAllUserAdmin");
        }

    }
}
