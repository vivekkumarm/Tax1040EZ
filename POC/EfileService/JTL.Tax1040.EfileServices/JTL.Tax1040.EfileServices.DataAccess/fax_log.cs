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
    
    public partial class fax_log
    {
        public long fax_status_id { get; set; }
        public Nullable<long> return_id { get; set; }
        public Nullable<long> shopping_cart_detail_id { get; set; }
        public string fax_number { get; set; }
        public string fax_service_number { get; set; }
        public Nullable<long> fax_return_value_id { get; set; }
        public Nullable<System.DateTime> create_time_stamp { get; set; }
        public Nullable<System.DateTime> update_time_stamp { get; set; }
    }
}