using IMBD_adopse.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace IMBD_adopse
{
    public partial class HomeForm : Form
    {
        int indexTop = 0;
        int indexNew = 0;

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
            for (int i = 0; i < 5; i++)
            {
                SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, topMovies[i]) { TopLevel = false, TopMost = true };
                flowPanelTopMovies.Controls.Add(movieContainer);
                movieContainer.Show();
            }

            //load 10 movies
            List<Movie> newMovies = obj.getMovies(20, "desc");
            for (int i = 0; i < 5; i++)
            {
                SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, newMovies[i]) { TopLevel = false, TopMost = true };
                flowPanelNewReleases.Controls.Add(movieContainer);
                movieContainer.Show();
            }

            //Load Recommended
            Movie obj3 = new Movie();
            List<Movie> recMovies = obj3.getTopMovies();
            foreach (Movie movie in recMovies)
            {
                SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, movie) { TopLevel = false, TopMost = true };
                flowPanelRecommended.Controls.Add(movieContainer);
                movieContainer.Show();
            }
            pictureBoxPreviousTop.Hide();
            pictureBoxPreviousNew.Hide();

        }

        public int userID;


        //trexon user id tou sundedemenou
        public void setUserID(int id)
        {
            userID = id;
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Movie obj = new Movie();
            List<Movie> topMovies = obj.getTopMovies();
            pictureBoxPreviousTop.Show();
            if (indexTop + 5 < topMovies.Count)
            {
                flowPanelTopMovies.Controls.Clear();
                indexTop = indexTop + 5;
                for (int i = indexTop; i < indexTop + 5; i++)
                {
                    SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, topMovies[i]) { TopLevel = false, TopMost = true };
                    flowPanelTopMovies.Controls.Add(movieContainer);
                    movieContainer.Show();
                }
            }
            if (indexTop + 5 >= topMovies.Count)
            {
                pictureBoxNextTop.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Movie obj = new Movie();
            List<Movie> topMovies = obj.getTopMovies();
            pictureBoxNextTop.Show();
            if (indexTop > 0)
            {
                flowPanelTopMovies.Controls.Clear();
                indexTop = indexTop - 5;
                for (int i = indexTop; i < indexTop + 5; i++)
                {
                    SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, topMovies[i]) { TopLevel = false, TopMost = true };
                    flowPanelTopMovies.Controls.Add(movieContainer);
                    movieContainer.Show();
                }
            }
            if (indexTop <= 0)
            {
                pictureBoxPreviousTop.Hide();     
                }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBoxNextNew.Show();
            Movie obj = new Movie();
            List<Movie> newMovies = obj.getMovies(20, "desc");
            if (indexNew > 0)
            {
                flowPanelNewReleases.Controls.Clear();
                indexNew = indexNew - 5;
                for (int i = indexNew; i <indexNew + 5; i++)
                {
                    SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, newMovies[i]) { TopLevel = false, TopMost = true };
                    flowPanelNewReleases.Controls.Add(movieContainer);
                    movieContainer.Show();
                }
            }
            if (indexNew <= 0) 
            {
                pictureBoxPreviousNew.Hide();        
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBoxPreviousNew.Show();
            Movie obj = new Movie();
            List<Movie> newMovies = obj.getMovies(20, "desc");
            if (indexNew + 5 < newMovies.Count)
            {
                flowPanelNewReleases.Controls.Clear();
                indexNew = indexNew + 5;
                for (int i = indexNew; i < indexNew + 5; i++)
                {
                    SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, newMovies[i]) { TopLevel = false, TopMost = true };
                    flowPanelNewReleases.Controls.Add(movieContainer);
                    movieContainer.Show();
                }
            }
            if (indexNew + 5 >= newMovies.Count)
            {
                pictureBoxNextNew.Hide();
            }
        }
    }
}
