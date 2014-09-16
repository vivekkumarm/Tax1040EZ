
using System.Web.Http;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using Newtonsoft.Json;
using System.Collections.Generic;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.WebApi.Controllers
{
    public class PaymentController : ApiController
    {
        #region Local variables
        static readonly IPaymentRepository paymentRepository = new PaymentRepository();
        #endregion

        #region Get

        //Created by Yogalakshmi on 15th May 2014
        /// <summary>
        ///Get All Product SKU
        /// </summary>
        /// <param name="productId">The Product Id</param>
        /// <returns>List of Productsku</returns>
        //[AcceptVerbs("GET", "POST")]
        [HttpPost]
        public List<ProductSKU> GetAllProductSKU()
        {
            return paymentRepository.GetAllProductSKU();
        }

        /// <summary>
        /// Get Product SKU by state Ids
        /// </summary>
        /// <param name="paymentDTO">The Payment DTO</param>
        /// <returns>The selected state</returns>
        [HttpPost]
        public System.Tuple<List<ProductSKU>, ReturnStatus> GetProductSKUbyStateIDs(PaymentDTO paymentDTO)
        {
            ReturnStatus returnStatus = new ReturnStatus();
            var payment= paymentRepository.GetProductSKUbyStateIDs(paymentDTO);
            return new System.Tuple<List<ProductSKU>, ReturnStatus>(payment, returnStatus);
        }

        /// <summary>
        /// Get the Payment Details
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns></returns>
        [HttpPost]
        public System.Tuple<double, Person, string> GetPaymentDetails(UserDTO UserData)
        {
            return paymentRepository.GetPaymentDetails(UserData);
        }

        ///// <summary>
        ///// Get the IRS Payment Option
        ///// </summary>
        ///// <param name="userId">The User Id</param>
        ///// <param name="userDataId">The User Data Id</param>
        ///// <returns></returns>
        //[HttpPost]
        //public System.Tuple<double, IRS> GetIRSPaymentOption(UserDTO UserData)
        //{
        //    return paymentRepository.GetIRSPaymentOption(UserData);
        //}

        /// <summary>
        /// Get Invoice Details
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns></returns>
        [HttpPost]
        public Order GetOrderByOrderId(PaymentDTO paymentDTO)
        {
            return paymentRepository.GetOrderByOrderId(paymentDTO);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserInputData"></param>
        /// <returns></returns>
        [HttpPost]
        public double GetOrderAmount(PaymentDTO paymentDTO)
        {
            return paymentRepository.GetOrderAmount(paymentDTO);
        }

        /// <summary>
        /// Get all credit card type
        /// </summary>
        /// <returns>Credit Card Type</returns>
        [HttpGet]
        public List<CreditCardType> GetAllCreditCardType()
        {            
            return paymentRepository.GetAllCreditCardType();
        }

        [HttpPost]
        public ShoppingCart GetUserFeatureSKU(PaymentDTO paymentDTO)
        {
            return paymentRepository.GetUserFeatureSKU(paymentDTO);
        }

        #endregion

        #region Persist

       // /// <summary>
       // /// Persit IRS Payment Option
       // /// </summary>
       // /// <param name="userId">The User Id</param>
       // /// <param name="taxReturnData">The Tax Return Data</param>
       // /// <returns>The User Data Id</returns>
       //[HttpPost]
       // public System.Tuple<long, List<ErrorMessage>> PersistIRSPaymentOption(PaymentDTO paymentDTO)
       // {
       //     return paymentRepository.PersistIRSPaymentOption(paymentDTO);
       // }

        /// <summary>
        /// Order Persist
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
       [HttpPost]
       public System.Tuple<long, List<ErrorMessage>> OrderPersist(PaymentDTO paymentDTO)
       {
           return paymentRepository.OrderPersist(paymentDTO);
       }

        /// <summary>
        /// Check out summary persist
        /// </summary>
        /// <param name="paymentDTO">The Payment DTO</param>
        /// <returns>The Shoping cart Id</returns>
       [HttpPost]
       public long CheckOutSummaryPersist(PaymentDTO paymentDTO)
       {
           return paymentRepository.CheckOutSummaryPersist(paymentDTO);
       }

       /// <summary>
       /// Persist User Feature
       /// </summary>
       /// <param name="paymentDTO"></param>
       /// /// Vincent-17July2014-change the persist user feature a return type.
       [HttpPost]
       public dynamic PersistUserFeature(PaymentDTO paymentDTO)
       {
          return paymentRepository.PersistUserFeature(paymentDTO);
       }

        #endregion
    }
}
