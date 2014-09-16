/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   ShoppingCart.cs 
    Description     :   Business object for ShoppingCart. 
    Author          :   Ashok Kumar 
    Created Date    :   08 May 2014

    Modification History:
    ---------------------
 * 
 */
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    //TODO need to finalized on the properties - how to handle multiple state payments
    public class ShoppingCart
    {
        public ProductType ProductType { get; set; }

        public long SkuId { get; set; }

        public string SkuName { get; set; }

        //Not needed since its a description
        public string SkuDescription { get; set; }

        public double SkuPrice { get; set; }

        public State State { get; set; }

    }
}
