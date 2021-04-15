using IMBD_adopse.classes;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace IMBD_adopse
{
    public partial class MoviePage : Form
    {
        //Id of movie to display
        private int MovieID;
        public static int m_id;
       
        public MoviePage(int movieId)
        {
            this.MovieID = movieId;
            m_id = movieId;
            InitializeComponent();
            MoviePage_Load();
            checkUser();
        }

        //Load Movie Information
        private void MoviePage_Load()
        {

            //Get DB data
            Movie obj = new Movie();
            List<Movie> movies = obj.getMovies(MovieID);

            //Data to Form
            MovieImage.ImageLocation = movies[0].Photo;

            MovieImage.Size = new System.Drawing.Size(200, 240);
            MovieImage.SizeMode = PictureBoxSizeMode.CenterImage;
            MovieImage.SizeMode = PictureBoxSizeMode.StretchImage;
            MovieImage.BorderStyle = BorderStyle.Fixed3D;

            MovieDesc.Text = movies[0].Plot;
            MovieTitle.Text = movies[0].Name;
            labelCategory.Text = movies[0].Gentre;
            labelLength.Text = movies[0].Duration;
            labelDate.Text = movies[0].Release;
            labelRating.Text = movies[0].Rank.ToString() + "/10";
            labelStar.Text = movies[0].Stars;
        }

        public void checkUser()
        {
            int user = MainWindowForm.getUserID();
            if ( user != 0) 
            {
                movieRating.Enabled = true;
                userRating obj = new userRating();
                //Debug.WriteLine(user);
               // Debug.WriteLine(m_id);
               // Debug.WriteLine(obj.check(user, m_id));
                if (obj.check(user, m_id))
                {
                    movieRating.Enabled = false;
                    movieRating.setDefaultValue(obj.Rank);
                }
            }

           
        }

        public static int getMovieId() 
        {
            return m_id;
        }

    }
}
