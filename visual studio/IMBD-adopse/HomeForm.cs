using IMBD_adopse.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace IMBD_adopse
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            loadHome();
        }

        //load home movies
        public void loadHome()
        {
            //stougiannou Endeiktikh Prosegisi
            //load top movies
            Movie obj = new Movie();
            List<Movie> movies = obj.getTopMovies();
            foreach (Movie movie in movies)
            {
                PictureBox movieImage = new PictureBox();
                movieImage.ImageLocation = movie.Photo;
                movieImage.SizeMode = PictureBoxSizeMode.AutoSize;

                movieImage.Click += (sender, e) =>
                {
                    GlimpseForm glimpseForm = new GlimpseForm(movie.Id);
                    glimpseForm.setUserId(userID);
                    glimpseForm.Show();
                };
                flowPanelTopMovies.Controls.Add(movieImage);
            }
            //load 10 movies
            Movie obj2= new Movie();
            List<Movie> movies2 = obj.getMovies(10,"desc");
            foreach (Movie movie2 in movies2)
            {
                PictureBox movieImage = new PictureBox();
                movieImage.ImageLocation = movie2.Photo;
                movieImage.SizeMode = PictureBoxSizeMode.AutoSize;
                movieImage.Click += (sender, e) =>
                {
                    GlimpseForm glimpseForm = new GlimpseForm(movie2.Id);
                    glimpseForm.setUserId(userID);
                    glimpseForm.Show();
                };
                flowPanelNewReleases.Controls.Add(movieImage);
            }


        }

        public int userID;
        private void button2_Click(object sender, EventArgs e)
        {
            if(loginBtn.Text == "Logout")
            {
                Users user = new Users();
                if (user.logout(userID))
                {
                    
                    userID = 0;
                    loginState.Text = "Logged in as: Guest";
                    loginBtn.Text = "Login";
                    MessageBox.Show("You are now logged out.", "Login Status");
                    OpenWishlistBtn.Enabled = false;
                    return;
                }
            }

             LoginForm loginpage = new LoginForm();
             loginpage.homeFormObject(this);
             loginpage.Show();
            
        }


        //trexon user id tou sundedemenou
        public void setUserID(int id) 
        {
            userID = id;
        }

        private void OpenWishlistBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("from homwform " + userID);
            WishlistForm wish = new WishlistForm();
            wish.UserID = this.userID;
            wish.Show();

        }
    }
}
