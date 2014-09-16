// ***********************************************************************
// Assembly         : Tax1040Web
// Author           : vivekkumar
// Created          : 02-12-2014
//
// Last Modified By : vivekkumar
// Last Modified On : 02-17-2014
// ***********************************************************************
// <copyright file="Login.aspx.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Specialized;
using JTL.Tax1040.BusinessObject;
using Tax1040WorkFlow;
using JTL.Tax1040.BusinessLogic;

namespace Tax1040Web
{
    public partial class Login : System.Web.UI.Page
    {
        IUserRepository userRepository = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string userName = txtusername.Text;
            string password = txtpassword.Text;
           userRepository.SignInUser(userName, password);
            

        }
    }
}