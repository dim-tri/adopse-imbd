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
    public partial class SingleMovieContainer : Form
    {
        private Movie Movie;
        private MainWindowForm MainForm;

        public SingleMovieContainer(MainWindowForm mainForm, Movie movie)
        {            
            Movie = movie;
            MainForm = mainForm;

            InitializeComponent();
            LoadMovie();
        }
        //Initialize form controls with movie info
        private void LoadMovie()
        {
            MoviePicture.ImageLocation = Movie.Photo;
            TitleLabel.Text = Movie.Name;
        }

        //Watchlist Button
        private void WatchlistButton_Click(object sender, EventArgs e)
        {

        }

        //Glimpse Button
        private void GlimpseButton_Click(object sender, EventArgs e)
        {
            GlimpseForm glimpse = new GlimpseForm(MainForm, Movie);
            glimpse.Show();
        }

        //Image Click
        private void MovieImage_Click(object sender, EventArgs e)
        {
            MainForm.LoadMoviePage(Movie.Id);
        }

        private void MoviePanel_MouseHover(object sender, EventArgs e)
        {
            GlimpseButton.Visible = true;
        }

        private void MoviePanel_MouseLeave(object sender, EventArgs e)
        {
            GlimpseButton.Visible = false;
        }
    }
}
