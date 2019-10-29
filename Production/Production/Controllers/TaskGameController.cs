using Production.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Production.Controllers
{
    public class TaskGameController : Controller
    {
        // GET: TaskGame
        public ActionResult Index()
        {
            string nameTask = Request["nameTask"];
            string descriptionTask = Request["descriptionTask"];


            //TaskGameModel objTaskGame = new TaskGameModel(nameTask,  descriptionTask,  name,  color,  descriptionStatus);
            TaskGameModel objTaskGame = new TaskGameModel(nameTask,  descriptionTask);


            objTaskGame.SaveTaskGame();

            return View("TaskGameView");
        }
    }
}