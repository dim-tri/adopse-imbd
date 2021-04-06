﻿using System;
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
        public MainWindowForm()
        {
            InitializeComponent();
            LoadHomePage();
        }

        //Clear Main Window and Load Home Page
        public void LoadHomePage() {
            this.MainPanel.Controls.Clear();
            HomeForm homeForm = new HomeForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.MainPanel.Controls.Add(homeForm);
            homeForm.Show();

            
        }

        //Clear Main Window and Load Movie Page
        public void LoadMoviePage(int movieId) {

            this.MainPanel.Controls.Clear(); //Clear Panel
            MoviePage moviePage = new MoviePage(movieId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.MainPanel.Controls.Add(moviePage);
            moviePage.Show();
        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            LoginMenuStrip.Show(ptLowerLeft);
        }

        public void LoginMenuItem_Click(object sender, EventArgs e) {
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
            string message = "Settings";
            MessageBox.Show(message);
        }

        public static int userID;

        public void setUserID(int id)
        {
            userID = id;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Searching...", "Search");
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Return to home...", "Home");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WatchlistForm wish = new WatchlistForm();
            wish.sendObjHome(userID);
            wish.Show();
        }


        public static int getUserID()
        {
            return userID;
        }
    }
}