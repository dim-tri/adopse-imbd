using IMBD_adopse.classes;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System;

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
            Rating.obj_main = this;
            InitializeComponent();
            MoviePage_Load();
            checkUser();
            refreshRate();
            
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
            flowLayoutPanelComments.Hide();
            labelComments.Hide();
        }

        public void checkUser()
        {
            int user = MainWindowForm.getUserID();
            if ( user != 0) 
            {
                buttonSubmit.Enabled = true;
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


        public void refreshRate() 
        {
            userRating obj = new userRating();
            double rank = obj.getAvgUserMovieRatings(m_id);
            rank = Math.Round(rank, 1);
            userRateLabel.Text = rank.ToString();
        }

        public static int getMovieId() 
        {
            return m_id;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string userComment = textBoxReview.Text;
                if (String.IsNullOrWhiteSpace(userComment)) { MessageBox.Show("Comment cannot be empty."); return; }
                Comments comm = new Comments();
                comm.setComment(MainWindowForm.getUserID(), m_id, userComment);
                List<Comments> com = comm.getComments(m_id);
                foreach(var comment in com)
                {
                    Debug.WriteLine("user: " + comment.User_id + " Commnet: " + comment.Comment);
                }

                MessageBox.Show("Thanks for your comment.");
                textBoxReview.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("An Error occured: " + ex.Message);
            }
        }

        private void linkLabelView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelComments.Show();
            flowLayoutPanelComments.Show();
            flowLayoutPanelComments.Focus();
            flowLayoutPanelComments.Controls.Clear();
            Comments obj = new Comments();
            List<Comments> comments = obj.getComments(this.MovieID);
            int counter = 1;
            foreach (Comments comm in comments)
            {
                CommentComp comp = new CommentComp();
                comp.setComment(counter, comm.Comment);
                flowLayoutPanelComments.AutoScroll = true;
                flowLayoutPanelComments.AutoSize = true;
                flowLayoutPanelComments.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanelComments.WrapContents = false;
                flowLayoutPanelComments.Controls.Add(comp);
                counter++;
            }


        }


        

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void MovieTitle_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
