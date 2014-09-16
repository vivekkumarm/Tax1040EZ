/*
Copyright   : Copyright Jeevan Technologies
File Name   : IPaymentDataService.cs 
Description : Data Service Interface for Payment. 
Author      : Ashok kumar Created Date : 14 May 2014

 * Modification History:
---------------------
 *
 */

using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using JTL.Tax1040.BusinessObject;
using System.Collections.Generic;

namespace JTL.Tax1040.DataAccess
{
    public interface IPaymentDataService
    {
        #region Get Methods

        /// <summary>
        /// Gets all product sku.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        List<ProductSKU> GetAllProductSKU(long productId);

        double GetOrderAmount(PaymentDTO paymentDTO);

        List<ProductSKU> GetProductSKUbyStateIDs(PaymentDTO paymentDTO);

        Order GetOrderByOrderId(PaymentDTO paymentDTO);

        #endregion

        #region Persist


        /// <summary>
        /// Order Persist
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <param name="orders">Order</param>
        /// <returns>Status</returns>
        long OrderPersist(long userId, long userDataId, Order orders, string ipAddress);

        /// <summary>
        /// Checks the out summary persist.
        /// </summary>
        /// <param name="paymentDTO">The payment dto.</param>
        /// <returns></returns>
        long CheckOutSummaryPersist(PaymentDTO paymentDTO);

        /// <summary>
        /// Validates the zip code by state identifier.
        /// </summary>
        /// <param name="stateId">The state identifier.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <returns></returns>
        bool ValidateZipCodeByStateId(long stateId, long zipCode);

        /// <summary>
        /// Gets the type of all credit card.
        /// </summary>
        /// <returns></returns>
        List<CreditCardType> GetAllCreditCardType();

        #endregion
    }
}
