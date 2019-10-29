using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production.Models
{
    public class ProcessClosureModel : StatusModel
    {
        //private InternalProductorModel objIP;
        //private DeveloperTeamModel objDevTeam;
        public ProcessClosureModel(string name, string color, string description)
            : base(name, color, description)
        {

        }


        public void GameState(string color)
        {
            switch (color)
            {
                case "blue":
                    //Finish
                    break;
                case "red":
                    //working
                    break;
                default:
                    //waiting
                    break;
            }
        }

        public void ProcessEvaluate()
        {
            //objIP.CharacterDev();
        }

        public void UpdateProjectPlan()
        {
            ProcessEvaluate();
            //objDevTeam.TaskNew();
        }
    }
}