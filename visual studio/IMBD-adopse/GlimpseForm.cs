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
        
        //Id of the movie to glimpse
        private int MovieID;


        public GlimpseForm(MainWindowForm mainForm, int movieId)
        {
            this.MainForm = mainForm;
            this.MovieID = movieId;
            InitializeComponent();
           
        }
        

        //Load Movie Info from Id
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            WishlistMovie wishlist = new WishlistMovie();
            if (wishlist.Add(userID, this.MovieID)) { MessageBox.Show("Successfully added movie to wishlist.", "Wishlist"); }
        }
        
        //Button that opens the movie page of the currently displayed movie
        private void MoreButton_Click(object sender, EventArgs e)
        {
            //Load the Movie Page on main window
            MainForm.LoadMoviePage(MovieID);
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
            if (wishlist.check(userID, this.MovieID))
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
            if (wishlist.Remove(userID, this.MovieID)) { MessageBox.Show("Successfully removed movie from wishlist.", "Wishlist"); }
        }
    }
}
