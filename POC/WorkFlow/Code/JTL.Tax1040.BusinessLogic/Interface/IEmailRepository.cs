
/*
Copyright   : Copyright Jeevan Technologies
File Name   : IEmailRepository.cs 
Description : Business object for EmailData. 
Author      : Sathish Natarajan
Date        : 13 Mar 2014
Modification History:
---------------------
 */

using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessLogic
{
    public interface IEmailRepository
    {
        /// <summary>
        /// Get Email Template By ID
        /// </summary>
        /// <param name="emailTemplateId">The Template ID</param>
        /// <returns></returns>
        EmailData GetEmailTemplateById(EmailTemplate emailTemplateId);

    }
}
