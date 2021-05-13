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
            if (textBoxName.Text.Trim() == "name") { MessageBox.Show("Please check the value of name.", "Required Fields"); return; }
            if (textBoxSurname.Text.Trim() == "surname") { MessageBox.Show("Please check the value of surname.", "Required Fields"); return; }
            if (textBoxEmail.Text.Trim() == "email") { MessageBox.Show("Please check the value of email.", "Required Fields"); return; }
            if (textBoxUsername.Text.Trim() == "username") { MessageBox.Show("Please check the value of username.", "Required Fields"); return; }
            if (textBoxPassword.Text.Trim() == "password") { MessageBox.Show("Please check the value of password.", "Required Fields"); return; }

            if (!string.IsNullOrWhiteSpace(textBoxName.Text) && !string.IsNullOrWhiteSpace(textBoxSurname.Text) && !string.IsNullOrWhiteSpace(textBoxEmail.Text) && !string.IsNullOrWhiteSpace(textBoxUsername.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                if (!Regex.IsMatch(textBoxEmail.Text, "^[Aa-zZ0-9]+@[Aa-zZ]+.[a-z]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) { MessageBox.Show("Please check the value of email.", "Required Fields"); return; }
                if (!Regex.IsMatch(textBoxName.Text, "^[Aa-zZ0-9]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) { MessageBox.Show("Please check the value of name.", "Required Fields"); return; }
                if (!Regex.IsMatch(textBoxSurname.Text, "^[Aa-zZ0-9]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) { MessageBox.Show("Please check the value of surname.", "Required Fields"); return; }
                if (!Regex.IsMatch(textBoxUsername.Text, "^[Aa-zZ0-9]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) { MessageBox.Show("Please check the value of username.", "Required Fields"); return; }
                if (!Regex.IsMatch(textBoxPassword.Text, "^[Aa-zZ0-9@!.]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) { MessageBox.Show("Please check the value of password.", "Required Fields"); return; }

                Users user = new Users();
                if (user.registerUser(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxUsername.Text))
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



        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Black;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }
    }
}