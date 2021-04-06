using IMBD_adopse.classes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IMBD_adopse
{
    public partial class MoviePage : Form
    {
        //Id of movie to display
        private int MovieID;
       
        public MoviePage(int movieId)
        {
            this.MovieID = movieId;
            InitializeComponent();
            MoviePage_Load();
        }

        //Load Movie Information
        private void MoviePage_Load()
        {

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
