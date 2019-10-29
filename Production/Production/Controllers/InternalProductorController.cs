using Production.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Production.Controllers
{
    public class InternalProductorController : Controller
    {
        // GET: InternalProductor
        public ActionResult Index()
        {
           // ViewData["Message"] = Request["id"];

            string id = Request["id"];
            string name = Request["name"];
            string lastName = Request["lastName"];
            string email = Request["email"];
            string jobTitle = Request["jobTitle"];
            int telephoneNumber;
            int.TryParse(Request["telephoneNumber"], out telephoneNumber);

            InternalProductorModel ObjIpm = new InternalProductorModel(id, name, lastName, email, telephoneNumber, jobTitle);


            ObjIpm.SaveInternalProductor();

            return View("InternalProductorView");
        }

        [HttpPost]
        [ActionName("SubmitInternalProductorPost")]
        public ActionResult Cosult()
        {
            return View();
        }
    }
}