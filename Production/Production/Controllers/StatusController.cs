using Production.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Production.Controllers
{
    public class StatusController : Controller
    {
        // GET: Status
        public ActionResult Index()
        {
            string name = Request["name"];
            string color = Request["color"];
            string descriptionStatus = Request["descriptionStatus"];

            StatusModel objStatus = new StatusModel(name, color, descriptionStatus);

            objStatus.SaveStatus();

            return View("StatusView");
        }

        [HttpPost]
        [ActionName("SubmitStatusPost")]
        public ActionResult SubmitStatusPost()
        {
            return View();
        }
    }
}