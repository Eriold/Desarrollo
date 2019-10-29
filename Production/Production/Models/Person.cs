using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production.Models
{
    public class Person
    {
        private string name, lastName, email, id;
        private int telephoneNumber;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }

        public Person(string id, string name, string lastName, string email, int telephoneNumber)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.telephoneNumber = telephoneNumber;
        }

        public void AbstractMethod()
        {

        }
    }
}