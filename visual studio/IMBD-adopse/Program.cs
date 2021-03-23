using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using IMBD_adopse.classes;

namespace IMBD_adopse
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            try
            {
                Movie obj = new Movie();
               // List<Movie> movies = obj.getMovies();
                //List<Movie> moviess = movies.OrderBy(o => o.Name).ToList();
                Debug.WriteLine("\n");
                /*      foreach (Movie movie in movies)
                      {
                          Debug.WriteLine("Id: " + movie.Id + " --|-- " + "Category: Movie" + " --|-- " + "Name: " + movie.Name + " --|-- " + "Gentre: " + movie.Gentre + " --|-- " + "Year: " + movie.Year + " --|-- " + "Release: " + movie.Release + " --|-- " + "Rank: " + movie.Rank + " --|-- " + "Plot: " + movie.Plot);
                          Debug.WriteLine("\n");
                      }
                      Debug.WriteLine("Results: " + movies.Count());*/
                obj.Category_id = 1;
                obj.Name = "test movie2";
                obj.Gentre = "Action";
                obj.Year = 2021;
                obj.Rank = 9.7;

                obj.setNewMovie(obj);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            
           

        

    }
    }
}
