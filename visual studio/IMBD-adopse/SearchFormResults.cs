using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMBD_adopse.classes;

namespace IMBD_adopse
{

    public partial class SearchFormResults : Form
    {
        private MainWindowForm MainWindow;
        public static string searchQuery = null;

        public SearchFormResults(MainWindowForm mainWindow)
        {
            this.MainWindow = mainWindow;
            InitializeComponent();
            
        }

        public void loadSearch()
        {

            MovieTeiApiSearch obj = new MovieTeiApiSearch(searchQuery);
            IEnumerable<Movie> movies = obj.Search();
         /*   foreach(Movie m in movies)
            {
                SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, m) { TopLevel = false, TopMost = true };
                searchFlowPanel.Controls.Add(movieContainer);
                movieContainer.Show();
            }*/

            for(int i = 0; i < movies.Count()-1; i++)
            {
                SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, movies.ElementAt(i)) { TopLevel = false, TopMost = true };
                searchFlowPanel.Controls.Add(movieContainer);
                movieContainer.Show();

            }


        }



    }
}
