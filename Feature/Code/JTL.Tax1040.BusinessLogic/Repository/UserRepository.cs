/*
Copyright   : Copyright Jeevan Technologies
File Name   : UserRepository.cs 
Description : Business Logic for user. 
Author      : Balasubramanian Velmurugan Created Date : 03 Mar 2014

 * Modification History:
 * 17Mar2014 Bala Code modified to encrypt the ‘Security Answer’ field.  
 * 18Mar2014 Sathish code modfied to store user id and  quesiton id instead of name
 * 24Mar2014 Sathish Changed method name from GetUserNameAndPasswordByUserDetails to GetUserNameAndIdByUserDetails
 *  26Mar2014 Bala Changed method name from UpdatePasswordResetCodeBySecurityInfo to UpdatePasswordResetCodeBySecurityInfo and from ValidateUserByUserIdAndSecurityInfo to UpdatePasswordResetLinkBySecurityInfo
 *  Added new method UpdateEmailBySecurityInfo for updating user email
 *  27Mar2014 Sathish Added code to rename @@email and @@link to replace EMAIL Content.
 *  31Mar2014 Sathis Changed validatePasswordResetCode by user id instead of user Name and return true or false. 
 *      Add New method to Validate Security Info and Send mail 
 *      Changed Method name From UpdatePasswordResetLinkBySecurityInfo to UpdateUserNamePasswordResetCodeBySecurityInfo
 *      Get Login Link from Web Config
 *  31Mar2014 Bala Implemented Server side business validation for PreLogin. 
 *  16Apr2014 Sathish changed enum for email template
 *  23April2014 Thileepkumar Changed validatePassword by user id
 *  28April2014 Thileepkumar Changed updateuserdetailsbyuserid
 *  28April2014 Thileepkumar Changed validateuserpasswordbyuserid
 *  29April2014 Thileepkumar Changed updateuserdetailsbyuserid
 *  29April2014 Thileepkumar Changed validateuserpasswordbyuserid 
 *  30April2014 Thileepkumar Changed validateuserpasswordbyuserid
 *  07May2014 Removed commented code and refactored the code.
 *  09May2014 Thileepkumar changed PersistUser for email template
 *  07May2014 Bala Removed commented code and refactored the code.
 *  09May2014 Bala Method added to get email by UserId.
 *  14May2014 Thileepkumar  added exception handling messages for the methods.
 *  22May2014 Bala Modified code to move the Get IP address method to Utilities file. 
 *  16Jun2014 Thileep changed updatepasswordresetcode,updateusernamepasswordresetcodebysecurityinfo methods for email templates
 *  16Jun2014 Thileep Added password_reset_link variable  for email. 
 *  26Jun2014 Thileep changed ValidateUserPasswordByUserId method
 *  26Jun2014 Thileep changed UpdateUserDetailsByUserId method
 *  27Jun2014 Thileep changed RESET_CODE_MIN_SIZE to length of six.
 *  27Jun2014 Thileep changed RESET_CODE_Max_SIZE to length of six.
 *  11July2014 Thileep changed UpdateUserDetailsByUserId method
 *  15July2014 Thileep changed UpdateUserDetailsByUserId method
 *  
 *  
  
---------------------
 */



using System.Collections.Specialized;
using System.Configuration;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.DataAccess;
using System;
using System.Net;
using System.Security.Cryptography;
using JTL.Tax1040.BusinessObject;
using System.Collections.Generic;
using System.Dynamic;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Regarding  UserRepository :  Get (or) Update User
    /// </summary>
    public class UserRepository : IUserRepository
    {

        #region Login Link
        private readonly string loginLink = Utilities.GetAppSettingsValue(Constants.APP_SETTING_LOGIN_LINK);
        #endregion



        #region Email Template Images
        // private readonly string headerLink = ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_HEADER_LINK];
        //  private readonly string twitterLink = ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_TWITTER_LINK];
        //    private readonly string facebookLink = ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_FACEBOOK_LINK];
        //   private readonly string linkedinLink = ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_LINKEDIN_LINK];
        // private readonly string bbbLink = ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_BBB_LINK];
        private readonly string email_image_link = ConfigurationManager.AppSettings[Constants.Tax1040ImageUrl];
        private readonly string password_reset_link = ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_PASSWORD_RESET_URL];
        #endregion

        #region Email Template Password
        private readonly string password = ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_PASSWORD];
        #endregion

        #region Email Template SecurityAnswer
        private readonly string securityAnswer = ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_SECURITY_ANSWER];
        #endregion


        IUserDataService userDataService;
        private IEmailRepository emailRepository;

        #region Constants
        const int SALT_SIZE = 7;
        const int RESET_CODE_MIN_SIZE = 100000;
        const int RESET_CODE_MAX_SIZE = 999999;

        #endregion

        public UserRepository()
        {
            userDataService = new UserDataService();
            emailRepository = new EmailRepository();
        }

        #region User Registration

        /// <summary>
        /// Persists the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns></returns>
        public long PersistUser(User user, out StringCollection errorMessages)
        {
            errorMessages = new StringCollection();
            var userId = 0L;
            try
            {
                if (ValidateUserRegisteration(user, ref errorMessages))
                {
                    var salt = CreateSalt(SALT_SIZE);
                    user.Salt = salt;
                    var encryptedPassword = Utilities.EncryptMessage(user.Password, salt);
                    user.Password = encryptedPassword;
                    user.ClientIp = Utilities.GetIpAddress();
                    user.SecurityAnswer = Utilities.EncryptMessage(user.SecurityAnswer);
                    var registerDetail = userDataService.PersistUser(user);


                    if (registerDetail.IsEmailExist)
                    {
                        errorMessages.Add(LocalizedStrings.SIGNUP_EXISTING_EMAIL_V);
                    }

                    if (registerDetail.IsUserExist)
                    {
                        errorMessages.Add(LocalizedStrings.SIGNUP_EXISTING_USER_NAME_V);
                    }

                    userId = registerDetail.UserId;

                    if (userId > 0)
                    {
                        EmailData emailData = emailRepository.GetEmailTemplateById(EmailTemplate.SendUserRegistrationInfo);
                        if (emailData != null)
                        {
                            emailData.ToEmailID = user.Email;
                            emailData.Subject = "You have successfully created your Account";
                            //TODO : In Spec First Name or Nick name is mentioned
                            string emailContent = emailData.TemplateContent;
                            emailContent = emailContent.Replace(Constants.EMAIL_USER_NAME, user.UserName);
                            emailContent = emailContent.Replace(Constants.EMAIL_LOGIN_LINK, loginLink);
                            emailContent = emailContent.Replace(Constants.EMAIL_EMAIL_ID, user.Email);
                            emailContent = emailContent.Replace(Constants.EMAIL_PASSWORD, password);
                            emailContent = emailContent.Replace(Constants.EMAIL_SECURITY_QUESTION, user.SecurityQuestion);
                            emailContent = emailContent.Replace(Constants.EMAIL_SECURITY_ANSWER, securityAnswer);
                            emailContent = emailContent.Replace(Constants.EMAIL_IMAGE_LINK, email_image_link);
                            //  emailContent = emailContent.Replace(Constants.EMAIL_TWITTER_LINK, twitterLink);
                            //   emailContent = emailContent.Replace(Constants.EMAIL_IMAGE_LINK, facebookLink);
                            // emailContent = emailContent.Replace(Constants.EMAIL_LINKEDIN_LINK, linkedinLink);
                            //   emailContent = emailContent.Replace(Constants.EMAIL_IMAGE_LINK, bbbLink);
                            //  emailContent = emailContent.Replace(Constants.EMAIL_IRS_GOVT_EFILE_LINK, irsGovtEfileLink);

                            emailData.TemplateContent = emailContent;
                            Utilities.SendMail(emailData);
                        }
                    }

                    else
                    {
                        userId = 0L;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:PersistUser", ex);

            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = userId > 0
                ? "Created account successfully " + userId + " ClassName: {0}, Method Name: {1}"
                : "Issues in Creating new account " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_UP);


            return userId;
        }

        #endregion

        #region User Sign-In

        /// <summary>
        /// User sign-in.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// The User id.
        /// </returns>
        public long SignInUser(string userName, string password)
        {
            var errorMessages = new StringCollection();
            var userId = 0L;
            try
            {
                if (ValidateUserSignIn(userName, password, ref errorMessages))
                {
                    var userDetails = userDataService.SignInUser(userName);
                    if (userDetails.UserId > 0)
                    {
                        var salt = userDetails.Salt;
                        userId = userDetails.UserId;
                        var encryptedPassword = Utilities.EncryptMessage(password, salt);
                        if (encryptedPassword != userDetails.Password)
                        {
                            userId = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:SignInUser", ex);

            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = userId > 0
                ? "User logged in " + userId + " ClassName: {0}, Method Name: {1}"
                : "Invalid credentials " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN);
            return userId;
        }


        public long ValidateUserPassword(string userName, string password, out StringCollection errorMessages)
        {
            errorMessages = new StringCollection();
            var userId = 0L;
            try
            {
                if (ValidateUserSignIn(userName, password, ref errorMessages))
                {
                    var userDetails = userDataService.SignInUser(userName);
                    if (userDetails.UserId > 0)
                    {
                        var salt = userDetails.Salt;
                        userId = userDetails.UserId;
                        var encryptedPassword = Utilities.EncryptMessage(password, salt);
                        if (encryptedPassword != userDetails.Password)
                        {
                            userId = 0;
                            errorMessages.Add(LocalizedStrings.SIGNIN_INVALID_USER_NAME_PASSWORD_V);
                        }
                    }
                    else
                    {
                        errorMessages.Add(LocalizedStrings.SIGNIN_INVALID_USER_NAME_PASSWORD_V);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:ValidateUserPassword", ex);

            }
            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = userId > 0
                ? "Validated User password " + userId + " ClassName: {0}, Method Name: {1}"
                : LocalizedStrings.SIGNIN_INVALID_USER_NAME_PASSWORD_V + " " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN);

            return userId;
        }


        #endregion

        #region Update User Detail

        /// <summary>
        /// Update the email by user id.
        /// </summary>
        /// <param name="email">The Email.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns>
        /// status
        /// </returns>
        public bool UpdateEmailByUserId(string email, long userId, out StringCollection errorMessages)
        {
            var status = false;
            errorMessages = new StringCollection();
            try
            {
                if (ValidateEmailId(email, ref errorMessages))
                {
                    var userName = userDataService.UpdateEmailByUserId(email, userId);

                    status = !string.IsNullOrEmpty(userName);

                    if (status)
                    {
                        var emailData = emailRepository.GetEmailTemplateById(EmailTemplate.SendUpdateEmail);
                        if (emailData != null)
                        {
                            emailData.ToEmailID = email;
                            emailData.Subject = "You have Successfully Updated your Email Address";
                            //TODO : In Spec First Name or Nick name is mentioned
                            string emailContent = emailData.TemplateContent;
                            emailContent = emailContent.Replace(Constants.EMAIL_USER_NAME, userName);
                            emailContent = emailContent.Replace(Constants.EMAIL_EMAIL_ID, email);
                            emailContent = emailContent.Replace(Constants.EMAIL_IMAGE_LINK, email_image_link);
                            emailContent = emailContent.Replace(Constants.EMAIL_LOGIN_LINK, loginLink);
                            emailData.TemplateContent = emailContent;
                            Utilities.SendMail(emailData);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:UpdateEmailByUserId", ex);

            }
            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Updated Email address for " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_ACCOUNT_SETTINGS, Constants.TOPIC_UPDATE_EMAIL);
            return status;
        }

        /// <summary>
        /// Reset the user password.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The pass word.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns>
        /// Status
        /// </returns>
        public bool ResetPassword(string userName, string password, long userId, out StringCollection errorMessages)
        {
            var status = false;
            errorMessages = new StringCollection();
            try
            {
                if (ValidateUserSignInIssue(userName, password, userId, ref errorMessages))
                {
                    var salt = CreateSalt(SALT_SIZE);
                    var encryptedPassword = Utilities.EncryptMessage(password, salt);

                    var email = userDataService.ResetPassword(userName, encryptedPassword, userId, salt);

                    status = !string.IsNullOrEmpty(email);

                    if (!string.IsNullOrEmpty(email))
                    {
                        var emailData = emailRepository.GetEmailTemplateById(EmailTemplate.SendPasswordResetInfo);
                        if (emailData != null)
                        {
                            emailData.ToEmailID = email;
                            emailData.Subject = "You have successfully reset your password";
                            //TODO : In Spec First Name or Nick name is mentioned
                            string emailContent = emailData.TemplateContent;
                            emailContent = emailContent.Replace(Constants.EMAIL_USER_NAME, userName);
                            emailContent = emailContent.Replace(Constants.EMAIL_LOGIN_LINK, loginLink);
                            emailContent = emailContent.Replace(Constants.EMAIL_IMAGE_LINK, email_image_link);
                            emailData.TemplateContent = emailContent;
                            Utilities.SendMail(emailData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:ResetPassword", ex);
            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Reset password for " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);
            return status;

        }


        #endregion

        #region Update Password Reset Link
        /// <summary>
        /// Update password reset link by security info
        /// </summary>
        /// <param name="userId">The User ID</param>
        /// <param name="securityQuestionId">The Security Question ID</param>
        /// <param name="securityAnswer">The Security Question Answer</param>
        /// <returns>
        /// Status
        /// </returns>
        public bool UpdateUserNamePasswordResetCodeBySecurityInfo(long userId, int securityQuestionId, string securityAnswer)
        {
            var errorMessages = new StringCollection();
            var status = false;
            try
            {
                if (ValidateSecurityInformation(securityQuestionId, securityAnswer, ref errorMessages))
                {
                    status = ValidateSecurityInfoAndSendEmail(userId, securityQuestionId, securityAnswer,
                         EmailTemplate.SendUserNameAndPasswordReset);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:UpdateUserNamePasswordResetCodeBySecurityInfo", ex);

            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Update username,password reset code by securityinfo for " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);

            return status;
        }
        #endregion

        #region Update Password Reset Code

        /// <summary>
        /// Update Password Reset Code
        /// </summary>
        /// <param name="userId">The User ID</param>
        /// <param name="securityQuestionId">The Security Question ID</param>
        /// <param name="securityAnswer">The security answer.</param>
        /// <returns>
        /// status
        /// </returns>
        public bool UpdatePasswordResetCodeBySecurityInfo(long userId, int securityQuestionId, string securityAnswer)
        {
            var errorMessages = new StringCollection();
            var status = false;
            try
            {
                if (ValidateSecurityInformation(securityQuestionId, securityAnswer, ref errorMessages))
                {
                    status = ValidateSecurityInfoAndSendEmail(userId, securityQuestionId, securityAnswer,
                        EmailTemplate.SendPasswordResetCode);

                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:UpdatePasswordResetCodeBySecurityInfo", ex);

            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Update password reset code by securityinfo for " + userId +
                              " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);

            return status;
        }

        #endregion

        #region Update Email
        /// <summary>
        /// Update Email by security info
        /// </summary>
        /// <param name="userId">The User ID</param>
        /// <param name="securityQuestionId">The Security Question ID</param>
        /// <param name="securityAnswer">The Security Question Answer</param>
        /// <returns>
        /// User details.
        /// </returns>
        public long UpdateEmailBySecurityInfo(long userId, int securityQuestionId, string securityAnswer)
        {
            dynamic userDetail;
            var id = 0L;
            try
            {
                var errorMessages = new StringCollection();

                securityAnswer = Utilities.EncryptMessage(securityAnswer);

                if (ValidateSecurityInformation(securityQuestionId, securityAnswer, ref errorMessages))
                {
                    userDetail = userDataService.GetUserNameAndEmailByUserIdAndSecurityInfo(userId, securityQuestionId, securityAnswer);

                    if (userDetail.UserName != string.Empty)
                    {
                        id = userId;
                    }

                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:UpdateEmailBySecurityInfo", ex);

            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Update email by securityinfo for " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);

            return id;
        }
        #endregion


        #region Validate password reset code

        /// <summary>
        /// Validate the password reset code.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="passwordResetCode">The password reset code.</param>
        /// <returns>
        /// The Status.
        /// </returns>
        public bool ValidateUserPasswordResetCode(long userId, int passwordResetCode)
        {
            bool isValidPasswordResetCode = false;
            try
            {
                isValidPasswordResetCode = userDataService.ValidateUserPasswordResetCode(userId, passwordResetCode);

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:ValidateUserPasswordResetCode", ex);

            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Validate User password reset code for " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN);

            return isValidPasswordResetCode;
        }


        #endregion

        #region Validate UserID
        /// <summary>
        /// Validate the  UserID.
        /// </summary>
        /// <param name="userName">User ID.</param>
        /// <returns>
        /// The Status.
        /// </returns>
        public bool ValidUserID(long userId)
        {
            bool isValidUserID = false;
            try
            {
                isValidUserID = userDataService.ValidUserID(userId);

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:ValidUserID", ex);

            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Validate User id " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN);

            return isValidUserID;
        }


        #endregion

        #region Get User Detail

        /// <summary>
        /// Get the user id by user details.
        /// </summary>
        /// <param name="userDetail">The user detail.</param>
        /// <returns>
        /// user id.
        /// </returns>
        public long GetUserIdByUserDetails(Person userDetail)
        {
            var userId = 0L;

            try
            {
                userId = userDataService.GetUserIdByUserDetails(userDetail);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:GetUserIdByUserDetails", ex);
            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Get user id by details for " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);

            return userId;
        }


        /// <summary>
        /// Get the user name by user details.
        /// </summary>
        /// <param name="userDetail">The user detail.</param>
        /// <returns>
        /// user name.
        /// </returns>
        public long GetUserNameAndIdByUserDetails(dynamic userDetail)
        {
            dynamic user = new ExpandoObject();

            try
            {
                user = userDataService.GetUserNameAndIdByUserDetails(userDetail);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(Utilities.ConvertToLong(user.UserId.Value), "Class:UserRepository,Method Name:GetUserNameAndIdByUserDetails", ex);
            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Get User name and id by userdetails for " + user.userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(user.userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);

            return user.UserId;
        }

        /// <summary>
        /// Gets the user name by email.
        /// </summary>
        /// <param name="emailId">The email id.</param>
        /// <returns>
        /// The user name.
        /// </returns>
        public string GetUserNameByEmail(string emailId)
        {
            var userName = string.Empty;
            try
            {
                userName = userDataService.GetUserNameByEmail(emailId);

                if (string.IsNullOrEmpty(userName))
                {
                    // TODO : Have to send error message which denotes Email is invalid.
                }
                else
                {
                    IEmailRepository emailRepository = new EmailRepository();
                    EmailData emailData = emailRepository.GetEmailTemplateById(EmailTemplate.SendUserName);
                    if (emailData != null)
                    {
                        emailData.ToEmailID = emailId;
                        emailData.Subject = "Sub: Tax Garden Username Reset";

                        string emailContent = emailData.TemplateContent;
                        emailContent = emailContent.Replace(Constants.EMAIL_USER_NAME, userName);
                        emailContent = emailContent.Replace(Constants.EMAIL_LOGIN_LINK, loginLink);
                        emailContent = emailContent.Replace(Constants.EMAIL_IMAGE_LINK, email_image_link);
                        emailData.TemplateContent = emailContent;
                        Utilities.SendMail(emailData);
                    }

                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(0, "Class:UserRepository,Method Name:GetUserNameByEmail", ex);

            }
            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Get user name by Email id for " + userName + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(0, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);
            return userName;
        }


        /// <summary>
        /// Gets user id by Username to check user exist.
        /// </summary>
        /// <param name="userName">The User name.</param>
        /// <returns>
        /// User id.
        /// </returns>
        public long GetUserIdByUserName(string userName)
        {
            var userId = 0L;
            try
            {
                userId = userDataService.GetUserIdByUserName(userName);

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:GetUserIdByUserName", ex);

            }
            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Get user id by user name for " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);
            return userId;
        }

        /// <summary>
        /// Get Security questions
        /// </summary>
        /// <returns>
        /// The Security Question
        /// </returns>
        /// 
        public Tuple<Dictionary<int, string>, int> GetSecurityQuestion(long userID = 0)
        {
            try
            {
                return userDataService.GetSecurityQuestion(userID);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(0, "Class:UserRepository,Method Name:GetSecurityQuestion", ex);
            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Get security question for " + userID + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userID, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);

            return new Tuple<Dictionary<int, string>, int>(null, 0);
        }

        /// <summary>
        /// Get security question by user id
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <returns>
        /// The Security Question
        /// </returns>
        public KeyValuePair<int, string> GetSecurityQuestionByUserId(long userId)
        {
            var getSecurityQuestionByUserId = new KeyValuePair<int, string>();
            try
            {
                getSecurityQuestionByUserId = userDataService.GetSecurityQuestionByUserId(userId);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:GetSecurityQuestionByUserId", ex);
            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Get security question by userid " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);

            return getSecurityQuestionByUserId;
        }


        /// <summary>
        /// Resend the email by User id.
        /// </summary>
        /// <param name="user">The User Id</param>
        /// <param name="emailTemplateId">The EmailTemplate Id</param>
        /// <returns>Status</returns>
        public bool ResendEmailByUserId(long userId, EmailTemplate emailTemplateId)
        {
            var status = false;
            try
            {
                dynamic userDetails = userDataService.GetUsernameAndEmailByUserId(userId);

                if (userDetails.UserName != string.Empty)
                {
                    var resetCode = CreateResetCode();
                    status = userDataService.UpdatePasswordResetCode(resetCode, userId);

                    if (status)
                    {
                        //send the reset code To the user Email Id. userDetails.Email
                        //status = true, if mail send successfully then send the success status to UI.
                        IEmailRepository emailRepository = new EmailRepository();
                        EmailData emailData = emailRepository.GetEmailTemplateById(emailTemplateId);
                        if (emailData != null)
                        {
                            emailData.ToEmailID = userDetails.Email;
                            if (emailTemplateId == EmailTemplate.SendPasswordResetCode)
                                emailData.Subject = "Sub: Tax Garden Password Reset";
                            else if (emailTemplateId == EmailTemplate.SendUserNameAndPasswordReset)
                                emailData.Subject = "Sub: Tax Garden Username & Password Reset";

                            string emailContent = emailData.TemplateContent;
                            emailContent = emailContent.Replace(Constants.EMAIL_USER_NAME, userDetails.UserName);
                            emailContent = emailContent.Replace(Constants.EMAIL_RESET_CODE, resetCode.ToString());
                            emailContent = emailContent.Replace(Constants.EMAIL_LOGIN_LINK, loginLink);
                            emailContent = emailContent.Replace(Constants.EMAIL_IMAGE_LINK, email_image_link);
                            emailContent = emailContent.Replace(Constants.EMAIL_PASSWORD_RESET_LINK, password_reset_link);
                            emailData.TemplateContent = emailContent;
                            status = Utilities.SendMail(emailData);
                        }
                        else
                            status = false;
                    }

                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:ResendEmailByUserId", ex);
            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Resend email by userid " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);

            return status;
        }

        /// <summary>
        /// Resend the email for forgot username.
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="email">The Email id</param>
        /// <returns>Status</returns>
        public bool ResendEmailForForgotUserName(string userName, string email)
        {
            var status = false;
            try
            {
                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(email))
                {
                    //send the reset code To the user Email Id. userDetails.Email
                    //status = true, if mail send successfully then send the success status to UI.
                    IEmailRepository emailRepository = new EmailRepository();
                    EmailData emailData = emailRepository.GetEmailTemplateById(EmailTemplate.SendUserName);
                    if (emailData != null)
                    {
                        emailData.ToEmailID = email;
                        emailData.Subject = "Sub: Tax Garden Username Reset";

                        string emailContent = emailData.TemplateContent;
                        emailContent = emailContent.Replace(Constants.EMAIL_USER_NAME, userName);
                        emailContent = emailContent.Replace(Constants.EMAIL_LOGIN_LINK, loginLink);
                        emailContent = emailContent.Replace(Constants.EMAIL_IMAGE_LINK, email_image_link);
                        emailData.TemplateContent = emailContent;
                        status = Utilities.SendMail(emailData);
                    }
                    else
                        status = false;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(0, "Class:UserRepository,Method Name:ResendEmailForForgotUserName", ex);

            }
            
            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Resend email for Forgot the UserName " + userName + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(0, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);

            return status;
        }


        /// <summary>
        /// Get email by User id.
        /// </summary>
        /// <param name="user">The User Id</param>
        /// <returns>Email</returns>
        public string GetEmailByUserId(long userId)
        {
            dynamic userDetails = new ExpandoObject();
            try
            {
                userDetails = userDataService.GetUsernameAndEmailByUserId(userId);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:ResendEmailForForgotUserName", ex);

            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Get email by userid " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_PRE_LOGIN, Constants.TOPIC_SIGN_IN_ISSUE);

            return userDetails.Email;
        }

        #endregion


        #region Manage Account

        /// <summary>
        ///Get User Details By User Id
        /// </summary>        
        /// <returns>User Details of A Particular Id</returns>
        public User GetUserDetailsByUserId(long userId)
        {
            User user = new User();

            try
            {
                user = userDataService.GetUserDetailsByUserId(userId);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:GetUserDetailsByUserId", ex);
            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Get User details by userid " + userId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, 0, description, this.GetType().Name, Constants.Tab_ACCOUNT_SETTINGS, Constants.TOPIC_UPDATE_USERINFO);

            return user;
        }

        /// <summary>
        ///Update User Details By User Id
        /// </summary>        
        /// <returns>Tuple</returns>
        public System.Tuple<long, StringCollection> UpdateUserDetailsByUserId(User user)
        {
            long userDetailsId = 0;
            string userName = "";
            string passWord = "";
            StringCollection errorMessages = new StringCollection();
            try
            {
                var userDetails = GetUserDetailsByUserId(user.UserId);
                if (!Utilities.IsStringEmpty(user.NewPassword))
                {
                    userName = userDetails.UserName;
                    passWord = user.NewPassword;
                    if (userName.ToLower() == passWord.ToLower())
                    {
                        userDetailsId = 3;
                        errorMessages.Add(LocalizedStrings.SIGNUP_USER_NAME_AND_PASSWORD_SAME_V);
                    }
                    else
                    {
                        var encryptedPassword = Utilities.EncryptMessage(user.NewPassword, userDetails.Salt);
                        user.Password = encryptedPassword;
                        user.Salt = userDetails.Salt;
                        userDetailsId = userDataService.UpdateUserDetailsByUserId(user);
                        if (userDetailsId == 2)
                        {
                            errorMessages.Add(LocalizedStrings.SIGNUP_EXISTING_USER_NAME_V);
                        }
                        if (userDetailsId == 1)
                        {
                            errorMessages.Add(LocalizedStrings.SIGNUP_EXISTING_EMAIL_V);
                        }
                    }
                }
                else if (!Utilities.IsStringEmpty(user.SecurityAnswer))
                {
                    var encryptedSecurityAnswer = Utilities.EncryptMessage(user.SecurityAnswer);
                    user.SecurityAnswer = encryptedSecurityAnswer;
                    user.Password = string.Empty;
                    userDetailsId = userDataService.UpdateUserDetailsByUserId(user);

                }
                else
                {
                    userName = user.UserName;
                    passWord = user.Password;
                    if (!Utilities.IsStringEmpty(userName))
                    {
                        if (userName.ToLower() == passWord.ToLower())
                        {
                            userDetailsId = 3;
                            errorMessages.Add(LocalizedStrings.SIGNUP_USER_NAME_AND_PASSWORD_SAME_V);

                        }
                        else
                        {
                            user.Password = string.Empty;
                            userDetailsId = userDataService.UpdateUserDetailsByUserId(user);
                            if (userDetailsId == 2)
                            {
                                errorMessages.Add(LocalizedStrings.SIGNUP_EXISTING_USER_NAME_V);
                            }
                            else if (userDetailsId == 1)
                            {
                                errorMessages.Add(LocalizedStrings.SIGNUP_EXISTING_EMAIL_V);
                            }
                        }
                    }
                    else
                    {
                        user.Password = string.Empty;
                        userDetailsId = userDataService.UpdateUserDetailsByUserId(user);
                        if (userDetailsId == 2)
                        {
                            errorMessages.Add(LocalizedStrings.SIGNUP_EXISTING_USER_NAME_V);
                        }
                        else if (userDetailsId == 1)
                        {
                            errorMessages.Add(LocalizedStrings.SIGNUP_EXISTING_EMAIL_V);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(user.UserId, "Class:UserRepository,Method Name:UpdateUserDetailsByUserId", ex);

            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Update user details by userid " + user.UserId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(user.UserId, 0, description, this.GetType().Name, Constants.Tab_ACCOUNT_SETTINGS, Constants.TOPIC_UPDATE_USERINFO);

            return new System.Tuple<long, StringCollection>(userDetailsId, errorMessages);


        }

        /// <summary>
        ///Validate User Password by UserId
        /// </summary>        
        /// <returns>Tuple</returns>
        public System.Tuple<long, StringCollection> ValidateUserPasswordByUserId(User user)
        {
            StringCollection errorMessages = new StringCollection();
            long userDetailsId = 0;
            System.Tuple<long, StringCollection> userDetailsList = new Tuple<long, StringCollection>(userDetailsId, errorMessages);

            try
            {
                var userDetails = userDataService.ValidateUserPasswordByUserId(user.UserId);
                if (userDetails.UserId > 0)
                {
                    var encryptedPassword = Utilities.EncryptMessage(user.Password, userDetails.Salt);
                    if (encryptedPassword != userDetails.Password)
                    {
                        userDetailsId = 4;
                        errorMessages.Add(LocalizedStrings.SIGNUP_INVALID_PASSWORD_V);
                        //For invalid password
                    }
                    else
                    {
                        userDetailsList = UpdateUserDetailsByUserId(user);
                        userDetailsId = userDetailsList.Item1;
                        errorMessages = userDetailsList.Item2;
                    }
                }

                else
                {
                    userDetailsId = 3;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(user.UserId, "Class:UserRepository,Method Name:ValidateUserPasswordByUserId", ex);

            }

            //02 Sep 2014 Bhavani Audit functionality Implementation
            var description = "Validate User password by userid " + user.UserId + " ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(user.UserId, 0, description, this.GetType().Name, Constants.Tab_ACCOUNT_SETTINGS, Constants.Tab_ACCOUNT_SETTINGS);

            return new System.Tuple<long, StringCollection>(userDetailsId, errorMessages);

        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Creates the salt.
        /// </summary>
        /// <param name="size">Size of the salt.</param>
        /// <returns>The salt.</returns>
        private string CreateSalt(int size)
        {
            var rngCryptoService = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rngCryptoService.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        /// <summary>
        /// Create Reset Code
        /// </summary>
        /// <returns>The random number</returns>
        private int CreateResetCode()
        {
            return Utilities.CreateRandomNumber(RESET_CODE_MIN_SIZE, RESET_CODE_MAX_SIZE);
        }

        #region Validation

        private bool ValidateUserRegisteration(User user, ref StringCollection errorMessages)
        {
            errorMessages = errorMessages ?? new StringCollection();
            if (user != null)
            {
                ValidateUserName(user.UserName, user.Email, ref errorMessages);
                ValidatePassword(user.UserName, user.Password, ref errorMessages);
                ValidateEmailId(user.Email, ref errorMessages);
                ValidateSecurityInformation(user.SecurityQuestionId, user.SecurityAnswer, ref errorMessages);
            }

            return (errorMessages.Count == 0);
        }

        private bool ValidateUserSignIn(string userName, string password, ref StringCollection errorMessages)
        {
            var status = true;
            if (string.IsNullOrEmpty(userName))
            {
                errorMessages.Add(LocalizedStrings.SIGNIN_MISSING_USER_NAME_RF);
                status = false;
            }

            if (string.IsNullOrEmpty(password))
            {
                errorMessages.Add(LocalizedStrings.SIGNIN_MISSING_PASSWORD_RF);
                status = false;
            }

            return status;
        }

        private bool ValidateEmailId(string email, ref StringCollection errorMessages)
        {
            errorMessages = errorMessages ?? new StringCollection();

            if (string.IsNullOrEmpty(email))
            {
                errorMessages.Add(LocalizedStrings.SIGNUP_MISSING_EMAIL_RF);
            }
            else if (!Utilities.IsValidEmail(email))
            {
                errorMessages.Add(LocalizedStrings.SIGNUP_INVALID_EMAIL_V);
            }

            return (errorMessages.Count == 0);
        }

        private bool ValidateUserName(string userName, string email, ref StringCollection errorMessages)
        {

            errorMessages = errorMessages ?? new StringCollection();
            if (string.IsNullOrEmpty(userName))
            {
                errorMessages.Add(LocalizedStrings.SIGNUP_MISSING_USER_NAME_RF);

            }
            else if (userName != email && !Utilities.IsValidRegexPattern(userName, @"^\w{6,64}$"))
            {
                errorMessages.Add(LocalizedStrings.SIGNUP_INVALID_USER_NAME_V);
            }

            return (errorMessages.Count == 0);
        }

        private bool ValidatePassword(string userName, string password, ref StringCollection errorMessages)
        {
            errorMessages = errorMessages ?? new StringCollection();

            if (string.IsNullOrEmpty(password))
            {
                errorMessages.Add(LocalizedStrings.SIGNUP_MISSING_PASSWORD_V);
            }
            else if (userName.ToLower() == password.ToLower())
            {
                errorMessages.Add(LocalizedStrings.SIGNUP_USER_NAME_AND_PASSWORD_SAME_V);
            }
            else if (!Utilities.IsValidRegexPattern(password, @"^(?=(.*\d){1,1})(?=.*[a-zA-Z])(?=.*[!@#$%*_~-]{1,1})[0-9a-zA-Z!@#$%*_~-]{8,15}"))
            {
                errorMessages.Add(LocalizedStrings.SIGNUP_INVALID_PASSWORD_V);
            }

            return (errorMessages.Count == 0);
        }

        private bool ValidateUserSignInIssue(string userName, string password, long userId, ref StringCollection errorMessages)
        {
            errorMessages = errorMessages ?? new StringCollection();
            if (string.IsNullOrEmpty(userName))
            {
                errorMessages.Add(LocalizedStrings.SIGNIN_MISSING_USER_NAME_RF);
            }
            else if (!Utilities.IsValidRegexPattern(userName, @"^\w{6,64}$"))
            {
                errorMessages.Add(LocalizedStrings.SIGNUP_INVALID_USER_NAME_V);
            }
            else 
            {
                var userDetail = GetUserDetailsByUserId(userId);
                
                if (userDetail == null || userName != userDetail.UserName)
                {
                    errorMessages.Add(LocalizedStrings.SIGNINISSUE_INVALID_USER_NAME_V);
                }
            }

            ValidatePassword(userName, password, ref errorMessages);

            return (errorMessages.Count == 0);
        }

        private bool ValidateSecurityInformation(int securityQuestionId, string securityAnswer, ref StringCollection errorMessages)
        {
            errorMessages = errorMessages ?? new StringCollection();
            if (securityQuestionId <= 0)
            {
                errorMessages.Add(LocalizedStrings.SIGNUP_MISSING_SECURITY_QUESTION_RF);
            }

            if (string.IsNullOrEmpty(securityAnswer))
            {
                errorMessages.Add(LocalizedStrings.SIGNUP_MISSING_SECURITY_ANSWER_RF);
            }

            return (errorMessages.Count == 0);
        }

        #endregion


        /// <summary>
        /// Validate Security Info and Send Email
        /// </summary>
        /// <param name="userId">The User ID</param>
        /// <param name="securityQuestionId">The Security Question ID</param>
        /// <param name="securityAnswer">The security answer.</param>
        /// <param name="emailTemplate">The Email Template</param>
        /// <returns>the Status</returns>
        private bool ValidateSecurityInfoAndSendEmail(long userId, int securityQuestionId, string securityAnswer,
                                                            EmailTemplate emailTemplate)
        {
            dynamic userDetails;
            var status = false;
            try
            {
                securityAnswer = Utilities.EncryptMessage(securityAnswer);
                userDetails = userDataService.GetUserNameAndEmailByUserIdAndSecurityInfo(userId, securityQuestionId, securityAnswer);

                if (userDetails.UserName != string.Empty)
                {
                    var resetCode = CreateResetCode();
                    status = userDataService.UpdatePasswordResetCode(resetCode, userId);

                    if (status)
                    {
                        //TODO : Have to send the reset code To the user Email Id. userDetails.Email
                        //status = true, if mail send successfully then Have to send the success status to UI.
                        IEmailRepository emailRepository = new EmailRepository();
                        EmailData emailData = emailRepository.GetEmailTemplateById(emailTemplate);
                        if (emailData != null)
                        {
                            emailData.ToEmailID = userDetails.Email;
                            if (emailTemplate == EmailTemplate.SendPasswordResetCode)
                                emailData.Subject = "Sub: Tax Garden Password Reset";
                            else if (emailTemplate == EmailTemplate.SendUserNameAndPasswordReset)
                                emailData.Subject = "Sub: Tax Garden Username & Password Reset";
                            //TODO : In Spec First Name or Nick name is mentioned
                            string emailContent = emailData.TemplateContent;
                            emailContent = emailContent.Replace(Constants.EMAIL_USER_NAME, userDetails.UserName);
                            emailContent = emailContent.Replace(Constants.EMAIL_RESET_CODE, resetCode.ToString());
                            emailContent = emailContent.Replace(Constants.EMAIL_IMAGE_LINK, email_image_link);
                            emailContent = emailContent.Replace(Constants.EMAIL_PASSWORD_RESET_LINK, password_reset_link);
                            emailData.TemplateContent = emailContent;
                            Utilities.SendMail(emailData);
                        }
                    }

                }
                else
                {
                    //TODO : Have to throw Error Messages.
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UserRepository,Method Name:ValidateSecurityInfoAndSendEmail", ex);

            }

            return status;
        }

        #endregion

    }
}
