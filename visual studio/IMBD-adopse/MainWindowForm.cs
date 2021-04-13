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
            WatchlistForm watchlistPage = new WatchlistForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.MainPanel.Controls.Add(watchlistPage);
            watchlistPage.Show();
        }

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
                    watchlistBtn.Enabled = false;
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

        public void SettingsMenuItem_Click(object sender, EventArgs e)
        {

            SettingsForm settings = new SettingsForm();
            settings.Show();
        }

        //public static int userID;

        //string message = "Settings";
        //MessageBox.Show(message);


        public void setUserID(int id)
        {
            userID = id;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchBox.Text))
            {
                try
                {

                    Movie movie = new Movie();
                    List<Movie> search = movie.DynamicSearch(searchBox.Text);
                    if (search == null) { MessageBox.Show("Not found results", "Search Results"); return; }
                    if (search[0].Id == 0) { MessageBox.Show("Not found results", "Search Results"); return; }
                    LoadMoviePage(search[0].Id);
                }catch(Exception ex){
                    Debug.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("Not found results", "Search Results");
                }
            }
            else { MessageBox.Show("Not found results", "Search Results"); }


        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("Return to home...", "Home");
            this.LoadHomePage();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WatchlistForm wish = new WatchlistForm();
            //wish.sendObjHome(userID);
            //wish.Show();

            this.LoadWatchlistPage();
        }


        public static int getUserID()
        {
            return userID;
        }
    }
}
