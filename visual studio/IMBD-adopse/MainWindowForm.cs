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
    public partial class MainWindowForm : Form
    {
        public static int userID;
        public static String userGenre;
        

        public MainWindowForm()
        {
            InitializeComponent();
            LoadHomePage();
          
        }

        //Clear Main Window and Load Home Page
        public void LoadHomePage()
        {
            this.MainPanel.Controls.Clear();
            HomeForm homeForm = new HomeForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homeForm.setUserID(userID);
            homeForm.Recommendations();
            this.MainPanel.Controls.Add(homeForm);
            homeForm.Show();


        }

        //Clear Main Window and Load Movie Page
        public void LoadMoviePage(int movieId)
        {

            this.MainPanel.Controls.Clear(); //Clear Panel
            MoviePage moviePage = new MoviePage(movieId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.MainPanel.Controls.Add(moviePage);
            moviePage.Show();
        }

        //Clear Main Window and Load Watchlist Page
        public void LoadWatchlistPage()
        {
            this.MainPanel.Controls.Clear(); //Clear Panel
            WatchlistForm watchlistPage = new WatchlistForm(this, userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.MainPanel.Controls.Add(watchlistPage);
            watchlistPage.Show();
        }

        //Clear Main Window and Load Watchlist Page
        public void LoadDiscoverytPage()
        {
            this.MainPanel.Controls.Clear(); //Clear Panel
            DiscoveryForm discoveryForm = new DiscoveryForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.MainPanel.Controls.Add(discoveryForm);
            discoveryForm.Show();
        }

        //Clear Main Window and Load User Profile Page
        public void LoadUserPage()
        {
            if (userID == 0)
            {
                MessageBox.Show("You are not logged in!", "Login Status");
            }
            else {
                this.MainPanel.Controls.Clear(); //Clear Panel
                UserPageForm userPage = new UserPageForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.MainPanel.Controls.Add(userPage);
                userPage.Show();
            }
            
        }

        //Profile drop-down menu
        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            LoginMenuStrip.Show(ptLowerLeft);
        }

        public void LoginMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginMenuItem.Text == "Logout")
            {
                Users user = new Users();
                if (user.logout(userID))
                {
                    userID = 0;
                    loginState.Text = "Guest";
                    LoginMenuItem.Text = "Login";
                    MessageBox.Show("You are now logged out.", "Login Status");
                    //watchlistBtn.Enabled = false;
                    watchlistBtn.Visible = false;
                    this.LoadHomePage();
                    return;
                }
            }

            LoginForm loginpage = new LoginForm();
            loginpage.MainWindowForm(this);
            loginpage.Show();
        }

        public void RegisterMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }

        public void ProfileMenuItem_Click(object sender, EventArgs e)
        {

            this.LoadUserPage();
        }

        //public static int userID;

        //string message = "Settings";
        //MessageBox.Show(message);


        public void setUserID(int id)
        {
            userID = id;

        }

        //Search Button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchBox.Text))
            {
                try
                {

                    //  Movie movie = new Movie();
                    //  List<Movie> search = movie.DynamicSearch(searchBox.Text);
                    //   if (search == null) { MessageBox.Show("Not found results", "Search Results"); return; }
                    //    if (search[0].Id == 0) { MessageBox.Show("Not found results", "Search Results"); return; }
                    //    LoadMoviePage(search[0].Id);

                    SearchFormResults.searchQuery = searchBox.Text;
                    this.MainPanel.Controls.Clear();
                    SearchFormResults searchForm = new SearchFormResults(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    searchForm.loadSearch();
                    this.MainPanel.Controls.Add(searchForm);
                    searchForm.Show();

                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error: " + ex.Message);
                    // MessageBox.Show("Not found results", "Search Results");
                    SearchFormResults.searchQuery = searchBox.Text;
                    this.MainPanel.Controls.Clear();
                    SearchFormResults searchForm = new SearchFormResults(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    searchForm.loadSearch2();
                    this.MainPanel.Controls.Add(searchForm);
                    searchForm.Show();
                }
            }
            else { MessageBox.Show("Not found results", "Search Results"); }



        }

        //Logo Click
        private void HomeButton_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("Return to home...", "Home");
            this.LoadHomePage();
            searchBox.Text = "";

        }

        //Wathlist button
        private void button1_Click(object sender, EventArgs e)
        {
            //WatchlistForm wish = new WatchlistForm();
            //wish.sendObjHome(userID);
            //wish.Show();

            this.LoadWatchlistPage();
        }

        //Discovery Button
        private void DiscoverButton_Click(object sender, EventArgs e)
        {
            LoadDiscoverytPage();
        }

        //Find Users Preferred Genre
        public void FindPreferredGenre(int uid) 
        {
            WishlistMovie wishlist = new WishlistMovie();
            List<WishlistMovie> obj = wishlist.get(uid);
            //Find the most frequent genre in user watchlist
            if (obj != null)
            {
                Movie movie = new Movie();
                List<Movie> movieList;

                var genres = new List<string>();
                foreach (WishlistMovie wish in obj)
                {

                    movieList = movie.getMovies(wish.Movie_id);
                    genres.Add(movieList[0].Gentre);

                }
                foreach (string gnr in genres)
                {
                    Debug.WriteLine(gnr);
                }

                var mostCommonValue = genres.GroupBy(v => v)
                                .OrderByDescending(g => g.Count())
                                .Select(g => g.Key)
                                .FirstOrDefault();
                Debug.WriteLine("Most Frequent: " + mostCommonValue);
                userGenre = mostCommonValue;
            }
            else
            {
                //Randome Genre if watchlist is empty
                string[] rGenres = { "Action", "Crime", "Drama", "Comedy", "Documentary", "Thriller" };
                Random random = new Random();
                int randGenre = random.Next(0, rGenres.Length);
                userGenre = rGenres[randGenre];
            }
        }
        
        public static int getUserID()
        {
            return userID;
        }
        public string getUserGenre()
        {
            return userGenre;
        }

        public void getReccomendations(int uid)
        {
           
            userID = uid;

        }







    }
}
