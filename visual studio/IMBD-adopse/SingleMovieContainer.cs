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
    public partial class SingleMovieContainer : Form
    {
        private Movie Movie;
        public SingleMovieContainer(Movie movie)
        {
            InitializeComponent();
            Movie = movie;
            LoadMovie();
        }

        private void LoadMovie()
        {
            MoviePicture.ImageLocation = Movie.Photo;
            TitleLabel.Text = Movie.Name;

        }

        private void WatchlistButton_Click(object sender, EventArgs e)
        {

        }
    }
}
