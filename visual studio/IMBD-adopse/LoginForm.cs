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
    public partial class LoginForm : Form
    {
    
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Black;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;
            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Username is empty.", "Username Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Password is empty.", "Password Error");
                return;
            }

                //Attempt to login
                Users newLogin = new Users();
                if(newLogin.Auth(user, pass))
                {
                    MessageBox.Show("Authentication Success.", "Authentication");
                    obj2.loginState.Text = "Logged in as: " + newLogin.Name;
                    obj2.loginBtn.Text = "Logout";
                    this.Dispose();
                    return;
                }
                else
                {
                    MessageBox.Show("Authentication Not Successful.", "Authentication");
                    return;
                }
            
          
        }

        private void linkLabelSingup_Click(object sender, EventArgs e)
        {

        }
   
        public HomeForm obj2;

        public void homeFormObject(HomeForm obj)
        {
            obj2 = obj;
            
        }

    
    }
}
