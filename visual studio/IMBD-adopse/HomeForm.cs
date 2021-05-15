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

        
        }
        
        //Load Recommended}
        public void loadRecommended()
        {
            
            if (userID == 0)//Guest
            {
                recommendedLabel.Text = "Featured Movies";
                //load 10 movies
                Movie obj = new Movie();
                List<Movie> newMovies = obj.getMovies(20, "desc");
                for (int i=10; i<20; i++)
                {
                    SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, newMovies[i]) { TopLevel = false, TopMost = true };
                    flowPanelRecommended.Controls.Add(movieContainer);
                    movieContainer.Show();
                }
            }
            else //User logged in
            {
                recommendedLabel.Text = "Recommended For You - " + MainWindow.getUserGenre();
            }
        }


        public int userID;
       
       
        //trexon user id tou sundedemenou
        public void setUserID(int id) 
        {
            userID = id;
        }


        public void Recommendations()
        {

            if (userID == 0)//Guest
            {
                recommendedLabel.Text = "Featured Movies";
                //load 10 movies
                Movie obj = new Movie();
                List<Movie> newMovies = obj.getMovies(20, "desc");
                for (int i = 10; i < 20; i++)
                {
                    SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, newMovies[i]) { TopLevel = false, TopMost = true };
                    flowPanelRecommended.Controls.Add(movieContainer);
                    movieContainer.Show();
                }
            }
            else //User logged in
            {
                try
                {


                    recommendedLabel.Text = "Recommended For You ";
                    MovieTeiApiRecommends obj = new MovieTeiApiRecommends(userID);
                    IEnumerable<Movie> mov = obj.recommends();
                    if(mov == null) { return; }
                    foreach (Movie m in mov)
                    {
                        SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, m) { TopLevel = false, TopMost = true };
                        flowPanelRecommended.Controls.Add(movieContainer);
                        movieContainer.Show();
                    }
                }catch(Exception e)
                {
                    Debug.WriteLine(e.Message);
                }

            }
        }
    }
}
