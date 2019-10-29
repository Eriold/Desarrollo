using Production.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Production.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            // ViewData["Message"] = Request["id"];

            string id = Request["id"];
            string name = Request["name"];
            string lastName = Request["lastName"];
            string email = Request["email"];
            string budget = (Request["budget"]);
            string projectScope = Request["projectScope"];
            int telephoneNumber;
            int.TryParse(Request["telephoneNumber"], out telephoneNumber);

            ClientModel ObjClient = new ClientModel(id, name, lastName, email, telephoneNumber, budget, projectScope);

            ObjClient.SaveClient();

            return View("ClientView");
        }

        [HttpPost]
        [ActionName("SubmitClientPost")]
        public ActionResult SubmitClientPost()
        {
            return View();
        }
    }
}