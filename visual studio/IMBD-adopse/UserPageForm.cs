using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMBD_adopse.classes;

namespace IMBD_adopse
{
    public partial class UserPageForm : Form
    {
        //Id of current logged in user
        private int userID;

        public UserPageForm(int userid)
        {
            InitializeComponent();
            this.userID = userid;
            loaduserdata(userID);
            loadReviews();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loaduserdata(int id)
        {
            Users user = new Users();
            Users obj = user.getUserAll(id);

            nameUser.Text = obj.Name;
            surnameUser.Text = obj.Surname;
            emailUser.Text = obj.Email;
            usernameUser.Text = obj.Username;
            passwordUser.Text = obj.Password;

            label5.Text = obj.Username;
            label1.Text = obj.Surname + " " + obj.Name;

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            Users obj = user.getUserAll(this.userID);
            Users newUser = new Users();
            newUser.Id = this.userID;

            if(nameUser.Text != obj.Name)
            {
                newUser.Name = nameUser.Text.Trim();
            }

            if (surnameUser.Text != obj.Surname)
            {
                newUser.Surname = surnameUser.Text.Trim();
            }

            if (emailUser.Text != obj.Email)
            {
                newUser.Email = emailUser.Text.Trim();

            }

            if (usernameUser.Text != obj.Username)
            {
                newUser.Username = usernameUser.Text.Trim();
            }

            if (passwordUser.Text != obj.Password)
            {
                newUser.Password = passwordUser.Text.Trim();
            }

           if(obj.UpdateUserData(newUser))
            {
                MessageBox.Show("User Updated.");
                loaduserdata(this.userID);
            }
            else
            {
                MessageBox.Show("User Not Updated.");
            }


        }


        private void loadReviews()
        {
            
            flowPanelUserPageReview.Controls.Clear();
            flowPanelUserPageReview.AutoScroll = true;
            flowPanelUserPageReview.AutoSize = false;
            flowPanelUserPageReview.FlowDirection = FlowDirection.LeftToRight;
            flowPanelUserPageReview.WrapContents = true;
            UserReviews obj = new UserReviews();
            List<UserReviews> mylist = obj.allReviews(this.userID);

            foreach(UserReviews user in mylist)
            {
                UserPageReviewContainer cont = new UserPageReviewContainer(user.Name,user.Comment,user.Rank);
                flowPanelUserPageReview.Controls.Add(cont);
            }

        }


    }
}
