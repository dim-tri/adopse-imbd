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

        public void LoadHomePage() {
            HomeForm homeForm = new HomeForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.MainPanel.Controls.Add(homeForm);
            homeForm.Show();

            
        }

        public void LoadMoviePage(int movieId) {

            this.MainPanel.Controls.Clear();
            MoviePage moviePage = new MoviePage(movieId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.MainPanel.Controls.Add(moviePage);
            moviePage.Show();
        }

    }
}
