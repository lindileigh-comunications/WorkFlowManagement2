using System.Web.Mvc;

namespace WorkflowManagement.Controllers
    {
    public class HomeController : Controller
        {
        [HttpGet]
        public ActionResult Index()
            {
            return View();
            }

        [HttpGet]
        public ActionResult AnotherLink()
            {
            return View("Index");
            }
        }
    }
