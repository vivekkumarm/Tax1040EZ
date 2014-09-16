//23 July 2014 Praveen T Added Repository for Customer
using System.Collections.Generic;
using JTL.TAX1040.Admin.BusinessObject;
using JTL.TAX1040.Admin.DataAccess;

namespace JTL.TAX1040.Admin.BusinessLogic
{
    public class UserRepository
    {
        #region Declaration

        private readonly UserDataService userDataService;

        #endregion

        #region Constructor

        public UserRepository()
        {
            userDataService = new UserDataService();
        }

        #endregion

        #region Get all customers

        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAllCustomers()
        {
            return userDataService.GetAllCustomers();
        }

        #endregion
    }
}
