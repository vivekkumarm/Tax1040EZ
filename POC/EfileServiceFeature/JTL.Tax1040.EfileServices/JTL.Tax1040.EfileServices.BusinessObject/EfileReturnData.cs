namespace JTL.Tax1040.EfileServices.BusinessObject
{
    public class EfileReturnData
    {
        public long EFileReturnDataId
        {
            get;
            set;
        }

        public string SenderId
        {
            get;
            set;
        }

        public long UserDataId
        {
            get;
            set;
        }

        public string ProductId 
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public int NoOfAttachments
        {
            get;
            set;
        }

        public string EncryptedTaxData 
        {
            get;
            set;
        }

        public string EnvIndicator
        {
            get;
            set;
        }

        public string EFileTransID
        {
            get;
            set;
        }

        public string TaxYear
        {
            get;
            set;
        }
    }
}
