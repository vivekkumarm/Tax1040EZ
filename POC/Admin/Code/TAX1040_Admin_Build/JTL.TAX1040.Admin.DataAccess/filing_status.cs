//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JTL.TAX1040.Admin.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class filing_status
    {
        public filing_status()
        {
            this.personal_info = new HashSet<personal_info>();
        }
    
        public long filing_status_id { get; set; }
        public string filing_status1 { get; set; }
        public bool is_active { get; set; }
        public bool is_deleted { get; set; }
        public System.DateTime create_datetime { get; set; }
        public System.DateTime update_datetime { get; set; }
    
        public virtual ICollection<personal_info> personal_info { get; set; }
    }
}
