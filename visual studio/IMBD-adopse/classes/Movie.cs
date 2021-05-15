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
    public class Movie
    {
        //movie properties
        private int id;
        private int category_id;
        private string name;
        private int year;
        private double rank;
        private string director;
        private string stars;
        private string duration;
        private string gentre;
        private string release;
        private string plot;
        private string photo;
        private string created_at;
        private string updated_at;
        private string error;

        //movie constructor
        public Movie() { }

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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public string Stars
        {
            get { return stars; }
            set { stars = value; }
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public string Gentre
        {
            get { return gentre; }
            set { gentre = value; }
        }

        public string Release
        {
            get { return release; }
            set { release = value; }
        }

        public string Plot
        {
            get { return plot; }
            set { plot = value; }
        }

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
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
        //function to get all movies
        public List<Movie> getMovies()
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                string sql = "SELECT * FROM movies";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int num_collumns = reader.FieldCount;
                List<Movie> movies = new List<Movie>();
                while (reader.Read())
                {
                    movies.Add(new Movie { Id = (int)reader[0], Gentre = reader[8].ToString(), Name = (string)reader[2], Year = (int)reader[3], Rank = (double)reader[4], Release = reader[9].ToString(), Director = (string)reader[5], Stars = (string)reader[6], Duration = (string)reader[7], Plot = (string)reader[10], Photo = (string)reader[11] });
                }
                reader.Close();
                db.connectionClose();

                return movies;
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

        //fucntion to get one movie by id
        public List<Movie> getMovies(int id)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM movies WHERE id = @id Limit 1";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                int num_collumns = reader.FieldCount;
                List<Movie> movies = new List<Movie>();
                while (reader.Read())
                {
                    movies.Add(new Movie { Id = (int)reader[0], Gentre = reader[8].ToString(), Name = (string)reader[2], Year = (int)reader[3], Rank = (double)reader[4], Release = reader[9].ToString(), Director = (string)reader[5], Stars = (string)reader[6], Duration = (string)reader[7], Plot = (string)reader[10], Photo = (string)reader[11] });
                }
                reader.Close();
                db.connectionClose();

                return movies;
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

        //fucntion to get specified results of movies offers sorting by year (both acsending and descending order)
        public List<Movie> getMovies(int res, string sort)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                MySqlDataReader reader;

                if (sort == "asc")
                {
                    cmd.CommandText = "SELECT * FROM movies ORDER BY year ASC LIMIT @res";
                    cmd.Parameters.AddWithValue("@res", res);
                    cmd.Prepare();
                    reader = cmd.ExecuteReader();

                    List<Movie> movies = new List<Movie>();
                    while (reader.Read())
                    {
                        movies.Add(new Movie { Id = (int)reader[0], Gentre = reader[8].ToString(), Name = (string)reader[2], Year = (int)reader[3], Rank = (double)reader[4], Release = reader[9].ToString(), Director = (string)reader[5], Stars = (string)reader[6], Duration = (string)reader[7], Plot = (string)reader[10], Photo = (string)reader[11] });
                    }
                    reader.Close();
                    db.connectionClose();

                    return movies;
                }
                else if (sort == "desc")
                {
                    cmd.CommandText = "SELECT * FROM movies ORDER BY year DESC LIMIT @res";
                    cmd.Parameters.AddWithValue("@res", res);
                    cmd.Prepare();
                    reader = cmd.ExecuteReader();

                    List<Movie> movies = new List<Movie>();
                    while (reader.Read())
                    {
                        movies.Add(new Movie { Id = (int)reader[0], Gentre = reader[8].ToString(), Name = (string)reader[2], Year = (int)reader[3], Rank = (double)reader[4], Release = reader[9].ToString(), Director = (string)reader[5], Stars = (string)reader[6], Duration = (string)reader[7], Plot = (string)reader[10], Photo = (string)reader[11] });
                    }
                    reader.Close();
                    db.connectionClose();

                    return movies;
                }
                else
                {
                    return null;
                }

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

        // function to set new movie
        public long setNewMovie(Movie obj)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO `movies`(`category_id`,`name`,`year`,`rank`,`director`,`stars`,`duration`,`gentre`,`release`,`plot`,`photo`) VALUES(@cat_id,@name,@year,@rank,@director,@stars,@duration,@gentre,@release,@plot,@photo)";
                cmd.Parameters.AddWithValue("@cat_id", obj.Category_id);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@year", obj.Year);
                cmd.Parameters.AddWithValue("@rank", obj.Rank);
                cmd.Parameters.AddWithValue("@director", obj.Director);
                cmd.Parameters.AddWithValue("@stars", obj.Stars);
                cmd.Parameters.AddWithValue("@duration", obj.Duration);
                cmd.Parameters.AddWithValue("@gentre", obj.Gentre);
                cmd.Parameters.AddWithValue("@release", obj.Release);
                cmd.Parameters.AddWithValue("@plot", obj.Plot);
                cmd.Parameters.AddWithValue("@photo", obj.Photo);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                long newId = cmd.LastInsertedId;
                //int newId = Convert.ToInt32(cmd.ExecuteScalar());
                Debug.WriteLine("Movie Created !!");
                return newId;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }


            return 0;
        }

        public List<Movie> Search(string query)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                MySqlDataReader reader;
                cmd.CommandText = "call search_movie(@query)";
                cmd.Parameters.AddWithValue("@query", query);
                cmd.Prepare();
                reader = cmd.ExecuteReader();
                List<Movie> movies = new List<Movie>();
                while (reader.Read())
                {
                    movies.Add(new Movie { Id = (int)reader[0], Gentre = reader[8].ToString(), Name = (string)reader[2], Year = (int)reader[3], Rank = (double)reader[4], Release = reader[9].ToString(), Director = (string)reader[5], Stars = (string)reader[6], Duration = (string)reader[7], Plot = (string)reader[10], Photo = (string)reader[11] });
                }

                reader.Close();
                db.connectionClose();
                return movies;

            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }
            return null;
        }

        public List<Movie> DynamicSearch(string query)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                MySqlDataReader reader;
                cmd.CommandText = "call search_movie(@query)";
                cmd.Parameters.AddWithValue("@query", query);
                cmd.Prepare();
                reader = cmd.ExecuteReader();
                List<Movie> movies = new List<Movie>();
                while (reader.Read())
                {
                    movies.Add(new Movie { Id = (int)reader[0], Gentre = reader[8].ToString(), Name = (string)reader[2], Year = (int)reader[3], Rank = (double)reader[4], Release = reader[9].ToString(), Director = (string)reader[5], Stars = (string)reader[6], Duration = (string)reader[7], Plot = (string)reader[10], Photo = (string)reader[11] });
                }

                if (movies.Count() == 0)
                {
                    ApiClient api = new ApiClient("http://www.omdbapi.com/", "?apikey=9d652152&type=movie&t=" + query);
                    ApiClient obj = api.getData();
                    if (obj.Response == "True")
                    {
                        List<Movie> movies2 = new List<Movie>();
                        //movies2.Add(new Movie { Id = 1, Gentre = obj.Genre, Name = obj.Title, Year = Int32.Parse(obj.Year), Rank = Convert.ToDouble(obj.imdbRating), Release = obj.Released, Director = obj.Director, Stars =obj.Actors, Duration = obj.Runtime, Plot = obj.Plot, Photo = obj.Poster });
                        Movie mov = new Movie();
                        mov.Category_id = 1;
                        mov.Gentre = obj.Genre;
                        mov.Name = obj.Title;
                        mov.Year = Int32.Parse(obj.Year);
                        // mov.Rank = Convert.ToDouble(obj.imdbRating);
                        // Debug.WriteLine("Prin to convert: " + obj.imdbRating);
                        //  Debug.WriteLine("Meta to convert: " + Double.Parse(obj.imdbRating));
                        obj.imdbRating = obj.imdbRating.Replace('.', ',');
                        mov.Rank = Double.Parse(obj.imdbRating);
                        mov.Release = obj.Released;
                        mov.Director = obj.Director;
                        mov.Stars = obj.Actors;
                        mov.Duration = obj.Runtime;
                        mov.Plot = obj.Plot;
                        mov.Photo = obj.Poster;
                        long newID = setNewMovie(mov);
                        Debug.WriteLine(newID);
                        movies2.Add(new Movie { Id = Convert.ToInt32(newID), Gentre = obj.Genre, Name = obj.Title, Year = Int32.Parse(obj.Year), Rank = Convert.ToDouble(obj.imdbRating), Release = obj.Released, Director = obj.Director, Stars = obj.Actors, Duration = obj.Runtime, Plot = obj.Plot, Photo = obj.Poster });
                        reader.Close();
                        db.connectionClose();
                        string[] actors_arr = mov.Stars.Split(',');
                        foreach (var act in actors_arr)
                        {
                            Actor actor = new Actor();
                            actor.Movie_id = (int)newID;
                            actor.Name = act;
                            actor.setNewActor(actor);
                        }    
                        return movies2;
                    }

                }
                reader.Close();
                db.connectionClose();
                return movies;

            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }
            return null;
        }



        public List<Movie> getTopMovies()
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.Conn;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                MySqlDataReader reader;
                cmd.CommandText = "call FillTopMoviesSeries()";
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT m.* FROM `top-movies` t INNER JOIN `movies` m ON(t.movie_id = m.id); ";
                cmd.Prepare();
                reader = cmd.ExecuteReader();
                List<Movie> movies = new List<Movie>();
                while (reader.Read())
                {
                    movies.Add(new Movie { Id = (int)reader[0], Gentre = reader[8].ToString(), Name = (string)reader[2], Year = (int)reader[3], Rank = (double)reader[4], Release = reader[9].ToString(), Director = (string)reader[5], Stars = (string)reader[6], Duration = (string)reader[7], Plot = (string)reader[10], Photo = (string)reader[11] });
                }

                reader.Close();
                db.connectionClose();
                return movies;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }

            return null;
        }



        public List<Movie> omdbApiSearch(string query)
        {
            ApiClient api = new ApiClient("http://www.omdbapi.com/", "?apikey=9d652152&type=movie&t=" + query);
            ApiClient obj = api.getData();
        /*    DbConnection db = new DbConnection();
            MySqlConnection conn = db.Conn;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            MySqlDataReader reader;*/
            if (obj.Response == "True")
            {
                List<Movie> movies2 = new List<Movie>();
                //movies2.Add(new Movie { Id = 1, Gentre = obj.Genre, Name = obj.Title, Year = Int32.Parse(obj.Year), Rank = Convert.ToDouble(obj.imdbRating), Release = obj.Released, Director = obj.Director, Stars =obj.Actors, Duration = obj.Runtime, Plot = obj.Plot, Photo = obj.Poster });
                Movie mov = new Movie();
                mov.Category_id = 1;
                mov.Gentre = obj.Genre;
                mov.Name = obj.Title;
                mov.Year = Int32.Parse(obj.Year);
                // mov.Rank = Convert.ToDouble(obj.imdbRating);
                // Debug.WriteLine("Prin to convert: " + obj.imdbRating);
                //  Debug.WriteLine("Meta to convert: " + Double.Parse(obj.imdbRating));
                obj.imdbRating = obj.imdbRating.Replace('.', ',');
                mov.Rank = Double.Parse(obj.imdbRating);
                mov.Release = obj.Released;
                mov.Director = obj.Director;
                mov.Stars = obj.Actors;
                mov.Duration = obj.Runtime;
                mov.Plot = obj.Plot;
                mov.Photo = obj.Poster;
                long newID = setNewMovie(mov);
                Debug.WriteLine(newID);
                movies2.Add(new Movie { Id = Convert.ToInt32(newID), Gentre = obj.Genre, Name = obj.Title, Year = Int32.Parse(obj.Year), Rank = Convert.ToDouble(obj.imdbRating), Release = obj.Released, Director = obj.Director, Stars = obj.Actors, Duration = obj.Runtime, Plot = obj.Plot, Photo = obj.Poster });
             //   reader.Close();
             //   db.connectionClose();
                string[] actors_arr = mov.Stars.Split(',');
                foreach (var act in actors_arr)
                {
                    Actor actor = new Actor();
                    actor.Movie_id = (int)newID;
                    actor.Name = act;
                    actor.setNewActor(actor);
                }
                return movies2;
            }

            return null;
        }






    }
}
