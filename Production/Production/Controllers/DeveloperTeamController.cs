using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Production.Controllers
{
    public class DeveloperTeamController : Controller
    {

        // GET: DeveloperTeam
        public ActionResult Index()
        {


            return View("DeveloperTeamView");
        }
        [HttpPost]
        [ActionName("SubmitDeveloperTeamPost")]
        public ActionResult SubmitDeveloperTeamPost()
        {

            return View();
        }
    }
}