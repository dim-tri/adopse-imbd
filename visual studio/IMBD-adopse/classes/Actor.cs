using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace IMBD_adopse.classes
{
    class Actor
    {

        //actor properties
        private int id;
        private int category_id;
        private int movie_id;
        private string name;
        private string image;
        private string bio;
        private string born;
        private string filmography;
        private string role;
        private string created_at;
        private string updated_at;
        private string error;

        //movie constructor
        public Actor() { }

        //get - set properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Category_id
        {
            get { return category_id; }
            set { category_id = value; }
        }

        public int Movie_id
        {
            get { return movie_id; }
            set { movie_id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public string Bio
        {
            get { return bio; }
            set { bio = value; }
        }

        public string Born
        {
            get { return born; }
            set { born = value; }
        }

        public string Filmography
        {
            get { return filmography; }
            set { filmography = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string Created_at
        {
            get { return created_at; }
            set { created_at = value; }
        }

        public string Updated_at
        {
            get { return updated_at; }
            set { updated_at = value; }
        }

        public string Error
        {
            get { return error; }
            set { error = value; }
        }


        //functions
        //function to get all actors
        public List<Actor> getActors()
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                string sql = "SELECT * FROM actors";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int num_collumns = reader.FieldCount;
                List<Actor> actors = new List<Actor>();
                while (reader.Read())
                {

                    //actors.Add(new Actor { Id = (int)reader[0], Category_id = (int)reader[1], Movie_id = (int)reader[2], Name = (string)reader[3], Image = (string)reader[4], Bio = (string)reader[5], Born = (string)reader[6], Filmography = (string)reader[7], Role = (string)reader[10]});
                    actors.Add(new Actor { Id = (int)reader[0], Category_id = (int)reader[1],Name = (string)reader[3]});
                }
                reader.Close();
                db.connectionClose();

                return actors;
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


        //function to get all actors who plays on movies
        public List<Actor> getActorsPlaysMovies()
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                string sql = "SELECT m.id as movieID,a.id , a.name as actorName,a.role FROM `movies` m INNER JOIN `actors` a ON(m.id = a.movie_id)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int num_collumns = reader.FieldCount;
                List<Actor> actors = new List<Actor>();
                while (reader.Read())
                {

                    //actors.Add(new Actor { Id = (int)reader[0], Category_id = (int)reader[1], Movie_id = (int)reader[2], Name = (string)reader[3], Image = (string)reader[4], Bio = (string)reader[5], Born = (string)reader[6], Filmography = (string)reader[7], Role = (string)reader[10]});
                    actors.Add(new Actor { Movie_id = (int)reader[0], Id = (int)reader[1], Name = (string)reader[2], Role = ((string)reader[3]).Trim() });
                }
                reader.Close();
                db.connectionClose();

                return actors;
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

        public bool setNewActor(Actor obj)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO `actors`(`category_id`,`movie_id`,`name`,`image`,`bio`,`born`,`filmography`,`role`) VALUES(@cat_id,@movieid,@name,@image,@bio,@born,@filmography,@role)";
                cmd.Parameters.AddWithValue("@cat_id", 3);
                cmd.Parameters.AddWithValue("@movieid", obj.Movie_id);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@image", obj.Image);
                cmd.Parameters.AddWithValue("@bio", obj.Bio);
                cmd.Parameters.AddWithValue("@born", obj.Born);
                cmd.Parameters.AddWithValue("@filmography", obj.Filmography);
                cmd.Parameters.AddWithValue("@role", obj.Role);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
               // long newId = cmd.LastInsertedId;
                //int newId = Convert.ToInt32(cmd.ExecuteScalar());
              //  Debug.WriteLine("Movie Created !!");
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }


            return false;
        }

        //actors plays to specific movie

        public List<Actor> getActorsSpecificMovies(int id)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                string sql = "SELECT a.name as actorName FROM `movies` m INNER JOIN `actors` a ON(m.id = a.movie_id) where m.id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                int num_collumns = reader.FieldCount;
                List<Actor> actors = new List<Actor>();
                while (reader.Read())
                {

                    //actors.Add(new Actor { Id = (int)reader[0], Category_id = (int)reader[1], Movie_id = (int)reader[2], Name = (string)reader[3], Image = (string)reader[4], Bio = (string)reader[5], Born = (string)reader[6], Filmography = (string)reader[7], Role = (string)reader[10]});
                    actors.Add(new Actor { Name = (string)reader[0]});
                }
                reader.Close();
                db.connectionClose();

                return actors;
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
