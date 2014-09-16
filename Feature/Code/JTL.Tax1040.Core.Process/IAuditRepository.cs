
/*
Copyright   : Copyright Jeevan Technologies
File Name   : IEmailRepository.cs 
Description : Business object for Audit. 
Author      : Bhavani Rajesh
Date        : 27 Aug 2014
Modification History:
---------------------
 */

using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.Core.Process
{
    public interface IAuditRepository
    {

        /// <summary>
        /// Audits the specified audit information.
        /// </summary>
        /// <param name="auditInfo">The audit information.</param>
        void Audit(Audit auditInfo);

    }
}
