using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkflowManagement.Controllers
{
    public class CreateNoteController : Controller
    {
        // GET: CreateNote
        [HttpGet]
        public ActionResult Index()
        {
            return View("CreateNote");
        }
    }
}