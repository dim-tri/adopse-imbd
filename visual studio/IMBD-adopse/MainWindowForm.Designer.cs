
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.MainMenu = new System.Windows.Forms.ToolStrip();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.SearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.Watchlist = new System.Windows.Forms.ToolStripButton();
            this.UserButton = new System.Windows.Forms.ToolStripButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenu.AutoSize = false;
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(5);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeButton,
            this.SearchBox,
            this.Watchlist,
            this.UserButton});
            this.MainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1904, 40);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "toolStrip1";
            // 
            // HomeButton
            // 
            this.HomeButton.AutoSize = false;
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(50, 40);
            this.HomeButton.Text = "toolStripButton1";
            // 
            // SearchBox
            // 
            this.SearchBox.Margin = new System.Windows.Forms.Padding(50, 2, 1, 0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 23);
            // 
            // Watchlist
            // 
            this.Watchlist.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Watchlist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Watchlist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Watchlist.Image = ((System.Drawing.Image)(resources.GetObject("Watchlist.Image")));
            this.Watchlist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Watchlist.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.Watchlist.Name = "Watchlist";
            this.Watchlist.Size = new System.Drawing.Size(77, 25);
            this.Watchlist.Text = "Watchlist";
            // 
            // UserButton
            // 
            this.UserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UserButton.Image = ((System.Drawing.Image)(resources.GetObject("UserButton.Image")));
            this.UserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UserButton.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(36, 36);
            this.UserButton.Text = "toolStripButton1";
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Location = new System.Drawing.Point(12, 43);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1880, 986);
            this.MainPanel.TabIndex = 1;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainMenu);
            this.Name = "MainWindowForm";
            this.Text = "MainWindowForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.ToolStripButton Watchlist;
        private System.Windows.Forms.ToolStripTextBox SearchBox;
        private System.Windows.Forms.ToolStripButton UserButton;
        private System.Windows.Forms.Panel MainPanel;
    }
}