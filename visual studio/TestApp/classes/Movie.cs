using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TestApp.classes
{
    class Movie
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

        //movie constructor
        public Movie() {}

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

        //functions
        public List<Movie> getAllMovies() 
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
                    for (int i = 0; i < num_collumns; i++)
                    {
                        //Console.Write(reader[i] + "--");
                        
                    }
                movies.Add(new Movie {Id = (int)reader[0],Gentre = reader[8].ToString(),Year =(int) reader[3],Release = reader[9].ToString() });
                }
                 reader.Close();
                 db.connectionClose();
             
                return movies ;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message + "\n" + "Code: " + ex.Code);
            }
            return null;
            
        }


    }
}
