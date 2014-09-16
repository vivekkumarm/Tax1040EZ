/*
Copyright   : Copyright Jeevan Technologies
File Name   : IUserRepository.cs 
Description : Business Logic Interface for user. 
Author      : Balasubramanian Velmurugan Created Date : 20 Mar 2014

 * Modification History:
---------------------
 * 24Mar2014 Sathish Changed method name from GetUserNameAndPasswordByUserDetails to GetUserNameAndIdByUserDetails
 * 25Mar2014 Sathish Code Changes removed .value while passing dynamic object
 *  26Mar2014 Bala Code Changes to modify the method name "UpdatePasswordResetLinkBySecurityInfo" and added new method "UpdateEmailBySecurityInfo"
 *  31Mar2014 Sathis Changed validatePasswordResetCode by user id instead of user Name and return true or false
 *               Changed Method name From UpdatePasswordResetLinkBySecurityInfo to UpdateUserNamePasswordResetCodeBySecurityInfo
 *  31Mar2014 Bala added ErrorMessages as Out parameter for required method. 
 *  16Apr2014 Sathish Changed email template in ResendEmailForForgotPassword
 *  23April2014 Thileepkumar Changed validatePassword by user id   
 *   28April2014 Thileepkumar Changed updateuserdetailsbyuserid
 *  28April2014 Thileepkumar Changed validateuserpasswordbyuserid
 *  30April2014 Thileepkumar Changed validateuserpasswordbyuserid
 *  07May2014 Bala refactored the code
 *  09May2014 Bala Method added to get email by UserId.
 *  19th May, 2014 - Saravanan N - IsTaxObjectExists removed. 
 *  26Jun2014 Thileep changed ValidateUserPasswordByUserId method
 *  26Jun2014 Thileep changed UpdateUserDetailsByUserId method
 */


using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Web.Http;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.WebApi.Security;

namespace JTL.Tax1040.WebApi.Controllers
{
    public class UserController : ApiController
    {
        IUserRepository userRepository = new UserRepository();
        IMessagesRepository messagesRepository = new MessagesRepository();
        ITaxReturnRepository taxReturnRepository = new TaxReturnRepository();

        //[System.Web.Http.AcceptVerbs("GET", "POST")]
        //[System.Web.Http.HttpPost]

        /// <summary>
        /// Inserts the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        [HttpPost]
        public dynamic PersistUser(User user)
        {
            dynamic userdetail = new ExpandoObject();
            StringCollection errormessage;
            userdetail.UserID = userRepository.PersistUser(user, out errormessage);
            userdetail.message = errormessage;
            return userdetail;
        }

        /// <summary>
        /// Signs the in user.
        /// </summary>
        /// <param name="user">The user name and password</param>
        /// <returns></returns>
        [HttpPost]
        public dynamic SignInUser(User user)
        {
            dynamic userdetail = new ExpandoObject();

            userdetail.UserId = userRepository.SignInUser(user.UserName, user.Password);

            string currentIP = Request.GetClientIP();
            Token encryptedTocken = new Token(userdetail.UserId.ToString(), currentIP);
            userdetail.EncryptedTocken = encryptedTocken.Encrypt();
            return userdetail;
        }

        /// <summary>
        /// Gets the user id by user details.
        /// </summary>
        /// <param name="personDetail">The person detail.</param>
        /// <returns></returns>
        [HttpPost]
        public long GetUserIdByUserDetails(Person personDetail)
        {
            return userRepository.GetUserIdByUserDetails(personDetail);
        }

        /// <summary>
        /// Gets the user name and ID by user details.
        /// </summary>
        /// <param name="userDetail">The user detail.</param>
        /// <returns></returns>
        [HttpPost]
        public long GetUserNameAndIdByUserDetails(dynamic userDetail)
        {
            dynamic userDetailByPersonInfo = new ExpandoObject();
            userDetailByPersonInfo.FirstName = userDetail.FirstName.Value;
            userDetailByPersonInfo.LastName = userDetail.LastName.Value;
            userDetailByPersonInfo.DateOfBirth = userDetail.DateOfBirth.Value;
            userDetailByPersonInfo.Email = userDetail.Email.Value;
            return userRepository.GetUserNameAndIdByUserDetails(userDetailByPersonInfo);
        }

        /// <summary>
        /// Get user name by email
        /// </summary>
        /// <param name="user">The user email</param>
        /// <returns>The user Name</returns>
        [HttpPost]
        public string GetUserNameByEmail(User user)
        {
            return userRepository.GetUserNameByEmail(user.Email);
        }

        /// <summary>
        /// Gets the name of the user id by user.
        /// </summary>
        /// <param name="user">Name of the user.</param>
        /// <returns></returns>
        [HttpPost]
        public long GetUserIdByUserName(User user)
        {
            return userRepository.GetUserIdByUserName(user.UserName);
        }


        /// <summary>
        /// Update the email by user id.
        /// </summary>
        /// <param name="userDetail">The user detail.</param>
        /// <returns>status</returns>
        [HttpPut]
        public bool UpdateEmailByUserId(User userDetail)
        {
            //TODO : Have to implement code to pass the errorMessages to UI after the Demo.
            StringCollection errormessage;
            return userRepository.UpdateEmailByUserId(userDetail.Email, userDetail.UserId, out errormessage);
        }


        /// <summary>
        ///  Update the password Reset Code
        /// </summary>
        /// <param name="userDetail">The user detail.</param>
        /// <returns>status</returns>
        [HttpPut]
        public bool UpdatePasswordResetCode(User userDetail)
        {
            return userRepository.UpdatePasswordResetCodeBySecurityInfo(userDetail.UserId, userDetail.SecurityQuestionId, userDetail.SecurityAnswer);
        }


        /// <summary>
        /// Reset the user password.
        /// </summary>
        /// <param name="userDetail">The user detail.</param>
        /// <returns></returns>
        [HttpPut]
        public bool ResetPassword(User userDetail)
        {
            //TODO : Have to implement code to pass the errorMessages to UI after the Demo.
            StringCollection errormessage;
            return userRepository.ResetPassword(userDetail.UserName, userDetail.Password, userDetail.UserId, out errormessage);
        }

        /// <summary>
        /// Validate the password reset code.
        /// </summary>
        /// <param name="userDetail">The user detail.</param>
        /// <returns>The Status</returns>
        [HttpPost]
        public bool ValidateUserPasswordResetCode(dynamic userDetail)
        {
            return userRepository.ValidateUserPasswordResetCode(Utilities.ConvertToLong(userDetail.UserId.Value),
                                                                Utilities.ConvertToInteger32(userDetail.PasswordResetCode.Value));
        }


        /// <summary>
        /// Update password reset link by security Info
        /// </summary>
        /// <param name="userDetail">The User Details</param>
        /// <returns>status</returns>
        [HttpPut]
        public bool UpdateUserNamePasswordResetCodeBySecurityInfo(User userDetail)
        {
            return userRepository.UpdateUserNamePasswordResetCodeBySecurityInfo(userDetail.UserId, userDetail.SecurityQuestionId, userDetail.SecurityAnswer);
        }

        /// <summary>
        /// Update email by security Info
        /// </summary>
        /// <param name="userDetail">The User Details</param>
        /// <returns>User details</returns>
        [HttpPut]
        public long UpdateEmailBySecurityInfo(User userDetail)
        {
            return userRepository.UpdateEmailBySecurityInfo(userDetail.UserId, userDetail.SecurityQuestionId, userDetail.SecurityAnswer);
        }

        /// <summary>
        /// Get Security Question
        /// </summary>
        /// <returns>The Security Question</returns>
        [HttpGet]
        public Dictionary<int, string> GetSecurityQuestion()
        {
            return userRepository.GetSecurityQuestion();
        }

        /// <summary>
        /// Get Security Question By User
        /// </summary>
        /// <param name="user">The User Id</param>
        /// <returns>The Security Question</returns>
        [HttpPost]
        public KeyValuePair<int, string> GetSecurityQuestionByUserId(User user)
        {
            return userRepository.GetSecurityQuestionByUserId(user.UserId);
        }

        /// <summary>
        /// Get email by User id.
        /// </summary>
        /// <param name="user">The User Id</param>
        /// <returns>Email</returns>
        [HttpPost]
        public string GetEmailByUserId(User user)
        {
            return userRepository.GetEmailByUserId(user.UserId);
        }

        /// <summary>
        /// Resend the email for forgot password.
        /// </summary>
        /// <param name="user">The User Id</param>
        /// <returns>Status</returns>
        [HttpPost]
        public bool ResendEmailForForgotPassword(User user)
        {
            return userRepository.ResendEmailByUserId(user.UserId, EmailTemplate.SendPasswordResetCode);
        }

        /// <summary>
        /// Resend the email for forgot username & password.
        /// </summary>
        /// <param name="user">The User Id</param>
        /// <returns>Status</returns>
        [HttpPost]
        public bool ResendEmailForForgotUsernamePassword(User user)
        {
            return userRepository.ResendEmailByUserId(user.UserId, EmailTemplate.SendUserNameAndPasswordReset);
        }

        /// <summary>
        /// Resend the email for forgot username.
        /// </summary>
        /// <param name="user">The User detail</param>
        /// <returns>Status</returns>
        [HttpPost]
        public bool ResendEmailForForgotUserName(User user)
        {
            return userRepository.ResendEmailForForgotUserName(user.UserName, user.Email);
        }

        //Saravanan N - 15th April, 2014 - Get Last visited URL from TaxObject.
        /// <summary>
        /// Get Tax Object.
        /// </summary>
        /// <param name="user">The User detail</param>
        /// <returns>Status</returns>
        [HttpPost]
        public string GetSessionDataByUserIdAndUserDataId(dynamic userData)
        {
            UserDTO userDTO = new UserDTO()
            {
                UserId = Utilities.ConvertToLong(userData.userId),
                UserDataId = Utilities.ConvertToLong(userData.userDataId)
            };
            return taxReturnRepository.GetSessionDatabyUserIdAndUserDataId(userDTO);
        }

        /// <summary>
        ///Get User Details By User Id
        /// </summary>        
        /// <returns>User Details of A Particular Id</returns> 
        [HttpPost]
        public User GetUserDetailsByUserId(User user)
        {
            return userRepository.GetUserDetailsByUserId(user.UserId);
        }

        /// <summary>
        ///Update User Details By User Id
        /// </summary>        
        /// <returns>Tuple</returns>      
        [HttpPost]
        public System.Tuple<long, StringCollection> UpdateUserDetailsByUserId(User user)
        {
            return userRepository.UpdateUserDetailsByUserId(user);
        }

        /// <summary>
        ///Validate User Password By User Id
        /// </summary>        
        /// <returns>Tuple</returns>  
        [HttpPost]
        public System.Tuple<long, StringCollection> ValidateUserPasswordByUserId(User user)
        {
            return userRepository.ValidateUserPasswordByUserId(user);

        }

    }
}