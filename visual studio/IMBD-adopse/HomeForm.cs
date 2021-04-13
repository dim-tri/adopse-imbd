using IMBD_adopse.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace IMBD_adopse
{
    public partial class HomeForm : Form
    {
        //Parent Main window
        private MainWindowForm MainWindow;

        public HomeForm(MainWindowForm mainWindow)
        {
            this.MainWindow = mainWindow;
            InitializeComponent();
            loadHome();
        }

        //load home movies
        public void loadHome()
        {           
            //load Top Movies
            Movie obj = new Movie();
            List<Movie> topMovies = obj.getTopMovies();
            foreach (Movie movie in topMovies)
            {
                SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, movie) { TopLevel = false, TopMost = true };
                flowPanelTopMovies.Controls.Add(movieContainer);
                movieContainer.Show();
            }

            //load 10 movies
            List<Movie> newMovies = obj.getMovies(10, "desc");
            foreach (Movie movie in newMovies)
            {
                SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, movie) { TopLevel = false, TopMost = true };
                flowPanelNewReleases.Controls.Add(movieContainer);
                movieContainer.Show();
            }
           
            //Load Recommended
            Movie obj3 = new Movie();
            List<Movie> recMovies = obj3.getTopMovies();
            foreach (Movie movie in recMovies) {
                SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, movie) {TopLevel = false, TopMost = true };
                flowPanelRecommended.Controls.Add(movieContainer);
                movieContainer.Show();
            }


        }

        public int userID;
       
       
        //trexon user id tou sundedemenou
        public void setUserID(int id) 
        {
            userID = id;
        }

    }
}
