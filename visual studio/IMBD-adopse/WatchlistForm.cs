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
    public partial class WatchlistForm : Form
    {
        private int userID;
        private MainWindowForm MainForm;

        public WatchlistForm(MainWindowForm mainForm, int userid)
        {
            this.MainForm = mainForm;
            InitializeComponent();
            sendObjHome(userid);
        }

        
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public void sendObjHome(int id)
        {
            userID = id;
            loadWatchlist(id);
        }


        public void loadWatchlist(int uid)
        {
            try 
            { 
           // Debug.WriteLine("test: " + uid);
            WishlistMovie wishlist = new WishlistMovie();
            List<WishlistMovie> obj = wishlist.get(uid);
            if(obj == null) { MessageBox.Show("Your watchlist is empty.", "Watchlist"); return; }
            // List<Movie> mov=null;
            Movie movie = new Movie();
            List<Movie> test;
            foreach (WishlistMovie wish in obj)
            {
               test = movie.getMovies(wish.Movie_id);
               WatchlistContainer container = new WatchlistContainer(MainForm,test[0]) { TopLevel = false, TopMost = true };                               
               flowWatchlist.Controls.Add(container);
               container.Show();
               // Debug.WriteLine("\n ID: " + wish.Id + " Movie_ID: " + wish.Movie_id + " User_ID: " + wish.User_id);
               //Debug.WriteLine(movie.getMovies(wish.Id));
                    
               // Debug.WriteLine(test[0].Name);                   
            }

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


        }



    }
}
