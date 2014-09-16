using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.TAX1040.Admin.BusinessObject
{
    public class User
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string NewPassword { get; set; }

        public string Salt { get; set; }

        public int SecurityQuestionId { get; set; }

        public string SecurityAnswer { get; set; }

        public string Email { get; set; }

        public bool? IsActive { get; set; }
        
        public bool? IsDeleted { get; set; }

        public string SecurityQuestion { get; set; }

        public long UserId { get; set; }

        public string ClientIp { get; set; }

        public PersonalInfo PersonalInfo { get; set; }
    }

}
