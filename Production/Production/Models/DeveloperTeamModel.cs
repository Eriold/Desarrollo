using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production.Models
{
    public class DeveloperTeamModel
    {
        private List<DeveloperModel> listDeveloper;
        //private List<Task> listTask;
        private static TaskGameModel objTask = new TaskGameModel( );

        private string nameTeam;

        public string NameTeam { get => nameTeam; set => nameTeam = value; }

        //private InternalProductorModel objIP;

        public DeveloperTeamModel(string nameTeam)
        {
            //listDeveloper = new List<DeveloperModel>();
            //listTask = new List<Task>();

            this.NameTeam = nameTeam;
        }

        public void WeekMeeting()
        {
            //objTask();

        }
        public void NewCharacteristics(Boolean desition)
        {
            //objIP.CharacterDev();
            objTask.TaskSelection(desition);
        }

        public void GameVersion()
        {
            if (true)
            {
                //New Version
            }
            else
            {
                //Nope
            }
        }

        public void TaskNew()
        {

        }
    }
}