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
    class userRating
    {
        private int user_id;
        private int movie_id;
        private double rank;

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

        public double Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public userRating() { }

        public bool setRating(int userID , int movieID , double rating) 
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO `users_reviews`(`user_id`,`movie_id`,`rank`) VALUES(@userid,@movieid,@rank)";
                cmd.Parameters.AddWithValue("@userid", userID);
                cmd.Parameters.AddWithValue("@movieid", movieID);
                cmd.Parameters.AddWithValue("@rank", rating);
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



    }
}
