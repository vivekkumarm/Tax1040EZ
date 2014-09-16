/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   User.cs 
    Description     :   Business object for Person. 
    Author          :   Vivek 
    Created Date    :   

    Modification History:
    ---------------------
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 * 18Mar2014 Sathish modified SecurityQuestion to SecurityQuestionId and string to int
 * 09May2014 Thileepkumar added SecurityQuestion to show SecurityQuestion in Email Template
 * 07July2014 Thileepkumar added NewPassword field
 */

namespace JTL.Tax1040.BusinessObject
{
    public class User
    {
        public string UserName { get; set; }

        public string Password { get; set; }
        
        public string NewPassword { get; set; }

        public string Salt { get; set; }

        public int SecurityQuestionId { get; set; }

        public string SecurityAnswer { get; set; }

        public string Email { get; set; }

        public bool?IsActive { get; set; }
    
        // Added by Thileepkumar on 17.04.2014    
        public bool? IsDeleted { get; set; }

        public string SecurityQuestion { get; set; }

        public long UserId { get; set; }

        public string ClientIp { get; set; }
   }
}

