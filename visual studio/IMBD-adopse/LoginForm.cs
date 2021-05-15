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
                labelfalse.Text = "Wrong Username or Password"; 
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                labelfalse.Text = "Wrong Username or Password";
            }

                //Attempt to login
                Users newLogin = new Users();
                if(newLogin.Auth(user, pass))
                {
                    MessageBox.Show("Authentication Success.", "Authentication");
                    obj2.loginState.Text = "Logged in as: " + newLogin.Name;
                    obj2.LoginMenuItem.Text= "Logout";
                    obj2.setUserID(newLogin.Id);       
                    //obj2.watchlistBtn.Enabled = true;
                    obj2.watchlistBtn.Visible = true;

                
                    obj2.getReccomendations(newLogin.Id);

                    obj2.LoadHomePage();                    
                    this.Dispose();
                    
                    return;
                }
                else
                {
                labelfalse.Text = "Wrong Username or Password";
                }
            
          
        }

   
        public MainWindowForm obj2;

        public void MainWindowForm(MainWindowForm obj)
        {
            obj2 = obj;
            
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
