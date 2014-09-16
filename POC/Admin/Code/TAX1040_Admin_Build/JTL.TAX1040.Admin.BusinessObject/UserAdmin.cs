using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web.Mvc;

namespace JTL.TAX1040.Admin.BusinessObject
{
    public class UserAdmin
    {

        public long UserAdminId { get; set; }


        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Missing UserName")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Missing Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password",ErrorMessage = "Password does not match")]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Missing Confirm Password")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Missing New Password")]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessage = "Password does not match")]
        [Display(Name = "Retype Password")]
        public string ConfirmNewPassword { get; set; }
        
        public string Salt { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Missing Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public bool IsActive { get; set; }

        public List<UserAdminRole> AdminRoles { get; set; }

        [Required(ErrorMessage = "Please select at least one checkbox")]
        public IEnumerable<SelectListItem> CheckboxList { get; set; }
    }
}



