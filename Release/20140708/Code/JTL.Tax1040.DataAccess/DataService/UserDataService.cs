/*
Copyright   : Copyright Jeevan Technologies
File Name   : UserDataService.cs 
Description : Data Service for user. 
Author      : Balasubramanian Velmurugan Created Date : 03 Mar 2014

 * Modification History:
---------------------
 * 18Mar14 Sathish Code Changed to check user by question id instead of question
 * 24Mar14 Sathish Removed .Value in GetUserIdByUserDetails and GetUserIdAndPassworByUserDetails to avoid .Value Property missing error while unit testing.
 * 25Mar14 Sathish Removed .Value in GetUserNameAndIdByUserDetails and GetUserNameAndIdByUserDetails to avoid .Value Property missing error while unit testing.
 * 26Mar14 Bala return type modified in UpdateEmailByUserId and ResetPassword method.
 * 31Mar2014 Sathis Changed validatePasswordResetCode by user id instead of user Name and return true or false
 * 15Apr2014 Sathish Corrected Paramater name in validatePasswordResetCode userId to user_id
 *  23April2014 Thileepkumar Changed validatePassword by user id
 * 
 */

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using JTL.Tax1040.BusinessObject;
using System;
using System.Dynamic;
using System.Collections.Generic;

namespace JTL.Tax1040.DataAccess
{
    /// <summary>
    ///Regarding  UserDataService : Get (or) Update User Details
    /// </summary>
    public class UserDataService : IUserDataService
    {

        #region Connection String
        private readonly string mConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        #endregion

        #region Registration

        public dynamic PersistUser(User user)
        {
            var userId = 0L;
            var isEmailExist = false;
            var isUserExist = false;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_user_persist]";
                    sqlCommand.Parameters.Add("@email", user.Email);
                    sqlCommand.Parameters.Add("@username", user.UserName);
                    sqlCommand.Parameters.Add("@password", user.Password);
                    sqlCommand.Parameters.Add("@salt", user.Salt);
                    sqlCommand.Parameters.Add("@security_question_id", user.SecurityQuestionId);
                    sqlCommand.Parameters.Add("@security_answer", user.SecurityAnswer);
                    sqlCommand.Parameters.Add("@client_IP", user.ClientIp);

                    var sqlEmailExistParameter = new SqlParameter("@email_exist", SqlDbType.Bit);
                    var sqlUserExistParameter = new SqlParameter("@username_exist", SqlDbType.Bit);

                    sqlEmailExistParameter.Direction = ParameterDirection.Output;
                    sqlUserExistParameter.Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(sqlEmailExistParameter);
                    sqlCommand.Parameters.Add(sqlUserExistParameter);

                    var id = sqlCommand.ExecuteScalar();
                    userId = Convert.ToInt64(id);

                    isEmailExist = Convert.ToBoolean(sqlEmailExistParameter.Value.ToString());
                    isUserExist = Convert.ToBoolean(sqlUserExistParameter.Value.ToString());
                }
            }

            dynamic registerDetail = new ExpandoObject();
            registerDetail.UserId = userId;
            registerDetail.IsEmailExist = isEmailExist;
            registerDetail.IsUserExist = isUserExist;
            return registerDetail;
        }

        #endregion

        #region Login Authentication

        public dynamic SignInUser(string userName)
        {
            var userId = 0L;
            var password = string.Empty;
            var salt = string.Empty;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_user_authentication]";
                    sqlCommand.Parameters.Add("@username", userName);

                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var passwordOrdinal = dataReader.GetOrdinal("password");
                            var saltOrdinal = dataReader.GetOrdinal("salt");
                            var userIdOrdinal = dataReader.GetOrdinal("user_id");
                            while (dataReader.Read())
                            {
                                password = dataReader.GetString(passwordOrdinal);
                                salt = dataReader.GetString(saltOrdinal);
                                userId = dataReader.GetInt64(userIdOrdinal);
                            }
                        }
                    }
                }
            }

            dynamic userDetail = new ExpandoObject();
            userDetail.UserId = userId;
            userDetail.Password = password;
            userDetail.Salt = salt;
            return userDetail;
        }


        #endregion

        #region Get User Detail

        public string GetUserNameByEmail(string emailId)
        {
            var userName = string.Empty;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_username_by_email]";
                    sqlCommand.Parameters.Add("@email", emailId);

                    userName = Convert.ToString(sqlCommand.ExecuteScalar());
                }
            }

            return userName;
        }

        public dynamic GetUserNameAndEmailByUserIdAndSecurityInfo(long userId, int securityQuestionId, string securityAnswer)
        {
            dynamic userDetail = new ExpandoObject();
            var userName = string.Empty;
            var email = string.Empty;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_check_user_by_user_id_and_security_question]";
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);
                    sqlCommand.Parameters.AddWithValue("@security_question_id", securityQuestionId);
                    sqlCommand.Parameters.AddWithValue("@security_answer", securityAnswer);

                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var userNameOrdinal = dataReader.GetOrdinal("username");
                            var emailOrdinal = dataReader.GetOrdinal("email");

                            while (dataReader.Read())
                            {
                                userName = dataReader.GetString(userNameOrdinal);
                                email = dataReader.GetString(emailOrdinal);
                            }
                        }
                    }
                }
            }

            userDetail.UserName = userName;
            userDetail.Email = email;

            return userDetail;
        }

        public long GetUserIdByUserDetails(Person userDetail)
        {
            var userId = 0L;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_user_id_by_personal_details]";
                    sqlCommand.Parameters.Add("@first_name ", userDetail.FirstName);
                    sqlCommand.Parameters.Add("@last_name", userDetail.LastName);
                    sqlCommand.Parameters.Add("@date_of_birth", userDetail.DateOfBirth);
                    sqlCommand.Parameters.Add("@social_security_number", userDetail.SSN);

                    userId = Convert.ToInt64(sqlCommand.ExecuteScalar());
                }
            }

            return userId;
        }

        public dynamic GetUserNameAndIdByUserDetails(dynamic userDetail)
        {
            var userName = string.Empty;
            var userId = 0L;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_username_by_personal_details]";
                    sqlCommand.Parameters.Add("@first_name ", userDetail.FirstName);
                    sqlCommand.Parameters.Add("@last_name", userDetail.LastName);
                    sqlCommand.Parameters.Add("@date_of_birth", userDetail.DateOfBirth);
                    sqlCommand.Parameters.Add("@email", userDetail.Email);

                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var userNameOrdinal = dataReader.GetOrdinal("username");
                            var userIdOrdinal = dataReader.GetOrdinal("user_id");
                            while (dataReader.Read())
                            {
                                userName = dataReader.GetString(userNameOrdinal);
                                userId = dataReader.GetInt64(userIdOrdinal);
                            }
                        }
                    }
                }
            }
            dynamic user = new ExpandoObject();
            user.UserName = userName;
            user.UserId = userId;

            return user;
        }

        public long GetUserIdByUserName(string userName)
        {
            var userId = 0L;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_is_user_exists]";
                    sqlCommand.Parameters.Add("@username", userName);

                    userId = Convert.ToInt64(sqlCommand.ExecuteScalar());
                }
            }

            return userId;
        }

        public Tuple<Dictionary<int, string>, int> GetSecurityQuestion(long userId)
        {
            int selectedQuestionId = 0;
            var securityQuestion = new Dictionary<int, string>();

            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);
                    sqlCommand.CommandText = "[dbo].[usp_get_security_question]";

                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var questionId = dataReader.GetOrdinal("question_id");
                            var question = dataReader.GetOrdinal("question");
                            while (dataReader.Read())
                            {
                                securityQuestion.Add(dataReader.GetInt32(questionId), dataReader.GetString(question));
                            }
                            if (dataReader.NextResult())
                            {
                                var selectedquestionId = dataReader.GetOrdinal("selected_question_id");
                                while (dataReader.Read())
                                {
                                    selectedQuestionId = dataReader.GetInt32(selectedquestionId);
                                }
                            }
                        }


                    }
                }
            }

            return new Tuple<Dictionary<int, string>, int>(securityQuestion, selectedQuestionId);
        }


        public KeyValuePair<int, string> GetSecurityQuestionByUserId(long userId)
        {
            var securityQuestion = new KeyValuePair<int, string>();

            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);
                    sqlCommand.CommandText = "[dbo].[usp_get_security_question_by_user_id]";

                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var questionId = dataReader.GetOrdinal("question_id");
                            var question = dataReader.GetOrdinal("question");
                            while (dataReader.Read())
                            {
                                securityQuestion = new KeyValuePair<int, string>(dataReader.GetInt32(questionId), dataReader.GetString(question));
                            }
                        }
                        else
                        {
                            securityQuestion = new KeyValuePair<int, string>(0, "");
                        }
                    }
                }
            }

            return securityQuestion;
        }


        /// <summary>
        /// Get username and email by User id.
        /// </summary>
        /// <param name="user">The user Id</param>
        /// <returns>User detail</returns>
        public dynamic GetUsernameAndEmailByUserId(long userId)
        {
            dynamic userDetail = new ExpandoObject();
            var userName = string.Empty;
            var email = string.Empty;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_username_email_by_user_id]";
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);

                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var userNameOrdinal = dataReader.GetOrdinal("username");
                            var emailOrdinal = dataReader.GetOrdinal("email");

                            while (dataReader.Read())
                            {
                                userName = dataReader.GetString(userNameOrdinal);
                                email = dataReader.GetString(emailOrdinal);
                            }
                        }
                    }
                }
            }

            userDetail.UserName = userName;
            userDetail.Email = email;

            return userDetail;
        }
        #endregion

        #region Update User

        public string UpdateEmailByUserId(string email, long userId)
        {
            var userName = string.Empty;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_user_email_update]";
                    sqlCommand.Parameters.Add("@email", email);
                    sqlCommand.Parameters.Add("@user_id", userId);

                    userName = Convert.ToString(sqlCommand.ExecuteScalar());
                }
            }

            return userName;
        }

        public string ResetPassword(string userName, string password, long userId, string salt)
        {
            string email = string.Empty;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_reset_password_by_username]";
                    sqlCommand.Parameters.Add("@user_id", userId);
                    sqlCommand.Parameters.Add("@username", userName);
                    sqlCommand.Parameters.Add("@password", password);
                    sqlCommand.Parameters.Add("@salt", salt);

                    email = Convert.ToString(sqlCommand.ExecuteScalar());
                }

            }
            return email;
        }


        public bool UpdatePasswordResetCode(int resetCode, long userId)
        {
            var status = false;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_user_password_reset_code_update]";
                    sqlCommand.Parameters.Add("@password_reset_code", resetCode);
                    sqlCommand.Parameters.Add("@user_id", userId);

                    status = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                }
            }

            return status;
        }

        #endregion

        #region Validate password reset code

        public bool ValidateUserPasswordResetCode(long userId, long passwordResetCode)
        {
            bool isValidPassworResetCode = false;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_validate_user_password_reset_code]";
                    sqlCommand.Parameters.AddWithValue("@password_reset_code", passwordResetCode);
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);

                    isValidPassworResetCode = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                }
            }

            return isValidPassworResetCode;
        }
        #endregion

        #region Validate UserID

        public bool ValidUserID(long userId)
        {
            bool isValidUserID = false;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_valid_user_id]";
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);

                    isValidUserID = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                }
            }

            return isValidUserID;
        }
        #endregion

        #region Manage Account

        /// <summary>
        ///Get User Details By User Id
        /// </summary>        
        /// <returns>User Details of A Particular Id</returns>
        public User GetUserDetailsByUserId(long userId)
        {
            User user = null;
            using (var connection = new SqlConnection(mConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[dbo].[usp_get_user_details_by_user_id]";
                    cmd.Parameters.Add(new SqlParameter("@user_id", userId));

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            //int useridOrdinal = dataReader.GetOrdinal("user_id");
                            int emailidOrdinal = dataReader.GetOrdinal("email");
                            int userNameOrdinal = dataReader.GetOrdinal("username");
                            int passwordOrdinal = dataReader.GetOrdinal("password");
                            int saltOrdinal = dataReader.GetOrdinal("salt");
                            int securityuestionIdOrdinal = dataReader.GetOrdinal("security_question_id");
                            int securityAnswerOrdinal = dataReader.GetOrdinal("security_answer");
                            while (dataReader.Read())
                            {
                                user = new User()
                                {
                                    //UserId = dataReader.GetInt64(useridOrdinal),
                                    Email = dataReader.GetString(emailidOrdinal),
                                    UserName = dataReader.GetString(userNameOrdinal),
                                    Password = dataReader.GetString(passwordOrdinal),
                                    Salt = dataReader.GetString(saltOrdinal),
                                    SecurityQuestionId = dataReader.GetInt32(securityuestionIdOrdinal),
                                    SecurityAnswer = dataReader.GetString(securityAnswerOrdinal),
                                };

                            }
                        }
                    }
                }
            }
            return user;
        }

        /// <summary>
        ///Update User Details By User Id
        /// </summary>        
        /// <returns>Status</returns>
        public long UpdateUserDetailsByUserId(User user)
        {
            long status = 0;
            using (var connection = new SqlConnection(mConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[dbo].[usp_update_user_details_by_user_id]";
                    cmd.Parameters.Add(new SqlParameter("@user_id", user.UserId));
                    cmd.Parameters.Add(new SqlParameter("@email", user.Email));
                    cmd.Parameters.Add(new SqlParameter("@username", user.UserName));
                    cmd.Parameters.Add(new SqlParameter("@password", user.Password));
                    cmd.Parameters.Add(new SqlParameter("@salt", user.Salt));
                    cmd.Parameters.Add(new SqlParameter("@security_question_id", user.SecurityQuestionId));
                    cmd.Parameters.Add(new SqlParameter("@security_answer", user.SecurityAnswer));
                    status = Convert.ToInt64(cmd.ExecuteScalar());

                }
            }
            return status;
        }

        /// <summary>
        ///Get User Details By User Id
        /// </summary>        
        /// <returns>User Details of A Particular Id</returns>
        public User ValidateUserPasswordByUserId(long userId)
        {
            User user = new User();
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_user_authentication_by_user_id]";
                    sqlCommand.Parameters.Add("@user_id", userId);

                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var passwordOrdinal = dataReader.GetOrdinal("password");
                            var saltOrdinal = dataReader.GetOrdinal("salt");
                            var userIdOrdinal = dataReader.GetOrdinal("user_id");
                            while (dataReader.Read())
                            {
                                user.Password = dataReader.GetString(passwordOrdinal);
                                user.Salt = dataReader.GetString(saltOrdinal);
                                user.UserId = dataReader.GetInt64(userIdOrdinal);
                            }
                        }
                    }
                }
            }

            return user;
        }

        #endregion


    }
}


