
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
            this.DiscoverButton = new System.Windows.Forms.PictureBox();
            this.watchlistBtn = new System.Windows.Forms.Button();
            this.loginState = new System.Windows.Forms.Label();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.LoginMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscoverButton)).BeginInit();
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
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(156)))));
            this.MainPanel.Location = new System.Drawing.Point(0, 50);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1370, 697);
            this.MainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.DiscoverButton);
            this.panel1.Controls.Add(this.watchlistBtn);
            this.panel1.Controls.Add(this.loginState);
            this.panel1.Controls.Add(this.ProfilePictureBox);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 53);
            this.panel1.TabIndex = 2;
            // 
            // DiscoverButton
            // 
            this.DiscoverButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DiscoverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscoverButton.Image = global::IMBD_adopse.Properties.Resources.discover_icon;
            this.DiscoverButton.Location = new System.Drawing.Point(243, 5);
            this.DiscoverButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DiscoverButton.Name = "DiscoverButton";
            this.DiscoverButton.Size = new System.Drawing.Size(42, 42);
            this.DiscoverButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiscoverButton.TabIndex = 9;
            this.DiscoverButton.TabStop = false;
            this.DiscoverButton.Click += new System.EventHandler(this.DiscoverButton_Click);
            // 
            // watchlistBtn
            // 
            this.watchlistBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.watchlistBtn.BackColor = System.Drawing.Color.Transparent;
            this.watchlistBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.watchlistBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchlistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchlistBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.watchlistBtn.ForeColor = System.Drawing.Color.White;
            this.watchlistBtn.Image = ((System.Drawing.Image)(resources.GetObject("watchlistBtn.Image")));
            this.watchlistBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.watchlistBtn.Location = new System.Drawing.Point(976, 5);
            this.watchlistBtn.Name = "watchlistBtn";
            this.watchlistBtn.Size = new System.Drawing.Size(155, 40);
            this.watchlistBtn.TabIndex = 7;
            this.watchlistBtn.Text = "Watchlist";
            this.watchlistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.watchlistBtn.UseVisualStyleBackColor = false;
            this.watchlistBtn.Visible = false;
            this.watchlistBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginState
            // 
            this.loginState.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loginState.ForeColor = System.Drawing.Color.White;
            this.loginState.Location = new System.Drawing.Point(1122, 16);
            this.loginState.Name = "loginState";
            this.loginState.Size = new System.Drawing.Size(171, 23);
            this.loginState.TabIndex = 6;
            this.loginState.Text = "Guest";
            this.loginState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProfilePictureBox.ContextMenuStrip = this.LoginMenuStrip;
            this.ProfilePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePictureBox.Image")));
            this.ProfilePictureBox.Location = new System.Drawing.Point(1311, 12);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(33, 29);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePictureBox.TabIndex = 5;
            this.ProfilePictureBox.TabStop = false;
            this.ProfilePictureBox.Click += new System.EventHandler(this.ProfilePictureBox_Click);
            // 
            // LoginMenuStrip
            // 
            this.LoginMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LoginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginMenuItem,
            this.RegisterMenuItem,
            this.ProfileMenuItem});
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
            // ProfileMenuItem
            // 
            this.ProfileMenuItem.Name = "ProfileMenuItem";
            this.ProfileMenuItem.Size = new System.Drawing.Size(91, 22);
            this.ProfileMenuItem.Text = "Profile";
            this.ProfileMenuItem.Click += new System.EventHandler(this.ProfileMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(933, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(326, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(601, 33);
            this.searchBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainWindowForm";
            this.Text = "MOVIECLUB PROJECT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscoverButton)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem ProfileMenuItem;
        public System.Windows.Forms.Label loginState;
        public System.Windows.Forms.Button watchlistBtn;
        private System.Windows.Forms.PictureBox DiscoverButton;
    }
}