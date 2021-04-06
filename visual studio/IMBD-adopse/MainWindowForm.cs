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

        private void LoginMenuItem_Click(object sender, EventArgs e) {
            string message = "Login";
            MessageBox.Show(message);
        }

        private void RegisterMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Register";
            MessageBox.Show(message);
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Settings";
            MessageBox.Show(message);
        }

    }
}
