/*
Copyright   : Copyright Jeevan Technologies
File Name   : IAuditDataService.cs 
Description : Holds the Audit functionality method definitions.
Author      : Bhavani Rajesh
Date        : 28 Aug 2014
Modification History:
---------------------
 */


using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.DataAccess
{
    public interface IAuditDataService
    {
        /// <summary>
        /// Audits the specified object.
        /// </summary>
        /// <param name="audit">The audit.</param>
        void Audit(Audit audit);
    }
}
