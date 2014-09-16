using System.Collections.Generic;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.Core.Process
{
    public interface IMessagesRepository
    {
        Dictionary<string, ErrorMessage> GetErrorMessages();

        /// <summary>
        ///  Clear errr messages for particular form
        /// </summary>
        /// <param name="errorMessages">The list of error messages</param>
        /// <param name="topic">The topic</param>
        /// <param name="fId">The form id</param>
        /// <param name="errorCode">The Error code</param>
        /// <returns></returns>
        void ClearErrorMessages(List<ErrorMessage> errorMessages, string topic, long fId = 0, string errorCode = null);

    }
}
