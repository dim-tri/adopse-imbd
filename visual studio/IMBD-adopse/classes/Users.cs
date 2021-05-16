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
                    db = new DbConnection();
                    conn = db.Conn;
                    sql = "UPDATE users SET loggedIn = TRUE WHERE id = @id";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", this.Id);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    return true;
                }
               
            }
            catch(MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }

            return false;
        }


        public bool logout(int id) 
        {
              try
              {
                  //Debug.WriteLine("User id: " + id);
                  DbConnection db = new DbConnection();
                  MySqlConnection conn = db.Conn;
                  string sql = "SELECT * FROM users where id = @id";
                  MySqlCommand cmd = new MySqlCommand(sql, conn);
                  cmd.Parameters.AddWithValue("@id", id);
                  cmd.Prepare();
                  MySqlDataReader reader = cmd.ExecuteReader();
                  if (!reader.HasRows) { return false; }
                  //Debug.WriteLine("User id: " + id);
                  reader.Close();
                  db.connectionClose();
                  db = new DbConnection();
                  conn = db.Conn;
                  sql = "UPDATE users SET loggedIn = 'FALSE' WHERE id = @id2";
                  cmd = new MySqlCommand(sql, conn);
                  cmd.Parameters.AddWithValue("@id2", id);
                  cmd.Prepare();
                  cmd.ExecuteNonQuery();
                  reader.Close();
                  db.connectionClose();
                  return true;
              }
              catch (MySqlException ex)
              {
                  Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
              }

              return false;
        }

        public string getUserStatus(int id) 
        {
            try
            {
                string status = "";
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                string sql = "SELECT * FROM users where id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows) { return null; }
                while (reader.Read())
                {
                    status = (string)reader[7];
                }
                reader.Close();
                db.connectionClose();
                return status;
            }
            catch (MySqlException ex) 
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }
            return null;
        }


        public bool registerUser(string name, string surname,string email,string password,string username) 
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                string sql = "INSERT INTO users(name,surname,email,password,username) VALUES(@name,@surname,@email,@password,@username)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                db.connectionClose();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }
            return false;
        }



        public Users getUserAll(int id)
        {
            try
            {
                Users user = new Users();
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                string sql = "SELECT * FROM users where id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows) { return null; }
                while (reader.Read())
                {
                    user.id = (int)reader[0];
                    user.name = (string)reader[1];
                    user.surname = (string)reader[2];
                    user.email = (string)reader[3];
                    user.password = (string)reader[4];
                    user.role = (string)reader[5];
                    user.username = (string)reader[6];
                    user.loggedin = (string)reader[7];
                }
                reader.Close();
                db.connectionClose();
                return user;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }
            return null;
        }


        public Boolean UpdateUserData(Users obj)
        {
            try
            {
                Users user = obj;
               // Debug.WriteLine("ID: " + user.Id);
            //    Debug.WriteLine("User: " + user.Password);
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
            
                if(obj.name != null)
                {
                    string sql = "UPDATE users set name = @name where id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", obj.id);
                    cmd.Parameters.AddWithValue("@name", obj.name);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }

                if (obj.surname != null)
                {
                    string sql = "UPDATE users set surname = @sur where id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", obj.id);
                    cmd.Parameters.AddWithValue("@sur", obj.surname);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }

                if (obj.email != null)
                {

                    string sql = "UPDATE users set email = @email where id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", obj.id);
                    cmd.Parameters.AddWithValue("@email", obj.email);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }

                if (obj.username != null)
                {
                    string sql = "UPDATE users set username = @user where id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", obj.id);
                    cmd.Parameters.AddWithValue("@user", obj.username);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }

                if (obj.password != null)
                {
                    string sql = "UPDATE users set password = @pass where id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", obj.id);
                    cmd.Parameters.AddWithValue("@pass", obj.password);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }

                db.connectionClose();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }
            return false;
        }


    }
}
