//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JTL.Tax1040.EfileServices.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class efile_log
    {
        public int efile_log_id { get; set; }
        public long efile_hold_id { get; set; }
        public string messages { get; set; }
        public bool is_deleted { get; set; }
        public System.DateTime create_time_stamp { get; set; }
        public System.DateTime update_time_stamp { get; set; }
    
        public virtual efile_hold efile_hold { get; set; }
    }
}
