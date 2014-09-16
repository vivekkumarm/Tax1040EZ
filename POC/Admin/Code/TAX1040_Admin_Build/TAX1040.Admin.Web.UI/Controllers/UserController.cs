using System.Web.Mvc;
using JTL.TAX1040.Admin.BusinessLogic;

namespace TAX1040.Admin.Web.UI.Controllers
{

    public class UserController : Controller
    {

        #region Declaration
        private readonly UserRepository userRepository;
        #endregion

        #region Constructor

        public UserController()
        {
            userRepository = new UserRepository();
        }

        #endregion

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns></returns>
       [HttpGet]
        public ActionResult GetAllCustomers()
        {
            var user= userRepository.GetAllCustomers();
            return View(user);
        }
       
    }
}
