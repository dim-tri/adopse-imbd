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
    class Comments
    {

        private int id;
        private int user_id;
        private int movie_id;
        private string comment;

        public Comments() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
        public int Movie_id
        {
            get { return movie_id; }
            set { movie_id = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public bool setComment(int userID, int movieID, string comm)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO `comments`(`user_id`,`movie_id`,`comment`) VALUES(@userid,@movieid,@comment)";
                cmd.Parameters.AddWithValue("@userid", userID);
                cmd.Parameters.AddWithValue("@movieid", movieID);
                cmd.Parameters.AddWithValue("@comment", comm);
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


        public bool check(int userID, int movieID)
        {
            try
            {
                bool exists = false;
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader reader;
                cmd.Connection = conn;
                cmd.CommandText = "SELECT *  FROM `comments` WHERE user_id=@userid AND movie_id=@movieid";
                cmd.Parameters.AddWithValue("@userid", userID);
                cmd.Parameters.AddWithValue("@movieid", movieID);
                cmd.Prepare();
                reader = cmd.ExecuteReader();
                if (reader.HasRows) { exists = true; }
                while (reader.Read())
                {
                    this.Comment = (string)reader[3];
                    this.User_id = (int)reader[1];
                }
                reader.Close();
                db.connectionClose();
                return exists;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }

            return false;
        }


        public List<Comments> getComments(int movieID)
        {
               try
               {
                   // bool exists = false;
                   DbConnection db = new DbConnection();
                   MySqlConnection conn = db.Conn;
                   MySqlCommand cmd = new MySqlCommand();
                   MySqlDataReader reader;
                   cmd.Connection = conn;
                   cmd.CommandText = "SELECT *  FROM `comments` WHERE movie_id=@movieid";
                   cmd.Parameters.AddWithValue("@movieid", movieID);
                   cmd.Prepare();
                   reader = cmd.ExecuteReader();
                // if (reader.HasRows) { exists = true; }
                List<Comments> comments = new List<Comments>();
                while (reader.Read())
                   {
                    comments.Add(new Comments { Id = (int)reader[0], User_id = (int)reader[1],Movie_id = (int)reader[2],Comment = (string)reader[3] });

                }
                reader.Close();
                   db.connectionClose();
                return comments;
               }
               catch (MySqlException ex)
               {
                   Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
               }
            
            return null;
        }





    }
}
