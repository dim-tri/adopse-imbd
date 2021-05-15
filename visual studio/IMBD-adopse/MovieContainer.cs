using IMBD_adopse.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMBD_adopse
{
    public partial class MovieContainer : Form
    {
        //Movie to display
        private Movie Movie;
        private MainWindowForm MainForm;

        public MovieContainer(MainWindowForm mainForm, Movie movie)
        {
            this.MainForm = mainForm;
            this.Movie = movie;
            InitializeComponent();
            LoadMovieInfo();
        }

        //Load Movie Info
        private void LoadMovieInfo()
        {
            //Data to Form
            MovieImage.ImageLocation = Movie.Photo;

            MovieImage.Size = new System.Drawing.Size(183, 239);
            MovieImage.SizeMode = PictureBoxSizeMode.CenterImage;
            MovieImage.SizeMode = PictureBoxSizeMode.StretchImage;

            MovieDesc.Text = Movie.Plot;
            MovieTitle.Text = Movie.Name;
            MovieRuntime.Text = Movie.Duration;
            MovieYear.Text = Movie.Year.ToString();
            MovieRating.Text = Movie.Rank.ToString();
            MovieGenre.Text = Movie.Gentre;

        }

        private void GlimpseButton_Click(object sender, EventArgs e)
        {
            GlimpseForm glimpse = new GlimpseForm(MainForm, Movie);
            glimpse.Show();
        }

        private void MovieImage_Click(object sender, EventArgs e)
        {
            MainForm.LoadMoviePage(Movie.Id);
        }
    }
}
