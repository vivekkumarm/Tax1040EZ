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
    
    public partial class efile_request_response
    {
        public long efile_req_res_id { get; set; }
        public string submission_id { get; set; }
        public string message_id { get; set; }
        public string request { get; set; }
        public string response { get; set; }
        public string action { get; set; }
        public Nullable<byte> status_id { get; set; }
        public Nullable<System.DateTime> create_time_stamp { get; set; }
        public Nullable<System.DateTime> update_time_stamp { get; set; }
    }
}
