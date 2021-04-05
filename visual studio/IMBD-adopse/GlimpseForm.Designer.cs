
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
            this.MovieTitle = new System.Windows.Forms.RichTextBox();
            this.WishlistButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MovieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieImage
            // 
            this.MovieImage.ImageLocation = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlY" +
    "WMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL_.jpg";
            this.MovieImage.Location = new System.Drawing.Point(12, 12);
            this.MovieImage.Name = "MovieImage";
            this.MovieImage.Size = new System.Drawing.Size(182, 268);
            this.MovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MovieImage.TabIndex = 0;
            this.MovieImage.TabStop = false;
            // 
            // MovieYear
            // 
            this.MovieYear.AutoSize = true;
            this.MovieYear.Location = new System.Drawing.Point(200, 79);
            this.MovieYear.Name = "MovieYear";
            this.MovieYear.Size = new System.Drawing.Size(29, 15);
            this.MovieYear.TabIndex = 3;
            this.MovieYear.Text = "Year";
            // 
            // MovieRuntime
            // 
            this.MovieRuntime.AutoSize = true;
            this.MovieRuntime.Location = new System.Drawing.Point(296, 79);
            this.MovieRuntime.Name = "MovieRuntime";
            this.MovieRuntime.Size = new System.Drawing.Size(52, 15);
            this.MovieRuntime.TabIndex = 4;
            this.MovieRuntime.Text = "Runtime";
            // 
            // MovieRating
            // 
            this.MovieRating.AutoSize = true;
            this.MovieRating.Location = new System.Drawing.Point(423, 79);
            this.MovieRating.Name = "MovieRating";
            this.MovieRating.Size = new System.Drawing.Size(41, 15);
            this.MovieRating.TabIndex = 5;
            this.MovieRating.Text = "Rating";
            // 
            // MovieDesc
            // 
            this.MovieDesc.BackColor = System.Drawing.SystemColors.Menu;
            this.MovieDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieDesc.Location = new System.Drawing.Point(200, 106);
            this.MovieDesc.Name = "MovieDesc";
            this.MovieDesc.ReadOnly = true;
            this.MovieDesc.Size = new System.Drawing.Size(404, 60);
            this.MovieDesc.TabIndex = 6;
            this.MovieDesc.Text = "Desc";
            // 
            // MovieTitle
            // 
            this.MovieTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.MovieTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MovieTitle.Location = new System.Drawing.Point(200, 16);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.ReadOnly = true;
            this.MovieTitle.Size = new System.Drawing.Size(404, 65);
            this.MovieTitle.TabIndex = 7;
            this.MovieTitle.Text = "Title Title";
            // 
            // WishlistButton
            // 
            this.WishlistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WishlistButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WishlistButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WishlistButton.Location = new System.Drawing.Point(468, 236);
            this.WishlistButton.Margin = new System.Windows.Forms.Padding(0);
            this.WishlistButton.Name = "WishlistButton";
            this.WishlistButton.Size = new System.Drawing.Size(116, 37);
            this.WishlistButton.TabIndex = 8;
            this.WishlistButton.Text = "+ Wishlist";
            this.WishlistButton.UseVisualStyleBackColor = true;
            this.WishlistButton.Click += new System.EventHandler(this.WishlistButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(585, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 31);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // GlimpseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 298);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.WishlistButton);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.MovieDesc);
            this.Controls.Add(this.MovieRating);
            this.Controls.Add(this.MovieRuntime);
            this.Controls.Add(this.MovieYear);
            this.Controls.Add(this.MovieImage);
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
        private System.Windows.Forms.RichTextBox MovieTitle;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.Button WishlistButton;
    }

}