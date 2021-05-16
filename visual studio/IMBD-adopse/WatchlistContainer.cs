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
    public partial class WatchlistContainer : Form
    {
        private Movie Movie;
        private MainWindowForm MainForm;

        public WatchlistContainer(MainWindowForm mainForm, Movie movie)
        {
            this.MainForm = mainForm;
            this.Movie = movie;
            InitializeComponent();
            GlimpseForm_Load();
        }

        //Load Movie Info
        private void GlimpseForm_Load()
        {
            //Data to Form
            MovieImage.ImageLocation = Movie.Photo;

            MovieImage.Size = new System.Drawing.Size(180, 210);
            MovieImage.SizeMode = PictureBoxSizeMode.CenterImage;
            MovieImage.SizeMode = PictureBoxSizeMode.StretchImage;

            MovieDesc.Text = Movie.Plot;
            MovieTitle.Text = Movie.Name;
            MovieRuntime.Text = Movie.Duration;
            MovieYear.Text = Movie.Year.ToString();
            MovieRating.Text = Movie.Rank.ToString();

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            WishlistMovie wishlist = new WishlistMovie();
            if (wishlist.Remove(MainWindowForm.getUserID(), this.Movie.Id)) { MessageBox.Show("Successfully removed movie from wishlist.", "Wishlist"); }
            MainForm.LoadWatchlistPage();
        }

        private void MovieImage_Click(object sender, EventArgs e)
        {
            MainForm.LoadMoviePage(Movie.Id);
        }
    }
}
