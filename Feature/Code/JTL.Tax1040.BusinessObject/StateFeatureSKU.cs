using JTL.Tax1040.Core.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.BusinessObject
{
   public class StateFeatureSKU
    {
        public long StateFeatureSkuId { get; set; }
        public ProductType ProductType { get; set; }
        public Feature Feature { get; set; }
        public double StatePrice { get; set; }
        public State State { get; set; }
    }
}
