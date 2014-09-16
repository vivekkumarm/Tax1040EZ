
using JTL.Tax1040.Core.Object;
namespace JTL.Tax1040.BusinessObject
{
    public class FederalFeatureSKU
    {
        public long FederalFeatureSkuId { get; set; }
        public ProductType ProductType { get; set; }
        public  string FederalName { get; set; }
        public Feature Feature { get; set; }
        public double FederalFeaturePrice { get; set; }
    }
}
