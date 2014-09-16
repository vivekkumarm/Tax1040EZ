/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   ShoppingCart.cs 
    Description     :   Business object for Order. 
    Author          :   Ashok Kumar 
    Created Date    :   08 May 2014

    Modification History:
    ---------------------
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.BusinessObject
{
    public class Order
    {
        //OrderId is an Identity field
         public long OrderId { get; set; }
         public bool Processed { get; set; }

         public long ShoppingCartId { get; set; }

         public List<ShoppingCart> ShoppingCart;

        ////Invoice no can be same as Orderid - If not we should work on logic to generate InvoiceId
        // public string InvoiceNo { get; set; }

         public double TotalAmount { get; set; }

        ////Place this property in both billingDetails.cs and here.. Need to finalize on the placing of this
        // public CreditCard CreditCard { get; set; }

         public DateTime PaymentDate { get; set; }

         public BillingDetails BillingDetails { get; set; }

         public string Authorization { get; set; }
    }
}
