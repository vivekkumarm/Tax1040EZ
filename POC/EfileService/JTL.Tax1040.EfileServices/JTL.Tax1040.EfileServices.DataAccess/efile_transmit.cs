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
    
    public partial class efile_transmit
    {
        public long efile_transmit_id { get; set; }
        public Nullable<long> return_id { get; set; }
        public string return_type { get; set; }
        public string stage { get; set; }
        public string state { get; set; }
        public Nullable<long> user_id { get; set; }
        public string ip_date_time { get; set; }
        public string ip_time_zone { get; set; }
        public string ip_address { get; set; }
        public Nullable<int> status_id { get; set; }
        public Nullable<bool> is_deleted { get; set; }
    }
}
