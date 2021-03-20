using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace TestApp.classes
{
    class DbConnection
    {
        private string server = "localhost";
        private string user = "root";
        private string database = "imdb";
        private string port = "3306";
        private string pass = "";
        static string connStr = "";
        MySqlConnection conn = new MySqlConnection();

        //constructor to initialize db connection
        public DbConnection() 
        {
            connStr = "server=" + server + ";" + "user=" + user + ";" + "database=" + database + ";" + "port=" + port + ";" + "password=" + pass + ";charset=utf8;";
            conn = new MySqlConnection(connStr);
            
            try
            {
                conn.Open();
                Console.WriteLine("Connected to database: " + database + " succesfully");
                Console.WriteLine("Status: " + conn.State.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }

        //function to close db connection
        public void connectionClose()
        {
            conn.Close();
            Console.WriteLine("Connection Closed.");
            Console.WriteLine("Status: " + conn.State.ToString());

        }

        //fucntion to query database
        public void query(string sql) 
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int num_collumns = reader.FieldCount;
               
                while (reader.Read())
                {
                    for (int i = 0; i < num_collumns; i++) 
                        {
                            Console.Write(reader[i] + "--");
                        }
                    Console.WriteLine();
                   
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }
        }

        //function to insert data to db (prepared statement)
        public void prepare(string sql,params string[] list)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                for (int i = 0; i < list.Length; i++)
                {
                    string[] param = list[i].Split('=');
                    cmd.Parameters.AddWithValue(param[0],param[1]);
                }
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }

        }




    }
}
