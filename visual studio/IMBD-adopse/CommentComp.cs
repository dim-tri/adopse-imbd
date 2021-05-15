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
    public partial class CommentComp : UserControl
    {
        public CommentComp()
        {
            InitializeComponent();
        }

        private void comment_Load(object sender, EventArgs e)
        {

        }

        public void setComment(int number,String comment)
        {
            num.Text = number.ToString();
            commtext.Text = comment;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
