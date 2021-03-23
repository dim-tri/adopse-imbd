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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fill New Releases with random movies
            for (int i = 0; i < 6; i++)
            {
                //Get DB data
                Movie obj = new Movie();
                List<Movie> movies = obj.getMovies(11 + i);

                //Create Picture Box
                PictureBox movieImage = new PictureBox();
                movieImage.ImageLocation = movies[0].Photo;
                movieImage.SizeMode = PictureBoxSizeMode.AutoSize;

                //Assign to flow panel
                flowPanelNewReleases.Controls.Add(movieImage);
            }

            //Fill Top Movies with random movies
            for (int i = 0; i < 6; i++)
            {
                //Get DB data
                Movie obj = new Movie();
                List<Movie> movies = obj.getMovies(21 + i);

                //Create Picture Box
                PictureBox movieImage = new PictureBox();
                movieImage.ImageLocation = movies[0].Photo;
                movieImage.SizeMode = PictureBoxSizeMode.AutoSize;

                //Assign to flow panel
                flowPanelTopMovies.Controls.Add(movieImage);
            }



        }
    }
}
