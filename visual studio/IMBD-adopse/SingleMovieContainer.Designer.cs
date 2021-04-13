
namespace IMBD_adopse
{
    partial class SingleMovieContainer
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
            this.MoviePicture = new System.Windows.Forms.PictureBox();
            this.WatchlistButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePicture
            // 
            this.MoviePicture.ImageLocation = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlY" +
    "WMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL_.jpg";
            this.MoviePicture.Location = new System.Drawing.Point(2, -2);
            this.MoviePicture.Name = "MoviePicture";
            this.MoviePicture.Size = new System.Drawing.Size(183, 268);
            this.MoviePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePicture.TabIndex = 0;
            this.MoviePicture.TabStop = false;
            this.MoviePicture.Click += new System.EventHandler(this.MovieImage_Click);
            // 
            // WatchlistButton
            // 
            this.WatchlistButton.Location = new System.Drawing.Point(2, -2);
            this.WatchlistButton.Name = "WatchlistButton";
            this.WatchlistButton.Size = new System.Drawing.Size(37, 29);
            this.WatchlistButton.TabIndex = 1;
            this.WatchlistButton.Text = "+";
            this.WatchlistButton.UseVisualStyleBackColor = true;
            this.WatchlistButton.Click += new System.EventHandler(this.WatchlistButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(2, 291);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(183, 29);
            this.InfoButton.TabIndex = 2;
            this.InfoButton.Text = "(i)";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.GlimpseButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(2, 273);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(29, 15);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // SingleMovieContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 321);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.WatchlistButton);
            this.Controls.Add(this.MoviePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingleMovieContainer";
            this.Text = "SingleMovieContainer";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePicture;
        private System.Windows.Forms.Button WatchlistButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}