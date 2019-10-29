using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production.Models
{
    public class ClientModel : Person
    {
        private Connection conn;


        private string id;
        private string name;
        private string lastName;
        private string email;       
        private int telephoneNumber;
        private string budget;
        private string projectScope;

        public ClientModel(string id, string name, string lastName, string email, int telephoneNumber, string budget, string projectScope)
             : base(id, name, lastName, email, telephoneNumber)
        {

            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.telephoneNumber = telephoneNumber;
            this.budget = budget;
            this.projectScope = projectScope;
        }

        public string ProjectScope { get => projectScope; set => projectScope = value; }
        public string Budget { get => budget; set => budget = value; }


        public void SaveClient()
        {
            string query = String.Format("INSERT INTO client VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", 
                id, name, lastName, email, telephoneNumber, budget, projectScope);

            conn = new Connection();
            conn.Insert(query);
        }
        public void Register()
        {
            VideoGameModel objVideoGame = new VideoGameModel();
        }


    }
}