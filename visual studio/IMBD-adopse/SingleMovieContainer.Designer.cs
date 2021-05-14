
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GlimpseButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlimpseButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviePicture
            // 
            this.MoviePicture.ImageLocation = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlY" +
    "WMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL_.jpg";
            this.MoviePicture.Location = new System.Drawing.Point(0, 0);
            this.MoviePicture.Name = "MoviePicture";
            this.MoviePicture.Size = new System.Drawing.Size(183, 239);
            this.MoviePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePicture.TabIndex = 0;
            this.MoviePicture.TabStop = false;
            this.MoviePicture.Click += new System.EventHandler(this.MovieImage_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.TitleLabel.Location = new System.Drawing.Point(0, 242);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(138, 45);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "dhshshshsfhjdjdjdfjdgjfdhdhdfdjdjdg";
            // 
            // GlimpseButton
            // 
            this.GlimpseButton.Image = global::IMBD_adopse.Properties.Resources.glimpse_icon;
            this.GlimpseButton.Location = new System.Drawing.Point(144, 251);
            this.GlimpseButton.Name = "GlimpseButton";
            this.GlimpseButton.Size = new System.Drawing.Size(39, 36);
            this.GlimpseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GlimpseButton.TabIndex = 4;
            this.GlimpseButton.TabStop = false;
            this.GlimpseButton.Click += new System.EventHandler(this.GlimpseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.GlimpseButton);
            this.panel1.Controls.Add(this.MoviePicture);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 293);
            this.panel1.TabIndex = 6;
            // 
            // SingleMovieContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(190, 293);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingleMovieContainer";
            this.Text = "SingleMovieContainer";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlimpseButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePicture;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox GlimpseButton;
        private System.Windows.Forms.Panel panel1;
    }
}