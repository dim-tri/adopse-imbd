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
                List<Movie> movies = obj.getMovies();
                //List<Movie> moviess = movies.OrderBy(o => o.Name).ToList();
                Console.WriteLine("\n");
                foreach (Movie movie in movies)
                {
                    Console.WriteLine("Id: " + movie.Id + " --|-- " + "Category: Movie" + " --|-- " + "Name: " + movie.Name + " --|-- " + "Gentre: " + movie.Gentre + " --|-- " + "Year: " + movie.Year + " --|-- " + "Release: " + movie.Release + " --|-- " + "Rank: " + movie.Rank + " --|-- " + "Plot: " + movie.Plot);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("Results: " + movies.Count());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.ReadLine();

        

    }
    }
}
