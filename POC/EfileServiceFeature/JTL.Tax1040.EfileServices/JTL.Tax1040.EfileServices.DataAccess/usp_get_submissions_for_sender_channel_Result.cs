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
    
    public partial class usp_get_submissions_for_sender_channel_Result
    {
        public string tax_return_type_id { get; set; }
        public Nullable<long> return_id { get; set; }
        public string efile_trans_id { get; set; }
        public long efile_hold_id { get; set; }
        public string submission_id { get; set; }
        public byte[] dime_attachment { get; set; }
        public System.DateTime create_time_stamp { get; set; }
    }
}