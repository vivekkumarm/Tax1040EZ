﻿
/*
Copyright   : Copyright Jeevan Technologies
File Name   : IPaymentRepository.cs 
Description : Interface Payment Repository  
Author      : Sathish 
Created Date : 12May2014

 * Modification History:
------------------------
 */

using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using System.Collections.Generic;

namespace JTL.Tax1040.BusinessLogic
{
    public interface IPaymentRepository
    {
        /// <summary>
        /// Get the Payment Details
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns></returns>
        System.Tuple<double, Person, string> GetPaymentDetails(UserDTO userDTO);

     
        /// <summary>
        /// Get Invoice Details
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns></returns>
        Order GetOrderByOrderId(PaymentDTO paymentDTO);


        //Created by Yogalakshmi on 15th May 2014
        /// <summary>
        ///Get All Product SKU
        /// </summary>
        /// <param name="productId">The Product Id</param>
        /// <returns>List of Products</returns>
        List<ProductSKU> GetAllProductSKU();

        List<ProductSKU> GetProductSKUbyStateIDs(PaymentDTO paymentDTO);

        /// <summary>
        /// Order Persist
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="taxReturnData">Tax Return Data</param>
        /// <returns>status</returns>
        System.Tuple<long, List<ErrorMessage>,string> OrderPersist( PaymentDTO paymentDTO);

        /// <summary>
        /// Checks the out summary persist.
        /// </summary>
        /// <param name="paymentDTO">The payment dto.</param>
        /// <returns></returns>
        long CheckOutSummaryPersist(PaymentDTO paymentDTO);

        /// <summary>
        /// Gets the order amount.
        /// </summary>
        /// <param name="paymentDTO">The payment dto.</param>
        /// <returns></returns>
        double GetOrderAmount(PaymentDTO paymentDTO);

        /// <summary>
        /// Gets the type of all credit card.
        /// </summary>
        /// <returns></returns>
        List<CreditCardType> GetAllCreditCardType();

        /// <summary>
        /// Return all the feature associated to the user
        /// </summary>
        /// <param name="paymentDTO"></param>
        /// <returns></returns>
        ShoppingCart GetUserFeatureSKU(PaymentDTO paymentDTO);

        /// <summary>
        /// Persist User Feature
        /// </summary>
        /// <param name="paymentDTO"></param>
        /// Vincent-17July2014-change the persist user feature a return type.
        dynamic PersistUserFeature(PaymentDTO paymentDTO);

    }
}
