using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production.Models
{
    public class DeveloperModel :  Person
    {
        private Connection conn;

        private string id;
        private string name;
        private string lastName;
        private string email;
        private int telephoneNumber;


        public DeveloperModel(string id, string name, string lastName,
                         string email, int telephoneNumber)
                         : base(id, name, lastName, email, telephoneNumber)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.telephoneNumber = telephoneNumber;

        }

        public void SaveDeveloper()
        {
            string query = String.Format("INSERT INTO developer VALUES ('{0}','{1}','{2}','{3}','{4}')", id, name, lastName, email, telephoneNumber);

            conn = new Connection();
            conn.Insert(query);
        }
    }
}