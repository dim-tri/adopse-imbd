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
            //stougiannou Endeiktikh Prosegisi
            //load top movies
            Movie obj = new Movie();
            List<Movie> movies = obj.getTopMovies();
            foreach (Movie movie in movies)
            {
                PictureBox movieImage = new PictureBox();
                movieImage.ImageLocation = movie.Photo;
                // movieImage.SizeMode = PictureBoxSizeMode.AutoSize;
                movieImage.Size = new System.Drawing.Size(200, 240);
                movieImage.SizeMode = PictureBoxSizeMode.CenterImage;
                movieImage.SizeMode = PictureBoxSizeMode.StretchImage;
                movieImage.BorderStyle = BorderStyle.Fixed3D;

                movieImage.Click += (sender, e) =>
                {

                    GlimpseForm glimpseForm = new GlimpseForm(MainWindow, movie.Id);
                    // GlimpseForm glimpseForm = new GlimpseForm(movie.Id);
                    Debug.WriteLine("User id from homeform: " + userID);
                    glimpseForm.setUserId(MainWindowForm.getUserID());
                    glimpseForm.Show();
                };
                flowPanelTopMovies.Controls.Add(movieImage);
            }
            //load 10 movies
            Movie obj2= new Movie();
            List<Movie> movies2 = obj.getMovies(10,"desc");
            foreach (Movie movie2 in movies2)
            {
                PictureBox movieImage = new PictureBox();
                movieImage.ImageLocation = movie2.Photo;
                //movieImage.SizeMode = PictureBoxSizeMode.AutoSize;
                movieImage.Size = new System.Drawing.Size(200, 240);
                movieImage.SizeMode = PictureBoxSizeMode.CenterImage;
                movieImage.SizeMode = PictureBoxSizeMode.StretchImage;
                movieImage.BorderStyle = BorderStyle.Fixed3D;
                movieImage.Click += (sender, e) =>
                {
                    GlimpseForm glimpseForm = new GlimpseForm(MainWindow, movie2.Id);
                    //GlimpseForm glimpseForm = new GlimpseForm(movie2.Id);
                    glimpseForm.setUserId(MainWindowForm.getUserID());
                    glimpseForm.Show();
                };
                flowPanelNewReleases.Controls.Add(movieImage);
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
