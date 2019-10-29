using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production.Models
{
    public class ProcessMonitoringModel : StatusModel
    {
        private string idMonitoring;

        public string IdMonitoring { get => idMonitoring; set => idMonitoring = value; }

        //DeveloperTeamModel objDT;

        public ProcessMonitoringModel(string name, string color, string description, string idMonitoring)
            : base(name, color, description)
        {
            this.idMonitoring = idMonitoring;
            //objDT.WeekMeeting();
        }


    }
}