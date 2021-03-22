using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace IMBD_adopse
{
    class DbConnection
    {
       /* private readonly string server = "localhost";
        private readonly string user = "root";
        private readonly string database = "imdb";
        private readonly string port = "3306";
        private readonly string pass = "";*/

        private readonly string server = "moviesaws.caurajhi4gjd.us-east-2.rds.amazonaws.com";
        private readonly string user = "admin";
        private readonly string database = "imdb";
        private readonly string port = "3306";
        private readonly string pass = "Stoy22339!";

        static string connStr = "";
        public static MySqlConnection conn;

        //constructor to initialize db connection
        public DbConnection() 
        {
            connStr = "server=" + server + ";" + "user=" + user + ";" + "database=" + database + ";" + "port=" + port + ";" + "password=" + pass + ";charset=utf8;";
           // conn = new MySqlConnection(connStr);
            
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                Console.WriteLine("Connected to database: " + database + " succesfully");
                Console.WriteLine("Status: " + conn.State.ToString());
            }
            catch (MySqlException ex)
            {
                // Console.WriteLine("Error: " + ex.ToString());
                Console.WriteLine("Error: " + ex.Message);
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

        public MySqlConnection Conn
        {
            get { return conn; }
           
        }




    }
}
