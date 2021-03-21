using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.classes;



namespace TestApp.classes
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            /*  Movie obj = new Movie();
              Movie [] test = obj.getAllMovies();
              for (int i = 0; i < test.Length; i++) 
              {
                 Console.WriteLine(test[i].Gentre);
              }
              Console.WriteLine(test.Length);
              Console.ReadLine();*/
            Movie obj = new Movie();
            List<Movie> movies = obj.getAllMovies();
            Console.WriteLine("\n");
            foreach (Movie movie in movies)
            {
                Console.WriteLine("Id: " + movie.Id +" --|-- " + "Category: Movie" + " --|-- " + "Gentre: " + movie.Gentre + " --|-- " + "Year: " + movie.Year + " --|-- " + "Release: " + movie.Release);
                Console.WriteLine("\n");
            }
            Console.WriteLine("Results: " + movies.Count());
            Console.ReadLine();

        }
    }
}
