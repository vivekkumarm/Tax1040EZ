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
    
    public partial class usp_get_efile_error_on_submission_id_Result
    {
        public int efile_error_id { get; set; }
        public string submission_id { get; set; }
        public string error_code { get; set; }
        public string error_message { get; set; }
        public string error_classification { get; set; }
        public string action { get; set; }
        public Nullable<byte> error_picked_up { get; set; }
        public Nullable<byte> error_fixed { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
    }
}
