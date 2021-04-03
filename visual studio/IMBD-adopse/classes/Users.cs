using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace IMBD_adopse.classes
{
    class Users
    {
        // users properties
        private int id;
        private string name;
        private string surname;
        private string email;
        private string password;
        private string role;
        private string username;
        private string loggedin;

        //users constructor
        public Users() { }

        //getters - setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Loggedin
        {
            get { return loggedin; }
            set { loggedin = value; }
        }

        // function to make auth 
        //check users credentials
        public bool Auth(string user , string password)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                string sql = "SELECT * FROM users where username = @user limit 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows) { return false; }
                while (reader.Read())
                {
                 this.id  =(int) reader[0];
                 this.Name =(string) reader[1];
                 this.Surname = (string) reader[2];
                 this.Email = (string)reader[3];
                 this.Password = (string)reader[4];
                 this.Role = (string)reader[5];
                 this.Username = (string)reader[6];
                 this.Loggedin = (string)reader[7];
                }
                reader.Close();
                db.connectionClose();

                if(this.Username == user && this.Password == password)
                {
                    return true;
                }
               
            }
            catch(MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }

            return false;
        }


        public bool logout() { return true; }





    }
}
