
namespace JTL.TAX1040.Admin.BusinessObject
{
    public class UserAdminRole
    {
        public long UserAdminRoleId { get; set; }
        public long UserAdminId { get; set; }
        public long AdminRoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsDeleted { get; set; }

        //public string AccountManager { get;set;}

        //public string DeveloperManager { get; set; }

        //public string SupportManager { get; set; }

        //public string EMailManager { get; set; }

        //public string SuperManager { get; set; }

        //public string ReportManager { get; set; }
        
    }
}


