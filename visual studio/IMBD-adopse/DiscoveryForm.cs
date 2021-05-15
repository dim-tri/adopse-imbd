using System;
using IMBD_adopse.classes;
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
    public partial class DiscoveryForm : Form
    {
        public DiscoveryForm()
        {
            InitializeComponent();
            LoadAllMovies();
        }

        private void LoadAllMovies() {

            //load Top Movies
            Movie obj = new Movie();
            List<Movie> topMovies = obj.getTopMovies();
            foreach (Movie movie in topMovies)
            {
                //SingleMovieContainer movieContainer = new SingleMovieContainer(MainWindow, movie) { TopLevel = false, TopMost = true };
                //flowPanelTopMovies.Controls.Add(movieContainer);
               // movieContainer.Show();

                MovieContainer movieContainer = new MovieContainer(movie) { TopLevel = false, TopMost = true };
                flowAllMovies.Controls.Add(movieContainer);
                movieContainer.Show();
            }
        }
    }
}
