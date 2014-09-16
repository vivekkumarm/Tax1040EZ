//30 July 2014  Praveen T Added for including Payment Gateway.
namespace JTL.Tax1040.BusinessObject
{
    public class Payment
    {
        public string PaymentProcessor { get; set; }
        public string MerchantId { get; set; }
        public string TransactionKey { get; set; }
        public string MerchantReferenceCode { get; set; }
        public long UserDataId { get; set; }
    }
}
