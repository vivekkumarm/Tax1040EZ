/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   ProductSKU.cs 
    Description     :   Business object for Product SKU. 
    Author          :   Ashok Kumar 
    Created Date    :   07 May 2014

    Modification History:
    ---------------------
 * 
 */

using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    public class ProductSKU
    {
        public ProductType ProductType { get; set; }

        public long SkuId { get; set; }

        public string SkuName { get; set; }

        public string SkuDescription { get; set; }

        public double SkuPrice { get; set; }

        //public State State { get; set; }

    }
}
