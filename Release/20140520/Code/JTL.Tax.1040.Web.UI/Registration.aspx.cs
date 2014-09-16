/*
Copyright   : Copyright Jeevan Technologies
File Name   : Registration.cs 
Description : Sample sign up page for user. 
Author      : 
Created Date : 

* Modification History:
---------------------
 * 18Mar14 Sathish Code Changed to check user by question id instead of question
 */



using System;
using System.Collections.Specialized;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.BusinessLogic;

namespace Tax1040Web
{
    public partial class Registration : System.Web.UI.Page
    {
        IUserRepository userRepository = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var userBO=new User();
           
            userBO.Email = txtemail.Text;
            userBO.UserName = txtusername.Text;
            userBO.Password = txtpasswd.Text;
            userBO.SecurityQuestionId = Convert.ToInt16( txtsquestion.Text);
            userBO.SecurityAnswer = txtanswer.Text;
            StringCollection errorMessages = null;
            userRepository.PersistUser(userBO, out errorMessages);
        }
    }
}