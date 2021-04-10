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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.checkBox1State == true)
            {
                checkBox1.Checked = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                //MessageBox.Show("Checked", "checkbox");
                Properties.Settings.Default.checkBox1State = true;
            }
            else
            {
                //MessageBox.Show("Not Checked", "checkbox");
                Properties.Settings.Default.checkBox1State = false;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
            Application.Restart();

            /*this.Close();
            MainWindowForm test = new MainWindowForm();  // just testing
            test.ShowDialog();*/
        }
    }
}
