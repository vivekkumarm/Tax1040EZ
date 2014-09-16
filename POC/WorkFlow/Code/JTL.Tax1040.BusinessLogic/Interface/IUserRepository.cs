/*
Copyright   : Copyright Jeevan Technologies
File Name   : IUserRepository.cs 
Description : Business Logic Interface for user. 
Author      : Balasubramanian Velmurugan Created Date : 03 Mar 2014

 * Modification History:
---------------------
 * 18Mar2014 Sathish code modfied to store user id and  quesiton id instead of name
 * 24Mar2014 Sathish Changed method name from GetUserNameAndPasswordByUserDetails to GetUserNameAndIdByUserDetails
*  26Mar2014 Bala Changed method name from UpdatePasswordResetCodeBySecurityInfo to UpdatePasswordResetCodeBySecurityInfo and from ValidateUserByUserIdAndSecurityInfo to UpdatePasswordResetLinkBySecurityInfo
 *  Added new method UpdateEmailBySecurityInfo for updating user email
 *  31Mar2014 Sathis Changed validatePasswordResetCode by user id instead of user Name and return true or false
 *          Changed Method name From UpdatePasswordResetLinkBySecurityInfo to UpdateUserNamePasswordResetCodeBySecurityInfo
 *  31Mar2014 Bala Implemented Server side business validation for PreLogin.
 *  23April2014 Thileepkumar Changed validatePassword by user id
 *  28April2014 Thileepkumar Changed updateuserdetailsbyuserid
 *  28April2014 Thileepkumar Changed validateuserpasswordbyuserid
 *  30April2014 Thileepkumar Changed validateuserpasswordbyuserid
 *  09May2014 Bala Method added to get email by UserId.
 *  
 */

using System.Collections.Specialized;
using JTL.Tax1040.BusinessObject;
using System.Collections.Generic;
using JTL.Tax1040.Core.Object;


namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Regarding IUserRepository : Methods need to be implemented in User Repository
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Gets the user name by email.
        /// </summary>
        /// <param name="emailId">The email id.</param>
        /// <returns>The user name.</returns>
        string GetUserNameByEmail(string emailId);

        /// <summary>
        /// Get email by User id.
        /// </summary>
        /// <param name="user">The User Id</param>
        /// <returns>Email</returns>
       string GetEmailByUserId(long userId);

        /// <summary>
        /// User sign-in.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password.</param>
        /// <returns>The User id.</returns>
        long SignInUser(string userName, string password);

        /// <summary>
        /// Creates the new user.
        /// </summary>
        /// <param name="user">The new user detail.</param>
        /// <param name="errorMessages">The error message collections</param>
        /// <returns>The user id.</returns>
        long PersistUser(User userDetail, out StringCollection errorMessages);

        /// <summary>
        ///  Gets user id by Username to check user exist.
        /// </summary>
        /// <param name="userName">The User name.</param>
        /// <returns>User id.</returns>
        long GetUserIdByUserName(string userName);

        /// <summary>
        /// Update the email by user id.
        /// </summary>
        /// <param name="email">The Email.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns>
        /// status
        /// </returns>
        bool UpdateEmailByUserId(string email, long userId, out StringCollection errorMessages);

        /// <summary>
        ///  Update Password Reset Code
        /// </summary>
        /// <param name="userName">The user ID.</param>
        /// <param name="securityQuestion">The security question.</param>
        /// <param name="securityAnswer">The security answer.</param>
        /// <returns>status</returns>
        bool UpdatePasswordResetCodeBySecurityInfo(long userId, int securityQuestionId, string securityAnswer);

        /// <summary>
        /// Validate the  UserID.
        /// </summary>
        /// <param name="userName">User ID.</param>
        /// <returns>
        /// The Status.
        /// </returns>
        bool ValidUserID(long userId);

        /// <summary>
        /// Update password reset link by security info
        /// </summary>
        /// <param name="userId">The User ID</param>
        /// <param name="securityQuestionId">The Security Question ID</param>
        /// <param name="securityAnswer">The Security Question Answer</param>
        /// <returns>
        /// Status
        /// </returns>
        bool UpdateUserNamePasswordResetCodeBySecurityInfo(long userId, int securityQuestionId, string securityAnswer);

        /// <summary>
        /// Update Email by security info
        /// </summary>
        /// <param name="userId">The User ID</param>
        /// <param name="securityQuestionId">The Security Question ID</param>
        /// <param name="securityAnswer">The Security Question Answer</param>
        /// <returns>
        /// User details.
        /// </returns>
        long UpdateEmailBySecurityInfo(long userId, int securityQuestionId, string securityAnswer);

        /// <summary>
        /// Reset the user password.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The pass word.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns>Status</returns>
        bool ResetPassword(string userName, string password, long userId, out StringCollection errorMessages);

        /// <summary>
        /// Validate the password reset code.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="passwordResetCode">The password reset code.</param>
        /// <returns>The Status</returns>
        bool ValidateUserPasswordResetCode(long userId, int passwordResetCode);

        /// <summary>
        /// Get the user id by user details.
        /// </summary>
        /// <param name="userDetail">The user detail.</param>
        /// <returns>user id.</returns>
        long GetUserIdByUserDetails(Person userDetail);

        /// <summary>
        /// Get the user name by user details.
        /// </summary>
        /// <param name="userDetail">The user detail.</param>
        /// <returns>user name.</returns>
        long GetUserNameAndIdByUserDetails(dynamic userDetail);


        /// <summary>
        /// Get Security questions
        /// </summary>
        /// <returns>The Security Question</returns>
        Dictionary<int, string> GetSecurityQuestion();

        /// <summary>
        /// Get security question by user id
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <returns>The Security Question</returns>
        KeyValuePair<int, string> GetSecurityQuestionByUserId(long userId);

        /// <summary>
        /// Resend the email by User id.
        /// </summary>
        /// <param name="user">The User Id</param>
        /// <param name="emailTemplateId">The EmailTemplate Id</param>
        /// <returns>Status</returns>
        bool ResendEmailByUserId(long userId, EmailTemplate emailTemplateId);

        /// <summary>
        /// Resend the email for forgot username.
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="email">The Email id</param>
        /// <returns>Status</returns>
        bool ResendEmailForForgotUserName(string userName, string email);


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
        ///Validate User Password by User Id
        /// </summary>        
        /// <returns>long</returns>
        long ValidateUserPasswordByUserId(User user);

        
    }
}
