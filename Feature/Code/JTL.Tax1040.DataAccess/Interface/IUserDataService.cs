/*
Copyright   : Copyright Jeevan Technologies
File Name   : IUserDataService.cs 
Description : Data Service Interface for user. 
Author      : Balasubramanian Velmurugan Created Date : 03 Mar 2014

 * Modification History:
---------------------
 * 18Mar14 Sathish Code Changed to check user by question id instead of question
 *  26Mar14 Bala return type modified in UpdateEmailByUserId and ResetPassword method.
 *  31Mar2014 Sathis Changed validatePasswordResetCode by user id instead of user Name and return true or false
 *  23April2014 Thileepkumar Changed validatePassword by user id 
 */

using JTL.Tax1040.BusinessObject;
using System;
using System.Collections.Generic;

namespace JTL.Tax1040.DataAccess
{
    /// <summary>
    /// Regarding IUserDataService : Methods need to be implemented in User DataService.
    /// </summary>
    public interface IUserDataService
    {
        /// <summary>
        /// Login Authentication.
        /// </summary>
        /// <param name="userName">User Name</param>
        /// <returns>User Details ID, Password and Salt</returns>
        dynamic SignInUser(string userName);

        /// <summary>
        /// Persist the user details.
        /// </summary>
        /// <param name="user">The user detail.</param>
        /// <returns>Sign in details.</returns>
        dynamic PersistUser(User userDetail);

        /// <summary>
        /// Gets the user name by email id.
        /// </summary>
        /// <param name="emailId">The email id.</param>
        /// <returns>The user name.</returns>
        string GetUserNameByEmail(string emailId);

        /// <summary>
        /// Get user id by username.
        /// </summary>
        /// <param name="userName">The username</param>
        /// <returns>The user id.</returns>
        long GetUserIdByUserName(string userName);

        /// <summary>
        /// Get the user name and email by user id and security info.
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="securityQuestion">The security question</param>
        /// <param name="securityAnswer">The security answer</param>
        /// <returns>User id and email</returns>
        dynamic GetUserNameAndEmailByUserIdAndSecurityInfo(long userName, int securityQuestion, string securityAnswer);

        /// <summary>
        /// Update password reset code by user ID
        /// </summary>
        /// <param name="resetCode">The reset Code </param>
        /// <param name="userId">The user id</param>
        /// <returns>Return true if updated else false</returns>
        bool UpdatePasswordResetCode(int resetCode, long userId);

        /// <summary>
        /// Get user id by user details
        /// </summary>
        /// <param name="userDetail">The user details</param>
        /// <returns>The user id</returns>
        long GetUserIdByUserDetails(Person userDetail);

        /// <summary>
        /// Get User Name and Id by user details
        /// </summary>
        /// <param name="userDetail">The user details</param>
        /// <returns>user name and id</returns>
        dynamic GetUserNameAndIdByUserDetails(dynamic userDetail);

        /// <summary>
        /// Update the email id by user id
        /// </summary>
        /// <param name="email">The email id</param>
        /// <param name="userId">The user id</param>
        /// <returns>Return true if updated else false</returns>
        string UpdateEmailByUserId(string email, long userId);

        /// <summary>
        /// Reset the password by user details
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="password">The password</param>
        /// <param name="userId">The user id</param>
        /// <param name="salt">The salt</param>
        /// <returns>Returns email id if updated else empty email id</returns>
        string ResetPassword(string userName, string password, long userId, string salt);

        /// <summary>
        /// Validate the password reset code by user name.
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="passwordResetCode">The password reset code</param>
        /// <returns>The user id</returns>
        bool ValidateUserPasswordResetCode(long userId, long passwordResetCode);

        /// <summary>
        /// Validate the  UserID.
        /// </summary>
        /// <param name="userName">User ID.</param>
        /// <returns>
        /// The Status.
        /// </returns>
        bool ValidUserID(long userId);

        /// <summary>
        /// Get Security questions
        /// </summary>
        /// <returns>The Security Question</returns>
        Tuple<Dictionary<int, string>, int> GetSecurityQuestion(long userID = 0);

        /// <summary>
        /// Get security question by user id
        /// </summary>
        /// <param name="userId">The User ID</param>
        /// <returns>The Security Question</returns>
        KeyValuePair<int, string> GetSecurityQuestionByUserId(long userId);

        /// <summary>
        /// Get username and email by User id.
        /// </summary>
        /// <param name="user">The User Id</param>
        /// <returns>User detail</returns>
        dynamic GetUsernameAndEmailByUserId(long userId);

        /// <summary>
        ///Get User Details By User Id
        /// </summary>        
        /// <returns>User Details of A Particular Id</returns>
        User GetUserDetailsByUserId(long userId);

        /// <summary>
        ///Update User Details By User Id
        /// </summary>        
        /// <returns>Status</returns>
        long UpdateUserDetailsByUserId(User user);

        /// <summary>
        ///Validate User Password By UserId
        /// </summary>        
        /// <returns>User Details of A Particular Id</returns>
        User ValidateUserPasswordByUserId(long userId);

    }
}
