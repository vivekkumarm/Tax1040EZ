using System.Collections.Generic;
using System.Linq;
using JTL.TAX1040.Admin.BusinessObject;

namespace JTL.TAX1040.Admin.DataAccess
{
    public class UserDataService
    {

        #region Declaration

        private readonly Tax1040Entities tax1040Context;
        private User user;
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDataService"/> class.
        /// </summary>
        public UserDataService()
        {
            tax1040Context = new Tax1040Entities();
            user = new User();
        }

        #endregion

        #region Get All Customer
        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAllCustomers()
        {
            var lstUser = new List<User>();
            //var searchResult = dbContext.personal_info.Select(p => p).Where(p => p.first_name == personalInfo.first_name || p.occupation == personalInfo.occupation
            ////    || p.social_security_number == personalInfo.social_security_number || p.date_of_birth == personalInfo.date_of_birth);
            //if (personalInfo.user.username != null && personalInfo.user.username != "")
            //{
            var searchResult =
                tax1040Context.users.Select(p => p);
            foreach (var userSearch in searchResult)
            {

                user = new User();
                user.PersonalInfo = new BusinessObject.PersonalInfo();
                user.UserName = userSearch.username;
                user.Email = userSearch.email;

                var objPersonalInfo =
                    tax1040Context.personal_info.Select(p => p);
                foreach (var userPersonal in objPersonalInfo)
                {
                    user.PersonalInfo.FirstName = userPersonal.first_name;
                    user.PersonalInfo.LastName = userPersonal.last_name;
                    user.PersonalInfo.Occupation = userPersonal.occupation;
                    user.PersonalInfo.SSN = userPersonal.social_security_number;
                }

                lstUser.Add(user);
            }
            return lstUser;
        }

        #endregion

        //public List<PersonalInfo> GetPersonalInfoByPersonalId()
        //{

        //    var personal = dbContext.personal_info.Select(p => p);
        //    //var personalInfo=dbContext.usp_personal_info_get_by_personal_info_id(personal_info_id);
        //    foreach (var item in personal)
        //    {
        //        pi.first_name = item.first_name;
        //        pi.last_name = item.last_name;
        //        piList.Add(pi);
        //    }
        //    return piList;
        //}
    }
}
