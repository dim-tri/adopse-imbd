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
using System.Diagnostics;

namespace IMBD_adopse
{
    /// <summary>
    /// This is a dynamicaly filled form that desplays a glimpse of the provided movie.
    /// The movie is defined by the id provided to the constructor
    /// </summary>
    public partial class GlimpseForm : Form
    {
        //Id of the movie to glimpse
        private int MovieID;

        public GlimpseForm(int movieId)
        {
            this.MovieID = movieId;
            InitializeComponent();
           
        }
        

        private void GlimpseForm_Load(object sender, EventArgs e)
        {
            //Get DB data
            Movie obj = new Movie();
            List<Movie> movies = obj.getMovies(MovieID);

            //Data to Form
            MovieImage.ImageLocation = movies[0].Photo;
            MovieDesc.Text = movies[0].Plot;
            MovieTitle.Text = movies[0].Name;
            MovieRuntime.Text = movies[0].Duration;
            MovieYear.Text = movies[0].Year.ToString();
            MovieRating.Text = movies[0].Rank.ToString();

        }
        
        //'X' Button Click Event
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WishlistButton_Click(object sender, EventArgs e)
        {
            //TO-DO: Add movied id to wishlist database
            WishlistMovie wishlist = new WishlistMovie();
            if (wishlist.Add(userID, this.MovieID)) { MessageBox.Show("Successfully added movie to wishlist.", "Wishlist"); }
        }

        public int userID;
        private void checkUserLoggedIn()
        {
           // Debug.WriteLine("User iD: " + userID);
            if (userID != 0) {
                WishlistButton.Enabled = true;
                WishlistRemoveBtn.Enabled = true;
                checkWishlistMovieExists();
            }
            else
            {
                WishlistButton.Enabled = false;
                WishlistRemoveBtn.Enabled = false;
            }
            
        }

        public void setUserId(int id)
        {
            userID = id;
            checkUserLoggedIn();
        }

        private void WishlistRemoveBtn_Click(object sender, EventArgs e)
        {
            WishlistMovie wishlist = new WishlistMovie();
            if (wishlist.Remove(userID, this.MovieID)) { MessageBox.Show("Successfully removed movie from wishlist.", "Wishlist"); }
        }


        private void checkWishlistMovieExists() 
        {
            WishlistMovie wishlist = new WishlistMovie();
            if (wishlist.check(userID, this.MovieID))
            {
                WishlistButton.Enabled = false;
                WishlistRemoveBtn.Enabled = true;
            }
            else
            {
                WishlistButton.Enabled = true;
                WishlistRemoveBtn.Enabled = false;
            }


        }

    }
}
