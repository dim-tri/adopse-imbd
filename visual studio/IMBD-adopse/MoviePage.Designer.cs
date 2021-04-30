
namespace IMBD_adopse
{
    partial class MoviePage
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
            this.MovieTitle = new System.Windows.Forms.Label();
            this.MovieDesc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelStar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxReview = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.movieRating = new IMBD_adopse.Rating();
            this.label8 = new System.Windows.Forms.Label();
            this.userRateLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.flowLayoutPanelComments = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabelView = new System.Windows.Forms.LinkLabel();
            this.labelComments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MovieImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.MovieImage.TabIndex = 1;
            this.MovieImage.TabStop = false;
            // 
            // MovieTitle
            // 
            this.MovieTitle.AutoSize = true;
            this.MovieTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieTitle.Location = new System.Drawing.Point(378, 12);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(149, 37);
            this.MovieTitle.TabIndex = 2;
            this.MovieTitle.Text = "Movie Title";
            // 
            // MovieDesc
            // 
            this.MovieDesc.BackColor = System.Drawing.SystemColors.Menu;
            this.MovieDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieDesc.Location = new System.Drawing.Point(314, 350);
            this.MovieDesc.Name = "MovieDesc";
            this.MovieDesc.ReadOnly = true;
            this.MovieDesc.Size = new System.Drawing.Size(487, 146);
            this.MovieDesc.TabIndex = 7;
            this.MovieDesc.Text = "Desc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(245, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(245, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(245, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Release Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(245, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Starring:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(245, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rating:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(314, 70);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(33, 21);
            this.labelCategory.TabIndex = 13;
            this.labelCategory.Text = "Cat";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLength.Location = new System.Drawing.Point(301, 106);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(35, 21);
            this.labelLength.TabIndex = 14;
            this.labelLength.Text = "Len";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(341, 144);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 21);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "Cat";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRating.Location = new System.Drawing.Point(301, 181);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(33, 21);
            this.labelRating.TabIndex = 16;
            this.labelRating.Text = "Cat";
            // 
            // labelStar
            // 
            this.labelStar.AutoSize = true;
            this.labelStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStar.Location = new System.Drawing.Point(314, 214);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(33, 21);
            this.labelStar.TabIndex = 17;
            this.labelStar.Text = "Cat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(309, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Description";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(245, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 25);
            this.panel2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(309, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Review";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Goldenrod;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(245, 557);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 25);
            this.panel4.TabIndex = 24;
            // 
            // textBoxReview
            // 
            this.textBoxReview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxReview.Location = new System.Drawing.Point(245, 628);
            this.textBoxReview.MaxLength = 400;
            this.textBoxReview.Multiline = true;
            this.textBoxReview.Name = "textBoxReview";
            this.textBoxReview.Size = new System.Drawing.Size(602, 130);
            this.textBoxReview.TabIndex = 25;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(245, 764);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 27;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(962, 91);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(401, 491);
            this.flowLayoutPanel2.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(130, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "See Also";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Goldenrod;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(962, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(401, 25);
            this.panel6.TabIndex = 32;
            // 
            // movieRating
            // 
            this.movieRating.Enabled = false;
            this.movieRating.Location = new System.Drawing.Point(245, 588);
            this.movieRating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.movieRating.Name = "movieRating";
            this.movieRating.Size = new System.Drawing.Size(384, 34);
            this.movieRating.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(245, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 21);
            this.label8.TabIndex = 34;
            this.label8.Text = "User Ratings:";
            // 
            // userRateLabel
            // 
            this.userRateLabel.AutoSize = true;
            this.userRateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userRateLabel.Location = new System.Drawing.Point(343, 248);
            this.userRateLabel.Name = "userRateLabel";
            this.userRateLabel.Size = new System.Drawing.Size(31, 21);
            this.userRateLabel.TabIndex = 35;
            this.userRateLabel.Text = "8.0";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 297);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(182, 236);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanelComments
            // 
            this.flowLayoutPanelComments.Location = new System.Drawing.Point(245, 815);
            this.flowLayoutPanelComments.Name = "flowLayoutPanelComments";
            this.flowLayoutPanelComments.Size = new System.Drawing.Size(602, 282);
            this.flowLayoutPanelComments.TabIndex = 37;
            // 
            // linkLabelView
            // 
            this.linkLabelView.AutoSize = true;
            this.linkLabelView.Location = new System.Drawing.Point(743, 772);
            this.linkLabelView.Name = "linkLabelView";
            this.linkLabelView.Size = new System.Drawing.Size(104, 15);
            this.linkLabelView.TabIndex = 38;
            this.linkLabelView.TabStop = true;
            this.linkLabelView.Text = "See All Comments";
            this.linkLabelView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelView_LinkClicked);
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelComments.Location = new System.Drawing.Point(490, 787);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(107, 25);
            this.labelComments.TabIndex = 0;
            this.labelComments.Text = "Comments";
            // 
            // MoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1403, 788);
            this.ControlBox = false;
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.linkLabelView);
            this.Controls.Add(this.flowLayoutPanelComments);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.userRateLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.movieRating);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxReview);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelStar);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieDesc);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.MovieImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoviePage";
            this.Text = "MoviePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.MovieImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MovieImage;
        private System.Windows.Forms.Label MovieTitle;
        private System.Windows.Forms.RichTextBox MovieDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelStar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxReview;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        public Rating movieRating;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label userRateLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelComments;
        private System.Windows.Forms.LinkLabel linkLabelView;
        private System.Windows.Forms.Label labelComments;
    }
}