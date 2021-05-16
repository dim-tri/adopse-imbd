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
    public partial class UserPageReviewContainer : UserControl
    {
        private string comment;
        private double rank;
        private string movie_name;

        public UserPageReviewContainer(string name,string comm,double rank)
        {
            InitializeComponent();
            this.comment = comm;
            this.movie_name = name;
            this.rank = rank;
            txtReview.Text = this.comment;
            txtMovieName.Text = this.movie_name;
            rating1.setDefaultValue(this.rank);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rating1_Load(object sender, EventArgs e)
        {

        }
    }
}
