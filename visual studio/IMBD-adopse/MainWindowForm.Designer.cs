
namespace IMBD_adopse
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.watchlistBtn = new System.Windows.Forms.Button();
            this.loginState = new System.Windows.Forms.Label();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.LoginMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.LoginMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Location = new System.Drawing.Point(0, 59);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1904, 980);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.watchlistBtn);
            this.panel1.Controls.Add(this.loginState);
            this.panel1.Controls.Add(this.ProfilePictureBox);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 53);
            this.panel1.TabIndex = 2;
            // 
            // watchlistBtn
            // 
            this.watchlistBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.watchlistBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.watchlistBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchlistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchlistBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.watchlistBtn.Location = new System.Drawing.Point(1510, 16);
            this.watchlistBtn.Name = "watchlistBtn";
            this.watchlistBtn.Size = new System.Drawing.Size(140, 28);
            this.watchlistBtn.TabIndex = 7;
            this.watchlistBtn.Text = "Watchlist";
            this.watchlistBtn.UseVisualStyleBackColor = false;
            this.watchlistBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginState
            // 
            this.loginState.Location = new System.Drawing.Point(1656, 16);
            this.loginState.Name = "loginState";
            this.loginState.Size = new System.Drawing.Size(171, 23);
            this.loginState.TabIndex = 6;
            this.loginState.Text = "Guest";
            this.loginState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.ContextMenuStrip = this.LoginMenuStrip;
            this.ProfilePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePictureBox.Image")));
            this.ProfilePictureBox.Location = new System.Drawing.Point(1845, 12);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(33, 29);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePictureBox.TabIndex = 5;
            this.ProfilePictureBox.TabStop = false;
            this.ProfilePictureBox.Click += new System.EventHandler(this.ProfilePictureBox_Click);
            // 
            // LoginMenuStrip
            // 
            this.LoginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginMenuItem,
            this.RegisterMenuItem,
            this.SettingsMenuItem});
            this.LoginMenuStrip.Name = "contextMenuStrip1";
            this.LoginMenuStrip.ShowImageMargin = false;
            this.LoginMenuStrip.Size = new System.Drawing.Size(92, 70);
            // 
            // LoginMenuItem
            // 
            this.LoginMenuItem.Name = "LoginMenuItem";
            this.LoginMenuItem.Size = new System.Drawing.Size(91, 22);
            this.LoginMenuItem.Text = "Login";
            this.LoginMenuItem.Click += new System.EventHandler(this.LoginMenuItem_Click);
            // 
            // RegisterMenuItem
            // 
            this.RegisterMenuItem.Name = "RegisterMenuItem";
            this.RegisterMenuItem.Size = new System.Drawing.Size(91, 22);
            this.RegisterMenuItem.Text = "Register";
            this.RegisterMenuItem.Click += new System.EventHandler(this.RegisterMenuItem_Click);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(91, 22);
            this.SettingsMenuItem.Text = "Settings";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1292, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(642, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(644, 29);
            this.searchBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::IMBD_adopse.Properties.Resources.logo_colorArtboard_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainWindowForm";
            this.Text = "MainWindowForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.LoginMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox pictureBox1;

        //private System.Windows.Forms.PictureBox HomeButton;

        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.ContextMenuStrip LoginMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem LoginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegisterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        public System.Windows.Forms.Label loginState;
        public System.Windows.Forms.Button watchlistBtn;
    }
}