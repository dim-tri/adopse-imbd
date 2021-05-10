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
using System.Text.RegularExpressions;

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
            if (name.Text.Trim() == "name") { MessageBox.Show("Please check the value of name.", "Required Fields"); return; }
            if (surname.Text.Trim() == "surname") { MessageBox.Show("Please check the value of surname.", "Required Fields"); return; }
            if (email.Text.Trim() == "email") { MessageBox.Show("Please check the value of email.", "Required Fields"); return; }
            if (username.Text.Trim() == "username") { MessageBox.Show("Please check the value of username.", "Required Fields"); return; }
            if (password.Text.Trim() == "password") { MessageBox.Show("Please check the value of password.", "Required Fields"); return; }

            if (!string.IsNullOrWhiteSpace(name.Text) && !string.IsNullOrWhiteSpace(surname.Text) && !string.IsNullOrWhiteSpace(email.Text) && !string.IsNullOrWhiteSpace(username.Text) && !string.IsNullOrWhiteSpace(password.Text))
            {
                if (!Regex.IsMatch(email.Text, "^[Aa-zZ0-9]+@[Aa-zZ]+.[a-z]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) { MessageBox.Show("Please check the value of email.", "Required Fields"); return; }
                if (!Regex.IsMatch(name.Text, "^[Aa-zZ0-9]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) { MessageBox.Show("Please check the value of name.", "Required Fields"); return; }
                if (!Regex.IsMatch(surname.Text, "^[Aa-zZ0-9]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) { MessageBox.Show("Please check the value of surname.", "Required Fields"); return; }
                if (!Regex.IsMatch(username.Text, "^[Aa-zZ0-9]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) { MessageBox.Show("Please check the value of username.", "Required Fields"); return; }
                if (!Regex.IsMatch(password.Text, "^[Aa-zZ0-9@!.]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) { MessageBox.Show("Please check the value of password.", "Required Fields"); return; }

                Users user = new Users();
                if (user.registerUser(name.Text, surname.Text, email.Text, password.Text, username.Text))
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

        private void RegisterForm_Click(object sender, EventArgs e)
        {

        }
    }
}
