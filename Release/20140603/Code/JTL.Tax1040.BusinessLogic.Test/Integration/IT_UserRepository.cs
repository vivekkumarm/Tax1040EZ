/*
Copyright   : Copyright Jeevan Technologies
File Name   : IT_UserRepository 
Description : Integration test for UserRepository. 
Author      : Balasubramanian.V
Date        : 13 Mar 2014
Modification History:
---------------------
 * 17Mar2014 Bala Code modified to use the ‘Security Answer’ field before it's encryption and refactored the code.  
 * 24Mar2014 Sathish Added unit test for security question and Get User by personal Info
 * 25Mar2014 Sathish Removed expend object from Get User Info by user
 * 31Mar2014 Bala Added ErrorMessages as parameter.
 * 08May2014 Bala Code modified due to SignInUser Repository method modified
 */

using System.Collections.Specialized;
using System;
using System.Dynamic;
using JTL.Tax1040.BusinessObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessLogic.Test
{
    [TestClass()]
    public class IT_UserRepository
    {
        IUserRepository mUserRepository;
        private StringCollection errorMessages;
        const string EMAIL_EXIST = "The Email Address already exists. You can Sign In or Recover your account.";
        const string USERNAME_EXIST = "The Username already exists. Please provide different name.";

        [TestInitialize]
        public void TestInitialize()
        {
            mUserRepository = new UserRepository();
            errorMessages = new StringCollection();
        }

        [TestMethod]
        public void RegisterNewUser()
        {
            var errorMessages = new StringCollection();
            var user = CreateUser();
            var userId = mUserRepository.PersistUser(user, out errorMessages);

            Assert.AreNotEqual(0, userId); //New user created.

        }

        [TestMethod]
        public void RegisterNewUserWithExistingUserName()
        {
            var user = CreateUser();

            //Create new user.
            var userId = mUserRepository.PersistUser(user, out errorMessages);

            Assert.AreNotEqual(0, userId);

            var existingUserName = user.UserName;
            user = CreateUser();
            user.UserName = existingUserName;

            //Create new user with existing user name.
            userId = mUserRepository.PersistUser(user, out errorMessages);

            Assert.AreEqual(0, userId);
            Assert.IsTrue(errorMessages.Count == 1);
            Assert.AreEqual("The Username already exists. Please provide different name.", errorMessages[0]);
        }

        [TestMethod]
        public void RegisterNewUserWithExistingEmailId()
        {
            var user = CreateUser();

            //Create new user.
            var userId = mUserRepository.PersistUser(user, out errorMessages);

            Assert.AreNotEqual(0, userId);

            var existingEmailId = user.Email;
            user = CreateUser();
            user.Email = existingEmailId;

            //Create new user with existing email id.
            userId = mUserRepository.PersistUser(user, out errorMessages);

            Assert.AreEqual(0, userId);
            Assert.IsTrue(errorMessages.Count == 1);
            Assert.AreEqual("The Email Address already exists. You can Sign In or Recover your account.", errorMessages[0]);
        }

        #region Sign In User
        [TestMethod()]
        public void SignInWithValidUser()
        {
            var user = CreateUser();
            var password = user.Password;

            //Create New user
            var userId = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, userId);

            // Sign In with valid user
            var sigInUserId = mUserRepository.SignInUser(user.UserName, password);
            Assert.AreEqual(userId, sigInUserId);
        }

        [TestMethod()]
        public void SignInWithInvalidPassword()
        {
            var user = CreateUser();
            var password = user.Password;
            //Create New user
            var userId = mUserRepository.PersistUser(user, out errorMessages);

            Assert.AreNotEqual(0, userId);

            var invalidPassword = password + "Invalid";

            // Sign In with Invalid password
            var sigInUserId = mUserRepository.SignInUser(user.UserName, invalidPassword);

            Assert.AreEqual(0, sigInUserId);
            Assert.AreNotEqual(userId, sigInUserId);
        }

        [TestMethod()]
        public void SignInWithInvalidUserName()
        {
            var user = CreateUser();
            var password = user.Password;

            //Create New user
            var actualUserId = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, actualUserId);

            var invalidUserName = user.UserName + "Invalid Name";

            // Sign In with Invalid User
            var expectedUserId = mUserRepository.SignInUser(invalidUserName, password);

            Assert.AreEqual(0, expectedUserId);
            Assert.AreNotEqual(actualUserId, expectedUserId);
        }

        [TestMethod()]
        public void SignInWithInvalidUserNameAndPassword()
        {
            var user = CreateUser();
            var password = user.Password;

            //Create New user
            var actualUserId = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, actualUserId);

            var invalidUserName = user.UserName + "Invalid Name";
            var invalidPassword = user.UserName + "Password";

            // Sign In with Invalid User
            var expectedUserId = mUserRepository.SignInUser(invalidUserName, invalidPassword);

            Assert.AreEqual(0, expectedUserId);
            Assert.AreNotEqual(actualUserId, expectedUserId);
        }


        #endregion

        #region Update Email by user ID

        [TestMethod]
        public void UpdateEmailByUserID()
        {
            var user = CreateUser();

            //Create New user
            var userId = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, userId);
            //Create new Email.
            var newEmail = user.Email.Replace("TestEmail", "UpdateTestEmail");
            var status = mUserRepository.UpdateEmailByUserId(newEmail, userId, out errorMessages);

            Assert.IsTrue(status);
        }

        [TestMethod]
        public void UpdateAlreadyExistEmailtByUserID()
        {
            var user1 = CreateUser();

            //Create New user
            var userId1 = mUserRepository.PersistUser(user1, out errorMessages);
            Assert.AreNotEqual(0, userId1);

            var user2 = CreateUser();
            var userId2 = mUserRepository.PersistUser(user2, out errorMessages);
            Assert.AreNotEqual(0, userId2);

            var status = mUserRepository.UpdateEmailByUserId(user2.Email, userId1, out errorMessages);
            Assert.IsFalse(status);

        }

        #endregion

        #region Reset Password by User Detail

        [TestMethod]
        public void ResetPasswordWithValidUserDetail()
        {
            var user = CreateUser();
            var password = user.Password + "Reset";

            //Create New user
            var userId = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, userId);

            var status = mUserRepository.ResetPassword(user.UserName, password, userId, out errorMessages);
            Assert.IsTrue(status);
        }

        [TestMethod]
        public void UpdatePasswordResetCodeByUserDetail()
        {
            var user = CreateUser();
            string securityAnswer = user.SecurityAnswer;
            //Create New user
            var userId = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, userId);

            // Update password reset code based on valid user name, security and answer
            var status = mUserRepository.UpdatePasswordResetCodeBySecurityInfo(userId, user.SecurityQuestionId,
                securityAnswer);
            Assert.IsTrue(status);
        }

        [TestMethod]
        public void UpdatePasswordResetCodeByInvalidUsername()
        {
            var user1 = CreateUser();

            //Create New user
            var userId = mUserRepository.PersistUser(user1, out errorMessages);
            Assert.AreNotEqual(0, userId);


            var user2 = CreateUser();

            userId = mUserRepository.PersistUser(user2, out errorMessages);

            // Update password reset code by valid user name.
            var status = mUserRepository.UpdatePasswordResetCodeBySecurityInfo(user2.UserId, user1.SecurityQuestionId,
                user1.SecurityAnswer);

            Assert.IsFalse(status);

        }

        [TestMethod]
        public void UpdatePasswordResetCodeByInvalidQuestionAndAnswer()
        {
            var user1 = CreateUser();

            //Create New user
            var userId = mUserRepository.PersistUser(user1, out errorMessages);
            Assert.AreNotEqual(0, userId);

            var user2 = CreateUser();

            // Update password reset code by Incorrect Question and Answer
            var status = mUserRepository.UpdatePasswordResetCodeBySecurityInfo(user1.UserId,
                                                            user2.SecurityQuestionId,
                                                            user2.SecurityAnswer);

            Assert.IsFalse(status);

        }

        [TestMethod]
        public void ValidatePasswordResetCodeByUserName()
        {
            var user = CreateUser();
            var securityAnswer = user.SecurityAnswer;
            //Create New user
            var userId = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, userId);

            var status = mUserRepository.UpdatePasswordResetCodeBySecurityInfo(userId, user.SecurityQuestionId, securityAnswer);
            Assert.IsTrue(status);

            //   mUserRepository.ValidateUserPasswordResetCode(


        }

        #endregion

        #region Get User Detail

        [TestMethod]
        public void GetUserIdByUserDetail()
        {
            var user = CreateUser();
            var userDataId = 0L;
            //Create New user
            var userId1 = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, userId1);

            var primaryTaxPayer = IT_PersonalInfo.CreateAndPersistPrimaryTaxPayer(userId1, FilingStatus.Single, ref userDataId);

            // Get User ID by User Detail
            var userId2 = mUserRepository.GetUserIdByUserDetails(primaryTaxPayer.Person);
            Assert.AreEqual(userId2, userId1);

        }

        [TestMethod]
        public void GetUserNameAndIdByUserDetails()
        {
            var user = CreateUser();
            var userDataId = 0L;
            //Create New user
            var userId1 = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, userId1);

            var primaryTaxPayer = IT_PersonalInfo.CreateAndPersistPrimaryTaxPayer(userId1, FilingStatus.Single, ref userDataId);
            dynamic userDetail = new ExpandoObject();
            userDetail.FirstName = primaryTaxPayer.Person.FirstName;
            userDetail.LastName = primaryTaxPayer.Person.LastName;
            userDetail.DateOfBirth = primaryTaxPayer.Person.DateOfBirth;
            userDetail.Email = user.Email;

            // Get User ID by User Detail
            var userId2 = mUserRepository.GetUserNameAndIdByUserDetails(userDetail);
            Assert.AreEqual(userId2, userId1);
        }



        [TestMethod]
        public void GetUserNameByEmail()
        {
            var user = CreateUser();

            //Create New user
            var userId = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, userId);

            var userName = mUserRepository.GetUserNameByEmail(user.Email);
            Assert.AreEqual(user.UserName, userName);

            //Get user name with incorrect user email 
            var user2 = CreateUser();
            userName = mUserRepository.GetUserNameByEmail(user2.Email);
            Assert.AreNotEqual(user.UserName, userName);
        }

        [TestMethod]
        public void GetUserIdByUserName()
        {
            var errorMessages = new StringCollection();
            var user = CreateUser();

            //Create New user
            var userId1 = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, userId1);

            var userId2 = mUserRepository.GetUserIdByUserName(user.UserName);
            Assert.AreEqual(userId1, userId2);

            //Get user id with incorrect user Name
            var newUser = CreateUser();
            userId2 = mUserRepository.GetUserIdByUserName(newUser.UserName);
            Assert.AreNotEqual(userId1, userId2);

        }


        [TestMethod]
        public void GetSecurityQuestion()
        {
            var securityQuestion = mUserRepository.GetSecurityQuestion();
            Assert.IsTrue(securityQuestion.Count > 0);
        }


        [TestMethod]
        public void GetSecurityQuestionByUserID()
        {
            var user = CreateUser();
            //Create New user
            var userId = mUserRepository.PersistUser(user, out errorMessages);

            Assert.AreNotEqual(0, userId);

            var securityQuestion = mUserRepository.GetSecurityQuestionByUserId(userId);

            Assert.IsTrue(user.SecurityQuestionId == securityQuestion.Key);
        }

        [TestMethod]
        public void GetSecurityQuestionByInvalidUserID()
        {
            var user = CreateUser();

            //Create New user
            var userId = mUserRepository.PersistUser(user, out errorMessages);
            Assert.AreNotEqual(0, userId);

            var user1 = CreateUser();
            userId = mUserRepository.PersistUser(user1, out errorMessages);
            Assert.AreNotEqual(0, userId);

            var securityQuesiton = mUserRepository.GetSecurityQuestionByUserId(user1.SecurityQuestionId);

            Assert.IsFalse(user.SecurityQuestionId == securityQuesiton.Key);

        }


        #endregion

        [TestCleanup]
        public void TestCleanUp()
        {

        }

        #region Helper Methods

        private static User CreateUser()
        {
            var randomValue = Guid.NewGuid().ToString().Substring(0, 7);
            Random randomSecurityQuestionID = new Random();
            var securityQuestionID = randomSecurityQuestionID.Next(1, 7);
            var user = new User()
            {
                UserName = "TestUser" + randomValue,
                Password = "TestPassword@1",
                Email = "TestEmail" + randomValue + "@TaxGarden.com",
                SecurityQuestionId = securityQuestionID,
                SecurityAnswer = "Test Security Answer" + randomValue
            };

            return user;
        }

        public static long PersistNewUser()
        {
            IUserRepository userRepository = new UserRepository();
            var errorMessages = new StringCollection();
            var user = CreateUser();
            var userId = userRepository.PersistUser(user, out errorMessages);

            return userId;
        }

        //public static PrimaryTaxPayer CreateAndPersistPersonalInfo(long userId)
        //{
        //    var randomValue = Guid.NewGuid().ToString().Substring(0, 5);
        //    var primaryTaxPayer = new PrimaryTaxPayer();

        //    var person = new Person
        //    {
        //        PersonId = 0,
        //        FirstName = "First Name",
        //        MiddleName = "Middle Name",
        //        LastName = "Last Name",
        //        NickName = "Nick Name",
        //        Occupation = "Occupation",
        //        DateOfBirth = DateTime.Now,
        //        SSN = "SSN00" + randomValue.ToString(),
        //        PersonType = PersonType.PrimaryTaxPayer,
        //    };
        //    primaryTaxPayer.Person = person;
        //    primaryTaxPayer.FilingStatus = FilingStatus.Single;
        //    primaryTaxPayer.Person.PersonType = PersonType.PrimaryTaxPayer;

        //    //Personal info inserting
        //    var personalInfoDataService = new PersonalInfoDataService();
        //    personalInfoDataService.PersonalInfoPersist(primaryTaxPayer, userId);
        //    return primaryTaxPayer;
        //}

        #endregion


    }
}
