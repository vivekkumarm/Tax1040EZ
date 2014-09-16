using System;
using System.Collections.Generic;
using System.Linq;
namespace JTL.TAX1040.Admin.BusinessObject
{
    public class UserRole
    {
        public long AdminRoleId { get; set; }

        public string RoleName { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

    }
}
