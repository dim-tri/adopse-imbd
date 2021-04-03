using IMBD_adopse.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IMBD_adopse
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            loadHome();
        }

        //load home movies
        public void loadHome()
        {
            //stougiannou Endeiktikh Prosegisi
            Movie obj = new Movie();
            List<Movie> movies = obj.getTopMovies();
            foreach (Movie movie in movies)
            {
                PictureBox movieImage = new PictureBox();
                movieImage.ImageLocation = movie.Photo;
                movieImage.SizeMode = PictureBoxSizeMode.AutoSize;

                movieImage.Click += (sender, e) =>
                {
                    GlimpseForm glimpseForm = new GlimpseForm(movie.Id);
                    glimpseForm.Show();
                };
                flowPanelTopMovies.Controls.Add(movieImage);
            }

            Movie obj2= new Movie();
            List<Movie> movies2 = obj.getMovies(10,"desc");
            foreach (Movie movie2 in movies2)
            {
                PictureBox movieImage = new PictureBox();
                movieImage.ImageLocation = movie2.Photo;
                movieImage.SizeMode = PictureBoxSizeMode.AutoSize;
                movieImage.Click += (sender, e) =>
                {
                    GlimpseForm glimpseForm = new GlimpseForm(movie2.Id);
                    glimpseForm.Show();
                };
                flowPanelNewReleases.Controls.Add(movieImage);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fill New Releases with random movies
            /* for (int i = 0; i < 6; i++)
             {
                 //Get DB data
                 Movie obj = new Movie();
                 List<Movie> movies = obj.getMovies(11 + i);

                 //Create Picture Box
                 PictureBox movieImage = new PictureBox();
                 movieImage.ImageLocation = movies[0].Photo;
                 movieImage.SizeMode = PictureBoxSizeMode.AutoSize;

                 //Add Click Event
                 movieImage.Click += (sender, e) =>
                 {
                     GlimpseForm glimpseForm = new GlimpseForm(movies[0].Id);
                     glimpseForm.Show();
                 };

                 //Assign to Flow Panel
                 flowPanelNewReleases.Controls.Add(movieImage);
             }*/

            //Fill Top Movies with random movies
            /*  for (int i = 0; i < 6; i++)
              {
                  //Get DB data
                  Movie obj = new Movie();
                  List<Movie> movies = obj.getMovies(21 + i);

                  //Create Picture Box
                  PictureBox movieImage = new PictureBox();
                  movieImage.ImageLocation = movies[0].Photo;
                  movieImage.SizeMode = PictureBoxSizeMode.AutoSize;

                  //Add Click Event
                  movieImage.Click += (sender, e) =>
                  {
                      GlimpseForm glimpseForm = new GlimpseForm(movies[0].Id);
                      glimpseForm.Show();
                  };

                  //Assign to flow panel
                  flowPanelTopMovies.Controls.Add(movieImage);
              }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            loginpage.Show();
        }
    }
}
