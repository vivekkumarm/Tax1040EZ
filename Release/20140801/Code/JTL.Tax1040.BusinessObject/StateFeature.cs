using JTL.Tax1040.Core.Object;
using System.Collections.Generic;

namespace JTL.Tax1040.BusinessObject
{
   public class StateFeature
    {
        public List<StateFeatureSKU> StateFeatureSKU { get; set; }
        public State State { get; set; }
    }
}
