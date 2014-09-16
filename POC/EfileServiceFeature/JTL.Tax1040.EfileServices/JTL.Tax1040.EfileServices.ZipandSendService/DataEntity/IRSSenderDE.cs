namespace JTL.Tax1040.EfileServices.ZipandSendService.SenderChannel
{
    public class IRSSenderDE
    {
        public string UserName { get; set; }

        public string SubmissionID { get; set; }

        public int StatusID { get; set; }

        public string RequestXML { get; set; }

        public string ResponseXML { get; set; }

        public string MessageID { get; set; }

        public byte[] SendSubmissionStatus { get; set; }

        public string ServiceAction { get; set; }

        public IRSErrorDE Error { get; set; }
    }

    public class IRSErrorDE
    {
        public bool IsErrorPresent { get; set; }

        public string ErrorCode { get; set; }

        public string ErrorMessage { get; set; }

        public string ErrorClassification { get; set; }

        public string Action { get; set; }
    }
}
