using IMBD_adopse.classes;
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
    public partial class MoviePage : Form
    {
        private int MovieID;
        public MoviePage(int movieId)
        {
            this.MovieID = movieId;
            InitializeComponent();
            MoviePage_Load();
        }

        private void MoviePage_Load() {
            
            //Get DB data
            Movie obj = new Movie();
            List<Movie> movies = obj.getMovies(MovieID);

            //Data to Form
            MovieImage.ImageLocation = movies[0].Photo;
            MovieDesc.Text = movies[0].Plot;
            MovieTitle.Text = movies[0].Name;
        }

    }
}
