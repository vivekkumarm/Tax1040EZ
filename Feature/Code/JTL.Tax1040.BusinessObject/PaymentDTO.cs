/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   PaymentDTO.cs 
    Description     :   Business object for User related Ids. 
    Author          :   Sathish N.
    Created Date    :   05th May, 2014

    Modification History:
    ---------------------
 */

using System;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
   public class PaymentDTO
    {
       public long UserId { get; set; }
       public long UserDataId { get; set; }
       public ProductType ProductType { get; set; }
       //public ShoppingCart ShoppingCart { get; set; }
       public long ShoppingCartId { get; set; }
       public string StateIDs { get; set; }
       public Order Order { get; set; }
       public IRS IRS { get; set; }

       public DateTime PaymentDate { get; set; }
       public string PaymentProcessor { get; set; }
       public string MerchantId { get; set; }
       public string TransactionKey { get; set; }
       public string MerchantReferenceCode { get; set; }
       public StatusType OperationStatus { get; set; }
       public string CyberSourceResponse { get; set; }
       public string ExceptionErrorMessage { get; set; }
    }
}
