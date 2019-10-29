using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production.Models
{
    public class InternalProductorModel : Person
    {
        private Connection conn;

        private string id;
        private string name;
        private string lastName;
        private string email;
        private string jobTitle;
        private int telephoneNumber;

        public InternalProductorModel(string id, string name, string lastName, string email, int telephoneNumber, string jobTitle)
       : base(id, name, lastName, email, telephoneNumber)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.telephoneNumber = telephoneNumber;
            this.jobTitle = jobTitle;

        }

        public string JobTitle { get => jobTitle; set => jobTitle = value; }


        public void SaveInternalProductor()
        {
            string query = String.Format("INSERT INTO internalproductor VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", id, name, lastName, email, telephoneNumber, jobTitle);

            conn = new Connection();
            conn.Insert(query);
        }

        public string[] ConsultInternalProductor(string id)
        {
                   
            string query = String.Format("SELECT * from internalproductor where id = ", id);
            string[] datos = new string[5];
            conn = new Connection();
            datos=conn.Search(query);
            /*
            Id = datos[0];
            Name = datos[1];
            LastName = datos[2];
            Email = datos[3];
            TelephoneNumber = Int32.Parse(datos[4]);
            JobTitle = datos[5];
            */
            return datos;
        }

    }


    }
