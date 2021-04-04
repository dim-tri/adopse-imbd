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
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
            LoadHomePage();
        }

        private void LoadHomePage() {
            HomeForm homeForm = new HomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.MainPanel.Controls.Add(homeForm);
            homeForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            homeForm.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
