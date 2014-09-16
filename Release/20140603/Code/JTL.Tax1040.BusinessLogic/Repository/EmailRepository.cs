
/*
Copyright   : Copyright Jeevan Technologies
File Name   : EmailRepository.cs 
Description : Business object for EmailData. 
Author      : Sathish Natarajan
Date        : 13 Mar 2014
Modification History:
---------------------
 */

using JTL.Tax1040.Core.Object;
using JTL.Tax1040.DataAccess;
using JTL.Tax1040.BusinessObject;

namespace JTL.Tax1040.BusinessLogic
{
    public class EmailRepository : IEmailRepository
    {
        private IEmailDataService emailDataService;

        public EmailRepository()
        {
            emailDataService = new EmailDataService();
        }

        public EmailData GetEmailTemplateById(EmailTemplate emailTemplateId)
        {
            return emailDataService.GetEmailTemplateById(emailTemplateId);
        }

    }
}
