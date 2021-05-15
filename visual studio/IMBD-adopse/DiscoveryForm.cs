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
        private MainWindowForm MainForm;

        private int Page = 1;
        private int LastPage = 29;

        public DiscoveryForm(MainWindowForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
            LoadAllMovies();
        }

        private void LoadAllMovies() 
        {
            flowAllMovies.Controls.Clear();
            
            //API call for movies in current page
            MovieTeiApiAllMovies allMovies = new MovieTeiApiAllMovies(Page);
            IEnumerable<Movie> movies = allMovies.GetMovies();

            //Create Contrainer for returned movies
            for (int i = 0; i < movies.Count() - 1; i++) 
            {
                MovieContainer movieContainer = new MovieContainer(MainForm, movies.ElementAt(i)) { TopLevel = false, TopMost = true };
                flowAllMovies.Controls.Add(movieContainer);
                movieContainer.Show();


            }
            //Scroll back to top
            flowAllMovies.Controls.OfType <MovieContainer>().FirstOrDefault().Focus();
            UpdatePageLabel();
        }

        private void LoadNextPage() 
        {
            if (Page < LastPage) {
                Page++;
                LoadAllMovies();
            }
        }

        private void LoadPrevPage()
        {
            if (Page > 1)
            {
                Page--;
                LoadAllMovies();               
            }
        }

        private void UpdatePageLabel()
        {
            PageLabel.Text = Page.ToString() + "/" + LastPage.ToString();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            LoadPrevPage();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            LoadNextPage();
        }
    }
}
