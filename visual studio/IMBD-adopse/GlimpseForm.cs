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
        private MainWindowForm MainForm;
        private Movie Movie;


        public GlimpseForm(MainWindowForm mainForm, Movie movie)
        {
            this.MainForm = mainForm;
            this.Movie = movie;
            InitializeComponent();
            setUserId(MainWindowForm.getUserID());
        }
        

        //Load Movie Info from Id
        private void GlimpseForm_Load(object sender, EventArgs e)
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
        
        //'X' Button Click Event
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Add to Watchlist Button
        private void AddBtn_Click(object sender, EventArgs e)
        {
            WishlistMovie wishlist = new WishlistMovie();
            if (wishlist.Add(userID, Movie.Id)) { MessageBox.Show("Successfully added movie to wishlist.", "Wishlist"); }
        }
        
        //Button that opens the movie page of the currently displayed movie
        private void MoreButton_Click(object sender, EventArgs e)
        {
            //Load the Movie Page on main window
            MainForm.LoadMoviePage(Movie.Id);
            this.Close();
        }

        public int userID;
        private void checkUserLoggedIn()
        {
            Debug.WriteLine("User iD from glimpse: " + userID);
            if (userID != 0)
            {
                AddBtn.Enabled = true;
                RemoveBtn.Enabled = true;
                checkWishlistMovieExists();
            }
            else
            {
                AddBtn.Enabled = false;
                RemoveBtn.Enabled = false;
            }

        }

        public void setUserId(int id)
        {
            userID = id;
            checkUserLoggedIn();
        }


        private void checkWishlistMovieExists()
        {
            WishlistMovie wishlist = new WishlistMovie();
            if (wishlist.check(userID, Movie.Id))
            {
                AddBtn.Enabled = false;
                RemoveBtn.Enabled = true;
            }
            else
            {
                AddBtn.Enabled = true;
                RemoveBtn.Enabled = false;
            }


        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            WishlistMovie wishlist = new WishlistMovie();
            if (wishlist.Remove(userID, this.Movie.Id)) { MessageBox.Show("Successfully removed movie from wishlist.", "Wishlist"); }
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Black;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }

    }
}
