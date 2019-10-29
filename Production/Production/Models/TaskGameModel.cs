using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production.Models
{
    public class TaskGameModel 
    {
        Connection conn;

        private string nameTask, descriptionTask;
       // private string name, color, descriptionStatus;

        //public const int STATE_APROVED = 1;
        // public const int STATE_NOT_APPROVED = 2;
        // private Boolean statusTask;//aprobado o no aprobado? ESTO ADEMAS PARECE QUE ES ESTATUS

      

        //public bool StatusTask { get => statusTask; set => statusTask = value; }

       /* public TaskGameModel(string nameTask, string descriptionTask, string name, string color, string descriptionStatus)
            : base(name, color, descriptionStatus)
        {
            this.nameTask = nameTask;
            this.descriptionTask = descriptionTask;
            this.name = name;
            this.color = color;
            this.descriptionStatus = descriptionStatus;
            //this.statusTask = statusTask;
        }*/

        public TaskGameModel(string nameTask, string descriptionTask)
          
        {
            this.nameTask = nameTask;
            this.descriptionTask = descriptionTask;
         
        }

        public TaskGameModel()
        {
        }

        public string NameTask { get => nameTask; set => nameTask = value; }
        public string DescriptionTask { get => descriptionTask; set => descriptionTask = value; }



        public void SaveTaskGame()
        {
            string query = String.Format("INSERT INTO taskgame VALUES ('{0}','{1}')", nameTask, descriptionTask);

            conn = new Connection();
            conn.Insert(query);
        }
        
        public void TaskSelection(Boolean taskB)
        {
            Boolean answer = (taskB) ? true : false;
        }

        public void TaskExcecution() { }

    }
}