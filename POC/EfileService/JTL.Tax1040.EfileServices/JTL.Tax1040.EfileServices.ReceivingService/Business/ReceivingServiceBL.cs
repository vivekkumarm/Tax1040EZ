using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JTL.Tax1040.EfileServices.BusinessObject;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class ReceivingServiceBL
    {
        #region Constants
        ReceivingServiceDAL receivingServiceDAL;
        #endregion

        #region Constructor
        public ReceivingServiceBL()
        {
            receivingServiceDAL = new ReceivingServiceDAL();
        }
        #endregion

        #region Receiving Service method.
        /// <summary>
        /// Create Efile retrun data.
        /// </summary>
        /// <param name="messagesDE">MessagesDE.</param>
        public void PersistEfileReturnData(EfileReturnData efileReturnData)
        {
            receivingServiceDAL.PersistEfileReturnData(efileReturnData);
        }
        #endregion
    }
}