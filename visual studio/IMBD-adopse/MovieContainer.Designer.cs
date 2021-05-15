
namespace IMBD_adopse
{
    partial class MovieContainer
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
            this.MovieImage = new System.Windows.Forms.PictureBox();
            this.MovieRating = new System.Windows.Forms.Label();
            this.MovieRuntime = new System.Windows.Forms.Label();
            this.MovieYear = new System.Windows.Forms.Label();
            this.MovieDesc = new System.Windows.Forms.RichTextBox();
            this.MovieTitle = new System.Windows.Forms.RichTextBox();
            this.MovieGenre = new System.Windows.Forms.Label();
            this.GlimpseButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MovieImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlimpseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieImage
            // 
            this.MovieImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MovieImage.ImageLocation = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlY" +
    "WMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL_.jpg";
            this.MovieImage.Location = new System.Drawing.Point(12, 12);
            this.MovieImage.Name = "MovieImage";
            this.MovieImage.Size = new System.Drawing.Size(182, 268);
            this.MovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MovieImage.TabIndex = 2;
            this.MovieImage.TabStop = false;
            this.MovieImage.Click += new System.EventHandler(this.MovieImage_Click);
            // 
            // MovieRating
            // 
            this.MovieRating.AutoSize = true;
            this.MovieRating.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieRating.Location = new System.Drawing.Point(356, 87);
            this.MovieRating.Name = "MovieRating";
            this.MovieRating.Size = new System.Drawing.Size(48, 19);
            this.MovieRating.TabIndex = 17;
            this.MovieRating.Text = "Rating";
            // 
            // MovieRuntime
            // 
            this.MovieRuntime.AutoSize = true;
            this.MovieRuntime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieRuntime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieRuntime.Location = new System.Drawing.Point(270, 87);
            this.MovieRuntime.Name = "MovieRuntime";
            this.MovieRuntime.Size = new System.Drawing.Size(60, 19);
            this.MovieRuntime.TabIndex = 16;
            this.MovieRuntime.Text = "Runtime";
            // 
            // MovieYear
            // 
            this.MovieYear.AutoSize = true;
            this.MovieYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieYear.Location = new System.Drawing.Point(211, 87);
            this.MovieYear.Name = "MovieYear";
            this.MovieYear.Size = new System.Drawing.Size(35, 19);
            this.MovieYear.TabIndex = 15;
            this.MovieYear.Text = "Year";
            // 
            // MovieDesc
            // 
            this.MovieDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.MovieDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieDesc.Location = new System.Drawing.Point(211, 150);
            this.MovieDesc.Name = "MovieDesc";
            this.MovieDesc.ReadOnly = true;
            this.MovieDesc.Size = new System.Drawing.Size(366, 99);
            this.MovieDesc.TabIndex = 14;
            this.MovieDesc.Text = "Desc";
            // 
            // MovieTitle
            // 
            this.MovieTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.MovieTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MovieTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieTitle.Location = new System.Drawing.Point(211, 12);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.ReadOnly = true;
            this.MovieTitle.Size = new System.Drawing.Size(404, 65);
            this.MovieTitle.TabIndex = 13;
            this.MovieTitle.Text = "Title Title";
            // 
            // MovieGenre
            // 
            this.MovieGenre.AutoSize = true;
            this.MovieGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MovieGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovieGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieGenre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MovieGenre.Location = new System.Drawing.Point(472, 87);
            this.MovieGenre.Name = "MovieGenre";
            this.MovieGenre.Size = new System.Drawing.Size(54, 23);
            this.MovieGenre.TabIndex = 18;
            this.MovieGenre.Text = "Genre";
            // 
            // GlimpseButton
            // 
            this.GlimpseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GlimpseButton.Image = global::IMBD_adopse.Properties.Resources.glimpse_icon;
            this.GlimpseButton.Location = new System.Drawing.Point(538, 246);
            this.GlimpseButton.Name = "GlimpseButton";
            this.GlimpseButton.Size = new System.Drawing.Size(39, 36);
            this.GlimpseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GlimpseButton.TabIndex = 19;
            this.GlimpseButton.TabStop = false;
            this.GlimpseButton.Click += new System.EventHandler(this.GlimpseButton_Click);
            // 
            // MovieContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(589, 294);
            this.Controls.Add(this.GlimpseButton);
            this.Controls.Add(this.MovieGenre);
            this.Controls.Add(this.MovieRating);
            this.Controls.Add(this.MovieRuntime);
            this.Controls.Add(this.MovieYear);
            this.Controls.Add(this.MovieDesc);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.MovieImage);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieContainer";
            this.Text = "MovieContainer";
            ((System.ComponentModel.ISupportInitialize)(this.MovieImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlimpseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MovieImage;
        private System.Windows.Forms.Label MovieRating;
        private System.Windows.Forms.Label MovieRuntime;
        private System.Windows.Forms.Label MovieYear;
        private System.Windows.Forms.RichTextBox MovieDesc;
        private System.Windows.Forms.RichTextBox MovieTitle;
        private System.Windows.Forms.Label MovieGenre;
        private System.Windows.Forms.PictureBox GlimpseButton;
    }
}