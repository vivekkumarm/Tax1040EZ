/*
Copyright   : Copyright Jeevan Technologies
File Name   : PaymentDataService.cs 
Description : Data Service for Payment. 
Author      : Ashok kumar Created Date : 14 May 2014


 * Modification History:
---------------------
 * 
 */

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Dynamic;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.BusinessObject;
using System.Collections.Generic;

namespace JTL.Tax1040.DataAccess
{
    public class PaymentDataService : IPaymentDataService
    {

        #region Local variable declaration

        private readonly string mTaxReturnDBConnectionString;
        private readonly string mTaxMasterDBConnectionString;


        #endregion

        #region Constructor
        public PaymentDataService()
        {
            mTaxReturnDBConnectionString = ConfigurationManager.AppSettings["TaxReturnConnectionString"];
            mTaxMasterDBConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        #endregion

        #region Get Methods

        /// <summary>
        /// Gets all product sku.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public List<ProductSKU> GetAllProductSKU(long productId)
        {
            var lstProductSKU = new List<ProductSKU>();
            using (var sqlConnection = new SqlConnection(mTaxMasterDBConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_all_productsku_by_product_id]";
                    sqlCommand.Parameters.AddWithValue("@product_id", productId);
                    //sqlCommand.Parameters.AddWithValue("@is_active", isActive);
                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var skuIdOrdinal = dataReader.GetOrdinal("sku_id");
                            var skuNameOrdinal = dataReader.GetOrdinal("sku_name");
                            var skuDescriptionOrdinal = dataReader.GetOrdinal("sku_description");
                            var skuPriceOrdinal = dataReader.GetOrdinal("sku_price");
                            while (dataReader.Read())
                            {
                                var productSKU = new ProductSKU
                                {
                                    SkuId =
                                        (!dataReader.IsDBNull(skuIdOrdinal)
                                             ? dataReader.GetInt64(skuIdOrdinal)
                                             : 0L),
                                    SkuName =
                                        (!dataReader.IsDBNull(skuNameOrdinal)
                                             ? dataReader.GetString(skuNameOrdinal)
                                             : string.Empty),
                                    SkuDescription =
                                        (!dataReader.IsDBNull(skuDescriptionOrdinal)
                                             ? dataReader.GetString(skuDescriptionOrdinal)
                                             : string.Empty),
                                    SkuPrice = Convert.ToDouble(
                                          (!dataReader.IsDBNull(skuPriceOrdinal)
                                               ? dataReader.GetDecimal(skuPriceOrdinal)
                                               : 0.0M)),
                                };
                                lstProductSKU.Add(productSKU);
                            }
                        }
                    }
                }
            }
            return lstProductSKU;
        }

        public double GetOrderAmount(PaymentDTO paymentDTO)
        {
            double orderAmount = 0;
            using (var sqlConnection = new SqlConnection(mTaxReturnDBConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_order_amount_by_shopping_cart_id]";
                    sqlCommand.Parameters.AddWithValue("@shopping_cart_id", paymentDTO.ShoppingCartId);

                    orderAmount = Convert.ToDouble(sqlCommand.ExecuteScalar());
                }
            }

            return orderAmount;
        }

        public List<CreditCardType> GetAllCreditCardType()
        {
            var lstCreditCartType = new List<CreditCardType>();
            using (var sqlConnection = new SqlConnection(mTaxMasterDBConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_all_credit_card_type]";
                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var cardTypeIdOrdinal = dataReader.GetOrdinal("credit_card_type_id");
                            var cardTypeOrdinal = dataReader.GetOrdinal("credit_card_type");
                            while (dataReader.Read())
                            {
                                var creditcardtype = new CreditCardType
                                {
                                    CardType =
                                        (!dataReader.IsDBNull(cardTypeIdOrdinal)
                                             ? (CardType)dataReader.GetInt64(cardTypeIdOrdinal)
                                             : 0L),
                                    CreditCardTypeName =
                                        (!dataReader.IsDBNull(cardTypeOrdinal)
                                             ? dataReader.GetString(cardTypeOrdinal)
                                             : string.Empty)
                                };
                                lstCreditCartType.Add(creditcardtype);
                            }
                        }
                    }
                }
            }
            return lstCreditCartType;
        }

        public List<ProductSKU> GetProductSKUbyStateIDs(PaymentDTO paymentDTO)
        {
            var lstProductSKU = new List<ProductSKU>();
            using (var sqlConnection = new SqlConnection(mTaxMasterDBConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_all_productsku_by_product_id_and_state_ids]";
                    sqlCommand.Parameters.AddWithValue("@product_id", (long)paymentDTO.ProductType);
                    sqlCommand.Parameters.AddWithValue("@state_ids", paymentDTO.StateIDs);

                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var skuIdOrdinal = dataReader.GetOrdinal("sku_id");
                            var skuNameOrdinal = dataReader.GetOrdinal("sku_name");
                            var skuDescriptionOrdinal = dataReader.GetOrdinal("sku_description");
                            var skuPriceOrdinal = dataReader.GetOrdinal("sku_price");
                            while (dataReader.Read())
                            {
                                var productSKU = new ProductSKU
                                {
                                    SkuId =
                                        (!dataReader.IsDBNull(skuIdOrdinal)
                                             ? dataReader.GetInt64(skuIdOrdinal)
                                             : 0L),
                                    SkuName =
                                        (!dataReader.IsDBNull(skuNameOrdinal)
                                             ? dataReader.GetString(skuNameOrdinal)
                                             : string.Empty),
                                    SkuDescription =
                                        (!dataReader.IsDBNull(skuDescriptionOrdinal)
                                             ? dataReader.GetString(skuDescriptionOrdinal)
                                             : string.Empty),
                                    SkuPrice = Convert.ToDouble(
                                          (!dataReader.IsDBNull(skuPriceOrdinal)
                                               ? dataReader.GetDecimal(skuPriceOrdinal)
                                               : 0.0M)),
                                };
                                lstProductSKU.Add(productSKU);
                            }
                        }
                    }
                }
            }
            return lstProductSKU;
        }

        public Order GetOrderByOrderId(PaymentDTO paymentDTO)
        {
            Order order = null;
            using (var sqlConnection = new SqlConnection(mTaxReturnDBConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_order_get_by_order_id]";
                    sqlCommand.Parameters.AddWithValue("@order_id", paymentDTO.Order.OrderId);


                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var orderId = dataReader.GetOrdinal("order_id");
                            var shoppingCartId = dataReader.GetOrdinal("shopping_cart_id");
                            var orderAmount = dataReader.GetOrdinal("order_amount");
                            var cardNumber = dataReader.GetOrdinal("card_number");
                            var cardtypeId = dataReader.GetOrdinal("cardtype_id");

                            var cardExpires = dataReader.GetOrdinal("card_expires");
                            var processed = dataReader.GetOrdinal("processed");
                            var time = dataReader.GetOrdinal("time");
                            var o_authorization = dataReader.GetOrdinal("o_authorization");


                            var ipAddress = dataReader.GetOrdinal("ip_address");
                            var name = dataReader.GetOrdinal("name");
                            var email = dataReader.GetOrdinal("email");
                            var streetAddress = dataReader.GetOrdinal("street_address");
                            var apartmentNumber = dataReader.GetOrdinal("apartment_number");


                            var city = dataReader.GetOrdinal("city");
                            var stateName = dataReader.GetOrdinal("state_name");
                            var countryName = dataReader.GetOrdinal("country_name");
                            var phone = dataReader.GetOrdinal("phone");
                            var postcode = dataReader.GetOrdinal("postcode");

                            while (dataReader.Read())
                            {
                                order = new Order
                                {
                                    OrderId =
                                        (!dataReader.IsDBNull(orderId)
                                             ? dataReader.GetInt64(orderId)
                                             : 0L),
                                    TotalAmount =
                                        (!dataReader.IsDBNull(orderAmount)
                                             ? Convert.ToDouble(dataReader.GetDecimal(orderAmount))
                                             : 0),

                                    BillingDetails = new BillingDetails
                                    {
                                        FirstName = (!dataReader.IsDBNull(name)
                                             ? dataReader.GetString(name)
                                             : ""),
                                        BillingAddress = new BillingAddress
                                        {
                                            StreetAddress = (!dataReader.IsDBNull(streetAddress)
                                             ? dataReader.GetString(streetAddress)
                                             : ""),
                                            ApartmentNumber = (!dataReader.IsDBNull(apartmentNumber)
                                            ? dataReader.GetString(apartmentNumber)
                                            : ""),
                                            City = (!dataReader.IsDBNull(city)
                                             ? dataReader.GetString(city)
                                             : ""),
                                            ZipCode = (!dataReader.IsDBNull(postcode)
                                            ? dataReader.GetString(postcode)
                                            : ""),
                                            PhoneNumber = (!dataReader.IsDBNull(phone)
                                             ? dataReader.GetString(phone)
                                             : ""),
                                            StateOrProvince = (!dataReader.IsDBNull(stateName)
                                            ? dataReader.GetString(stateName)
                                            : "")
                                        }
                                    }
                                };

                            }

                            dataReader.NextResult();

                            if (dataReader.HasRows)
                            {
                                if (order == null)
                                    order = new Order();

                                order.ShoppingCart = new List<ShoppingCart>();

                                var skuId = dataReader.GetOrdinal("sku_id");
                                var skuName = dataReader.GetOrdinal("sku_name");
                                var skuDescription = dataReader.GetOrdinal("sku_description");
                                var skuPrice = dataReader.GetOrdinal("sku_price");
                                var stateId = dataReader.GetOrdinal("state_id");

                                while (dataReader.Read())
                                {

                                    order.ShoppingCart.Add(new ShoppingCart
                                    {
                                        SkuId = (!dataReader.IsDBNull(skuId)
                                                             ? dataReader.GetInt64(skuId)
                                                             : 0L),
                                        SkuName = (!dataReader.IsDBNull(skuName)
                                             ? dataReader.GetString(skuName)
                                             : ""),
                                        SkuDescription = (!dataReader.IsDBNull(skuDescription)
                                             ? dataReader.GetString(skuDescription)
                                             : ""),
                                        SkuPrice = (!dataReader.IsDBNull(skuPrice)
                                             ? Convert.ToDouble(dataReader.GetDecimal(skuPrice))
                                             : 0)
                                    });
                                }

                            }
                        }
                    }
                }
            }

            return order;
        }

        #endregion

        #region Persist

        public long OrderPersist(long userId, long userDataId, Order orders, string ipAddress)
        {
            long orderId = 0;
            if (orders != null && orders.BillingDetails != null)
            {
                using (var sqlConnection = new SqlConnection(mTaxReturnDBConnectionString))
                {
                    using (var sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlConnection.Open();
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "[dbo].[usp_order_and_order_billing_address_persist]";

                        sqlCommand.Parameters.AddWithValue("@user_data_id", userId);
                        sqlCommand.Parameters.AddWithValue("@shopping_cart_id", orders.ShoppingCartId);
                        sqlCommand.Parameters.AddWithValue("@order_amount", orders.TotalAmount);

                        if (orders.BillingDetails != null && orders.BillingDetails.CreditCard != null)
                        {
                            sqlCommand.Parameters.AddWithValue("@card_number", orders.BillingDetails.CreditCard.CreditCardNo);
                            sqlCommand.Parameters.AddWithValue("@cardtype_id", orders.BillingDetails.CreditCard.CreditCardType.CardType);
                            sqlCommand.Parameters.AddWithValue("@card_expires", orders.BillingDetails.CreditCard.ExpiryMonth + '-'
                                                                                 + orders.BillingDetails.CreditCard.ExpiryYear);

                        }



                        sqlCommand.Parameters.AddWithValue("@processed", orders.Processed); 
                        sqlCommand.Parameters.AddWithValue("@time", orders.PaymentDate ); 
                        sqlCommand.Parameters.AddWithValue("@o_authorization", orders.Authorization ); 
                        sqlCommand.Parameters.AddWithValue("@ip_address", ipAddress);
                        sqlCommand.Parameters.AddWithValue("@name", orders.BillingDetails.FirstName + ' ' + orders.BillingDetails.LastName);
                        sqlCommand.Parameters.AddWithValue("@email", orders.BillingDetails.Email);
                        sqlCommand.Parameters.AddWithValue("@street_address", orders.BillingDetails.BillingAddress.StreetAddress);
                        sqlCommand.Parameters.AddWithValue("@apartment_number", orders.BillingDetails.BillingAddress.ApartmentNumber);
                        sqlCommand.Parameters.AddWithValue("@city", orders.BillingDetails.BillingAddress.City);
                        if (orders.BillingDetails.BillingAddress.IsForeignAddress)
                        {
                            sqlCommand.Parameters.AddWithValue("@state_name", orders.BillingDetails.BillingAddress.StateOrProvince);
                        }
                        else
                        {
                            if (orders.BillingDetails.BillingAddress.State != null)
                                sqlCommand.Parameters.AddWithValue("@state_name", orders.BillingDetails.BillingAddress.State.StateName);
                        }

                        if (orders.BillingDetails.BillingAddress.IsForeignAddress)
                            sqlCommand.Parameters.AddWithValue("@country_name", orders.BillingDetails.BillingAddress.Country.CountryName);
                        sqlCommand.Parameters.AddWithValue("@phone", orders.BillingDetails.BillingAddress.PhoneNumber);
                        sqlCommand.Parameters.AddWithValue("@postcode", orders.BillingDetails.BillingAddress.ZipCode);


                        orderId = (long)sqlCommand.ExecuteScalar();
                    }
                }
            }
            return orderId;
        }

        public long CheckOutSummaryPersist(PaymentDTO paymentDTO)
        {
            long shopingCartId = 0;

            using (var sqlConnection = new SqlConnection(mTaxReturnDBConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_shopping_cart_and_order_detail_mapper_persist]";

                    sqlCommand.Parameters.AddWithValue("@user_data_id", paymentDTO.UserDataId);
                    sqlCommand.Parameters.AddWithValue("@product_id", paymentDTO.ProductType);
                    sqlCommand.Parameters.AddWithValue("@state_ids", paymentDTO.StateIDs);

                    shopingCartId = (long)sqlCommand.ExecuteScalar();
                }
            }
            return shopingCartId;
        }

        #endregion

        #region Validatate Zip code
        public bool ValidateZipCodeByStateId(long stateId, long zipCode)
        {
            bool isValidZipCode = false;
            using (var sqlConnection = new SqlConnection(mTaxMasterDBConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_validate_zip_code_by_state_id]";
                    sqlCommand.Parameters.AddWithValue("@state_id", stateId);
                    sqlCommand.Parameters.AddWithValue("@zip_code", zipCode);

                    isValidZipCode = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                }
            }

            return isValidZipCode;
        }
        #endregion

    }
}
