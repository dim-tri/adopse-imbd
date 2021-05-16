
namespace IMBD_adopse
{
    partial class WatchlistContainer
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
            this.MovieTitle = new System.Windows.Forms.RichTextBox();
            this.MovieDesc = new System.Windows.Forms.RichTextBox();
            this.MovieYear = new System.Windows.Forms.Label();
            this.MovieRuntime = new System.Windows.Forms.Label();
            this.MovieRating = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MovieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieImage
            // 
            this.MovieImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MovieImage.ImageLocation = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlY" +
    "WMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL_.jpg";
            this.MovieImage.Location = new System.Drawing.Point(8, 5);
            this.MovieImage.Name = "MovieImage";
            this.MovieImage.Size = new System.Drawing.Size(182, 268);
            this.MovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MovieImage.TabIndex = 1;
            this.MovieImage.TabStop = false;
            this.MovieImage.Click += new System.EventHandler(this.MovieImage_Click);
            // 
            // MovieTitle
            // 
            this.MovieTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.MovieTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MovieTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieTitle.Location = new System.Drawing.Point(189, 5);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.ReadOnly = true;
            this.MovieTitle.Size = new System.Drawing.Size(404, 65);
            this.MovieTitle.TabIndex = 8;
            this.MovieTitle.Text = "Title Title";
            // 
            // MovieDesc
            // 
            this.MovieDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.MovieDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieDesc.Location = new System.Drawing.Point(189, 143);
            this.MovieDesc.Name = "MovieDesc";
            this.MovieDesc.ReadOnly = true;
            this.MovieDesc.Size = new System.Drawing.Size(404, 60);
            this.MovieDesc.TabIndex = 9;
            this.MovieDesc.Text = "Desc";
            // 
            // MovieYear
            // 
            this.MovieYear.AutoSize = true;
            this.MovieYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieYear.Location = new System.Drawing.Point(189, 80);
            this.MovieYear.Name = "MovieYear";
            this.MovieYear.Size = new System.Drawing.Size(35, 19);
            this.MovieYear.TabIndex = 10;
            this.MovieYear.Text = "Year";
            // 
            // MovieRuntime
            // 
            this.MovieRuntime.AutoSize = true;
            this.MovieRuntime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieRuntime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieRuntime.Location = new System.Drawing.Point(248, 80);
            this.MovieRuntime.Name = "MovieRuntime";
            this.MovieRuntime.Size = new System.Drawing.Size(60, 19);
            this.MovieRuntime.TabIndex = 11;
            this.MovieRuntime.Text = "Runtime";
            // 
            // MovieRating
            // 
            this.MovieRating.AutoSize = true;
            this.MovieRating.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieRating.Location = new System.Drawing.Point(334, 80);
            this.MovieRating.Name = "MovieRating";
            this.MovieRating.Size = new System.Drawing.Size(48, 19);
            this.MovieRating.TabIndex = 12;
            this.MovieRating.Text = "Rating";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(156)))));
            this.panel1.Location = new System.Drawing.Point(603, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 285);
            this.panel1.TabIndex = 13;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveBtn.Image = global::IMBD_adopse.Properties.Resources.heartSmall1;
            this.RemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveBtn.Location = new System.Drawing.Point(231, 236);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(122, 37);
            this.RemoveBtn.TabIndex = 15;
            this.RemoveBtn.Text = "Out of";
            this.RemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // WatchlistContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(683, 278);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MovieRating);
            this.Controls.Add(this.MovieRuntime);
            this.Controls.Add(this.MovieYear);
            this.Controls.Add(this.MovieDesc);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.MovieImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WatchlistContainer";
            this.Text = "WatchlistContainer";
            ((System.ComponentModel.ISupportInitialize)(this.MovieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MovieImage;
        private System.Windows.Forms.RichTextBox MovieTitle;
        private System.Windows.Forms.RichTextBox MovieDesc;
        private System.Windows.Forms.Label MovieYear;
        private System.Windows.Forms.Label MovieRuntime;
        private System.Windows.Forms.Label MovieRating;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveBtn;
    }
}