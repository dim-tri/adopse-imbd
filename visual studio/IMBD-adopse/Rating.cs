using System;
using System.Windows.Forms;
using System.Diagnostics;
using IMBD_adopse.classes;

namespace IMBD_adopse
{
    public partial class Rating : UserControl
    {
        public Rating()
        {
            InitializeComponent();
        }

        public bool star1_filled = false;
        public bool star2_filled = false;
        public bool star3_filled = false;
        public bool star4_filled = false;
        public bool star5_filled = false;
        public double rating = 0;
        public static MoviePage obj_main;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            if(!star2_filled && !star3_filled && !star4_filled && !star5_filled) 
            {
                pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                star1_filled = true;
            }
           
           
           
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
                pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                star1_filled = true;
                star2_filled = true;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
                pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                star1_filled = true;
                star2_filled = true;
                star3_filled = true;
            
              
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
            pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
            pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
            pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
            star1_filled = true;
            star2_filled = true;
            star3_filled = true;
            star4_filled = true;      
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
            pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
            pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
            pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
            pictureBox4.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
            star1_filled = true;
            star2_filled = true;
            star3_filled = true;
            star4_filled = true;
            star5_filled = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;
            pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px;
            pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px;
            pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px;
            pictureBox4.Image = IMBD_adopse.Properties.Resources.star_24px;
            star1_filled = false;
            star2_filled = false;
            star3_filled = false;
            star4_filled = false;
            star5_filled = false;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;
            pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px;
            pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px;
            pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px;
            star1_filled = false;
            star2_filled = false;
            star3_filled = false;
            star4_filled = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

            pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;
            pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px;
            pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px;
            star1_filled = false;
            star2_filled = false;
            star3_filled = false;
            
            
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {

            pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;    
            pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px;
            star1_filled = false;    
            star2_filled = false;
            
           
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
                pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;
                star1_filled = false;
         
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (!star2_filled && !star3_filled && !star4_filled && !star5_filled) 
            {
                MessageBox.Show("Successfuly Rated with: 2");
                pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox4.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px;
                star1_filled = false;
                star2_filled = false;
                star3_filled = false;
                star4_filled = false;
                star5_filled = false;
                rating = 2;
                userRating rate = new userRating();
                if (rate.setRating(MainWindowForm.getUserID(), MoviePage.getMovieId(), rating))
                {
                    obj_main.movieRating.Enabled = false;
                    obj_main.checkUser();
                }
               
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (star1_filled && !star3_filled && !star4_filled && !star5_filled)
            {
               MessageBox.Show("Successfuly Rated with: 4");
                pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox4.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px;
                star1_filled = false;
                star2_filled = false;
                star3_filled = false;
                star4_filled = false;
                star5_filled = false;
                rating = 4;
                userRating rate = new userRating();
                if (rate.setRating(MainWindowForm.getUserID(), MoviePage.getMovieId(), rating))
                {
                    obj_main.movieRating.Enabled = false;
                    obj_main.checkUser();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (star1_filled && star2_filled && !star4_filled && !star5_filled)
            {
               MessageBox.Show("Successfuly Rated with: 6");
                pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox4.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px;
                star1_filled = false;
                star2_filled = false;
                star3_filled = false;
                star4_filled = false;
                star5_filled = false;
                rating = 6;
                userRating rate = new userRating();
                if (rate.setRating(MainWindowForm.getUserID(), MoviePage.getMovieId(), rating))
                {
                    obj_main.movieRating.Enabled = false;
                    obj_main.checkUser();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (star1_filled && star2_filled && star3_filled && !star5_filled)
            {
               MessageBox.Show("Successfuly Rated with: 8");
                pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox4.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px;
                star1_filled = false;
                star2_filled = false;
                star3_filled = false;
                star4_filled = false;
                star5_filled = false;
                rating = 8;
                userRating rate = new userRating();
                if (rate.setRating(MainWindowForm.getUserID(), MoviePage.getMovieId(), rating))
                {
                    obj_main.movieRating.Enabled = false;
                    obj_main.checkUser();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (star1_filled && star2_filled && star3_filled && star4_filled)
            {
               MessageBox.Show("Successfuly Rated with: 10");
                pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox4.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px;
                star1_filled = false;
                star2_filled = false;
                star3_filled = false;
                star4_filled = false;
                star5_filled = false;
                rating = 10;
                userRating rate = new userRating();
                if (rate.setRating(MainWindowForm.getUserID(), MoviePage.getMovieId(), rating))
                {
                    obj_main.movieRating.Enabled = false;
                    obj_main.checkUser();
                }
            }
        }

        public double getRating()
        {
            return this.rating;
        }

        public void setRating(double rate)
        {
            this.rating = rate;
        }

        private void Rating_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox4.Image = IMBD_adopse.Properties.Resources.star_24px;
                pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px;
                star1_filled = false;
                star2_filled = false;
                star3_filled = false;
                star4_filled = false;
                star5_filled = false;
                rating = 0;
            }
        }

        public void setDefaultValue(double rate) 
        {
            switch (rate)
            {
                case 2:
                    star1_filled = true;
                    pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    break;
                case 4:
                    pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    star1_filled = true;
                    star2_filled = true;
                    break;
                case 6:
                    pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    star1_filled = true;
                    star2_filled = true;
                    star3_filled = true;
                    break;
                case 8:
                    pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    star1_filled = true;
                    star2_filled = true;
                    star3_filled = true;
                    star4_filled = true;
                    break;
                case 10:
                    pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    pictureBox4.Image = IMBD_adopse.Properties.Resources.star_24px_filled;
                    star1_filled = true;
                    star2_filled = true;
                    star3_filled = true;
                    star4_filled = true;
                    star5_filled = true;
                    break;
                default:
                    pictureBox1.Image = IMBD_adopse.Properties.Resources.star_24px;
                    pictureBox3.Image = IMBD_adopse.Properties.Resources.star_24px;
                    pictureBox2.Image = IMBD_adopse.Properties.Resources.star_24px;
                    pictureBox5.Image = IMBD_adopse.Properties.Resources.star_24px;
                    pictureBox4.Image = IMBD_adopse.Properties.Resources.star_24px;
                    star1_filled = false;
                    star2_filled = false;
                    star3_filled = false;
                    star4_filled = false;
                    star5_filled = false;
                    break;
            }
        
        }

    }
}


