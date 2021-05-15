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

        private void LoadAllMovies() 
        {
            MovieTeiApiAllMovies allMovies = new MovieTeiApiAllMovies(2);
            IEnumerable<Movie> movies = allMovies.GetMovies();

            for (int i = 0; i < movies.Count() - 1; i++) 
            {
                MovieContainer movieContainer = new MovieContainer(movies.ElementAt(i)) { TopLevel = false, TopMost = true };
                flowAllMovies.Controls.Add(movieContainer);
                movieContainer.Show();
            }

        }
    }
}
