using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Production.Models
{
    public class Connection
    {
        private string server;
        private string port;
        private string database;
        private string user;
        private string password;
        private string conn;

        private MySqlConnection DBConn;

        public Connection()
        {
            //Constructor
            Inicialize();
        }

        private void Inicialize()
        {
            server = "localhost";
            port = "3306";
            database = "production";
            user = "root";
            password = "";
            conn = String.Format("server={0};port={1};user id={2}; password={3}; database={4}", server, port, user, password, database);
            this.OpenConn(conn);
        }

        private void OpenConn(string conn)
        {
            DBConn = new MySqlConnection(conn);
            try
            {
                DBConn.Open();
                Console.WriteLine("Succesfully Connection...");
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
            }
        }

        private void CloseConn()
        {
            try
            {
                DBConn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Insert(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, DBConn);
            cmd.ExecuteNonQuery();
            this.CloseConn();
        }

        public string[] Search(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, DBConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            string[] array = new string[5];
            array[0] = reader.GetString(0);
            array[1] = reader.GetString(1);
            array[2] = reader.GetString(2);
            array[3] = reader.GetString(3);
            array[4] = reader.GetString(4);
            array[5] = reader.GetString(5);
            return array;
        }


        public void Delete() { }
    }
}