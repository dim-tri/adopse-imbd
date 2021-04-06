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
    class WishlistMovie
    {
        private int id;
        private int user_id;
        private int movie_id;

        //WishlistMovie constructor
        public WishlistMovie() { }

        //get - set properties

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

        public bool Add(int userID,int movieID) {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO `wishlistMovie`(`user_id`,`movie_id`) VALUES(@userid,@movieid)";
                cmd.Parameters.AddWithValue("@userid", userID);
                cmd.Parameters.AddWithValue("@movieid", movieID);
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


        public bool Remove(int userID, int movieID) 
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM `wishlistMovie` WHERE user_id=@userid AND movie_id=@movieid ";
                cmd.Parameters.AddWithValue("@userid", userID);
                cmd.Parameters.AddWithValue("@movieid", movieID);
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
                cmd.CommandText = "SELECT *  FROM `wishlistMovie` WHERE user_id=@userid AND movie_id=@movieid ";
                cmd.Parameters.AddWithValue("@userid", userID);
                cmd.Parameters.AddWithValue("@movieid", movieID);
                cmd.Prepare();
                reader = cmd.ExecuteReader();
                if (reader.HasRows) { exists = true; }
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


        public List<WishlistMovie> get(int userID)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader reader;
                cmd.Connection = conn;
                cmd.CommandText = "SELECT *  FROM `wishlistMovie` WHERE user_id=@userid";
                cmd.Parameters.AddWithValue("@userid", userID);
                cmd.Prepare();
                reader = cmd.ExecuteReader();
                List<WishlistMovie> wishlist = new List<WishlistMovie>();
                if (!reader.HasRows) { return wishlist=null; }
                while (reader.Read())
                {
                    wishlist.Add(new WishlistMovie { Id = (int)reader[0],User_id = (int)reader[1],Movie_id = (int)reader[2]});
                }
                reader.Close();
                db.connectionClose();
                return wishlist;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }
            return null; 
        }





    }
}
