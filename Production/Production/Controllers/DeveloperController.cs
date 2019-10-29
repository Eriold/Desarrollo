using Production.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Production.Controllers
{
    public class DeveloperController : Controller
    {
       
        // GET: Developer
        public ActionResult Index()
        {
            string id = Request["id"];
            string name = Request["name"];
            string lastName = Request["lastName"];
            string email = Request["email"];
            int telephoneNumber;
            int.TryParse(Request["telephoneNumber"], out telephoneNumber);

     

            DeveloperModel ObjDev= new DeveloperModel(id, name, lastName, email, telephoneNumber);


            ObjDev.SaveDeveloper();



            return View("DeveloperView");
        }
    }


    }
