using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMBD_adopse.classes;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace IMBD_adopse.classes
{
    class UserReviews
    {
        private string comment;
        private string name;
        private double rank;
        private int id;
        private int movie_id;

        public UserReviews() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public int Movie_id
        {
            get { return movie_id; }
            set { movie_id = value; }
        }


        public List<UserReviews> allReviews(int userid)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                string sql = "select c.comment , m.name ,m.id from users u inner join comments c on (u.id = c.user_id)  inner join movies m on (c.movie_id = m.id)  where u.id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", userid);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                int num_collumns = reader.FieldCount;
                List<UserReviews> reviews = new List<UserReviews>();
                List<UserReviews> ranks = allRanks(userid);
                while (reader.Read())
                {
                    foreach(UserReviews ur in ranks)
                    {
                        if((int)reader[2] == ur.Movie_id)
                        {
                            reviews.Add(new UserReviews { Comment = (string)reader[0], Name = (string)reader[1], Rank = ur.Rank });
                        }

                    }
                    
                }
                reader.Close();
                db.connectionClose();

                return reviews;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            return null;

        }


        public List<UserReviews> allRanks(int userid)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                string sql = "select r.rank,r.movie_id from users u inner join users_reviews r on (u.id = r.user_id)  where u.id = @id ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", userid);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                int num_collumns = reader.FieldCount;
                List<UserReviews> reviews = new List<UserReviews>();
                while (reader.Read())
                {
                    reviews.Add(new UserReviews { Rank = (double)reader[0], Movie_id = (int)reader[1]});
                }
                reader.Close();
                db.connectionClose();

                return reviews;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            return null;

        }


    }
}
