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
using IMBD_adopse.classes;

namespace IMBD_adopse
{
    public partial class WishlistForm : Form
    {
        public WishlistForm()
        {
            InitializeComponent();
        }
        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        } 

        public HomeForm obj;

        public void sendObjHome(int id)
        {
            userID = id;
            loadWishlist(id);
        }


        public void loadWishlist(int uid) 
        {
            Debug.WriteLine("test: " + uid);
            WishlistMovie wishlist = new WishlistMovie();
            List<WishlistMovie> obj = wishlist.get(uid);
            // List<Movie> mov=null;
            Movie movie = new Movie();
            List<Movie> test;
            foreach (WishlistMovie wish in obj)
            {
                Debug.WriteLine("\n ID: " + wish.Id + " Movie_ID: " + wish.Movie_id + " User_ID: " + wish.User_id);
                //Debug.WriteLine(movie.getMovies(wish.Id));
                test = movie.getMovies(wish.Movie_id);
                Debug.WriteLine(test[0].Name);

                PictureBox movieImage = new PictureBox();
                movieImage.ImageLocation = test[0].Photo;
                movieImage.SizeMode = PictureBoxSizeMode.AutoSize;

                movieImage.Click += (sender, e) =>
                {
                    GlimpseForm glimpseForm = new GlimpseForm(test[0].Id);
                    glimpseForm.setUserId(userID);
                    glimpseForm.Show();
                };
                wishlistFlow.Controls.Add(movieImage);


            }

        }

    }
}
