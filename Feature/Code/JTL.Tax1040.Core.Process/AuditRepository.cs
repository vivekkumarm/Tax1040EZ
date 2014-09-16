
/*
Copyright   : Copyright Jeevan Technologies
File Name   : AuditRepository.cs 
Description : Persist audit information. 
Author      : Bhavani Rajesh
Date        : 27 Aug 2014
Modification History:
---------------------
 */

using JTL.Tax1040.Core.Object;
using JTL.Tax1040.DataAccess;
using JTL.Tax1040.DataAccess.DataService;

namespace JTL.Tax1040.Core.Process
{
    public class AuditRepository : IAuditRepository
    {
  
        private readonly IAuditDataService mAuditDataService;

        public AuditRepository()
        {
            mAuditDataService = new AuditDataService();
        }

        #region Persist Audit

          /// <summary>
          /// Audits the specified audit information.
          /// </summary>
          /// <param name="auditInfo">The audit information.</param>
        public void Audit(Audit auditInfo)
        {
           mAuditDataService.Audit(auditInfo);
        }

        #endregion
    }
}
