using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production.Models
{

    public class StatusModel
    {
        private Connection conn;

        private string name, color, descriptionStatus;


        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public string DescriptionStatus { get => descriptionStatus; set => descriptionStatus = value; }


        public StatusModel(string name, string color, string descriptionStatus)
        {
            this.name = name;
            this.color = color;
            this.descriptionStatus = descriptionStatus;

        }

        public void SaveStatus()
        {
            string query = String.Format("INSERT INTO status VALUES ('{0}','{1}','{2}')", name, Color, descriptionStatus);

            conn = new Connection();
            conn.Insert(query);
        }

     /*   public StatusModel()
        {
            if (name == "aceptado")
            {
                rbtncolor == "green";
            }*/
        }
    }
