using System.Web.Http;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;

namespace JTL.Tax1040.WebApi.Controllers
{
    public class EFileController : ApiController
    {
        #region Local variables
        static readonly IEFileRepository eFileRepository = new EFileRepository();
        #endregion

        /// <summary>
        /// Get the Person Detials
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns></returns>
        [HttpPost]
        public System.Tuple<string, PersonalDetails, IRSTransmission> GetPersonAndIRSTransmission(dynamic UserInputData)
        {
            return eFileRepository.GetPersonAndIRSTransmission(Utilities.ConvertToLong(UserInputData.UserId.Value),
                                                 Utilities.ConvertToLong(UserInputData.UserDataId.Value));
        }

        [HttpPost]
        public IRSTransmission GetIRSTranmission(dynamic UserInputData)
        {
            return eFileRepository.GetIRSTranmission(Utilities.ConvertToLong(UserInputData.UserId.Value),
                                                Utilities.ConvertToLong(UserInputData.UserDataId.Value));
        }

    }
}
