using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using IMBD_adopse.classes;

namespace IMBD_adopse
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(name.Text) && !string.IsNullOrWhiteSpace(surname.Text) && !string.IsNullOrWhiteSpace(email.Text) && !string.IsNullOrWhiteSpace(username.Text) && !string.IsNullOrWhiteSpace(password.Text))
            {
                Users user = new Users();
                if (user.registerUser(name.Text, surname.Text,email.Text,password.Text,username.Text))
                {
                    MessageBox.Show("New User Created Successfully.", "User Status");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("An Error occured, User not created.", "User Status");
                }

            }
            else
            {
                MessageBox.Show("Please fill the fields, User not created.", "Required Fields");
            }
        



        }
    }
}
