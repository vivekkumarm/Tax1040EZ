
/*
Copyright   : Copyright Jeevan Technologies
File Name   : IEmailDataService.cs 
Description : Business object for EmailData. 
Author      : Sathish Natarajan
Date        : 13 Mar 2014
Modification History:
---------------------
 */


using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.DataAccess
{
    public interface IEmailDataService
    {
        /// <summary>
        /// Get Email Template by ID
        /// </summary>
        /// <param name="template">The Email template ID</param>
        /// <returns></returns>
        EmailData GetEmailTemplateById(EmailTemplate templateId);
    }
}
