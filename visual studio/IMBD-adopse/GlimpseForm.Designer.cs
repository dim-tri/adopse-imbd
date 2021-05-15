
namespace IMBD_adopse
{
    partial class GlimpseForm
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
            this.MovieYear = new System.Windows.Forms.Label();
            this.MovieRuntime = new System.Windows.Forms.Label();
            this.MovieRating = new System.Windows.Forms.Label();
            this.MovieDesc = new System.Windows.Forms.RichTextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.MoreButton = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.labelExit = new System.Windows.Forms.Label();
            this.MovieTitle = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MovieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieImage
            // 
            this.MovieImage.ImageLocation = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlY" +
    "WMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL_.jpg";
            this.MovieImage.Location = new System.Drawing.Point(17, 18);
            this.MovieImage.Name = "MovieImage";
            this.MovieImage.Size = new System.Drawing.Size(182, 268);
            this.MovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MovieImage.TabIndex = 0;
            this.MovieImage.TabStop = false;
            // 
            // MovieYear
            // 
            this.MovieYear.AutoSize = true;
            this.MovieYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MovieYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieYear.Location = new System.Drawing.Point(204, 95);
            this.MovieYear.Name = "MovieYear";
            this.MovieYear.Size = new System.Drawing.Size(39, 19);
            this.MovieYear.TabIndex = 3;
            this.MovieYear.Text = "Year";
            this.MovieYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MovieRuntime
            // 
            this.MovieRuntime.AutoSize = true;
            this.MovieRuntime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MovieRuntime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieRuntime.Location = new System.Drawing.Point(315, 95);
            this.MovieRuntime.Name = "MovieRuntime";
            this.MovieRuntime.Size = new System.Drawing.Size(64, 19);
            this.MovieRuntime.TabIndex = 4;
            this.MovieRuntime.Text = "Runtime";
            // 
            // MovieRating
            // 
            this.MovieRating.AutoSize = true;
            this.MovieRating.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MovieRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieRating.Location = new System.Drawing.Point(450, 95);
            this.MovieRating.Name = "MovieRating";
            this.MovieRating.Size = new System.Drawing.Size(52, 19);
            this.MovieRating.TabIndex = 5;
            this.MovieRating.Text = "Rating";
            // 
            // MovieDesc
            // 
            this.MovieDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(156)))));
            this.MovieDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MovieDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieDesc.Location = new System.Drawing.Point(204, 117);
            this.MovieDesc.Name = "MovieDesc";
            this.MovieDesc.ReadOnly = true;
            this.MovieDesc.Size = new System.Drawing.Size(400, 107);
            this.MovieDesc.TabIndex = 6;
            this.MovieDesc.Text = "Desc";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.AddBtn.Enabled = false;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Image = global::IMBD_adopse.Properties.Resources.heartSmall1;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBtn.Location = new System.Drawing.Point(481, 240);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(122, 37);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add to";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MoreButton
            // 
            this.MoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MoreButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.MoreButton.Location = new System.Drawing.Point(202, 240);
            this.MoreButton.Margin = new System.Windows.Forms.Padding(0);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(130, 37);
            this.MoreButton.TabIndex = 10;
            this.MoreButton.Text = "View More";
            this.MoreButton.UseVisualStyleBackColor = false;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.RemoveBtn.Enabled = false;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveBtn.Image = global::IMBD_adopse.Properties.Resources.heartSmall1;
            this.RemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveBtn.Location = new System.Drawing.Point(346, 240);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(122, 37);
            this.RemoveBtn.TabIndex = 11;
            this.RemoveBtn.Text = "Out of";
            this.RemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(593, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(24, 24);
            this.labelExit.TabIndex = 12;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseEnter += new System.EventHandler(this.labelExit_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            // 
            // MovieTitle
            // 
            this.MovieTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.MovieTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MovieTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.MovieTitle.Location = new System.Drawing.Point(205, 18);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.ReadOnly = true;
            this.MovieTitle.Size = new System.Drawing.Size(400, 68);
            this.MovieTitle.TabIndex = 7;
            this.MovieTitle.Text = "Titlfgdhdhhdhdshgshjdsjdsgjdfsdhfdhdhfd";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 86);
            this.panel1.TabIndex = 13;
            // 
            // GlimpseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(616, 298);
            this.ControlBox = false;
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.MoreButton);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MovieDesc);
            this.Controls.Add(this.MovieRating);
            this.Controls.Add(this.MovieRuntime);
            this.Controls.Add(this.MovieYear);
            this.Controls.Add(this.MovieImage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GlimpseForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GlimpseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MovieImage;
        private System.Windows.Forms.Label MovieYear;
        private System.Windows.Forms.Label MovieRuntime;
        private System.Windows.Forms.Label MovieRating;
        private System.Windows.Forms.RichTextBox MovieDesc;
        private System.Windows.Forms.Button MoreButton;
        public System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.RichTextBox MovieTitle;
        private System.Windows.Forms.Panel panel1;
    }

}