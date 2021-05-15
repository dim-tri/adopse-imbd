
namespace IMBD_adopse
{
    partial class UserPageReviewContainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.readmorelink = new System.Windows.Forms.Label();
            this.txtReview = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMovieName = new System.Windows.Forms.Label();
            this.rating1 = new IMBD_adopse.Rating();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.readmorelink);
            this.panel1.Controls.Add(this.txtReview);
            this.panel1.Location = new System.Drawing.Point(9, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 193);
            this.panel1.TabIndex = 0;
            // 
            // readmorelink
            // 
            this.readmorelink.AutoSize = true;
            this.readmorelink.Location = new System.Drawing.Point(278, 159);
            this.readmorelink.Name = "readmorelink";
            this.readmorelink.Size = new System.Drawing.Size(82, 20);
            this.readmorelink.TabIndex = 1;
            this.readmorelink.Text = "Read more";
            // 
            // txtReview
            // 
            this.txtReview.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReview.Location = new System.Drawing.Point(15, 20);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(345, 159);
            this.txtReview.TabIndex = 0;
            this.txtReview.Text = "Εδώ θα εμφανιστεί το σχόλιο του review Εδώ θα εμφανιστεί το σχόλιο του review";
            this.txtReview.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.rating1);
            this.panel2.Controls.Add(this.txtMovieName);
            this.panel2.Location = new System.Drawing.Point(9, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 42);
            this.panel2.TabIndex = 1;
            // 
            // txtMovieName
            // 
            this.txtMovieName.AutoSize = true;
            this.txtMovieName.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txtMovieName.Location = new System.Drawing.Point(8, 9);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(122, 26);
            this.txtMovieName.TabIndex = 0;
            this.txtMovieName.Text = "Movie Title";
            // 
            // rating1
            // 
            this.rating1.Location = new System.Drawing.Point(141, -2);
            this.rating1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rating1.Name = "rating1";
            this.rating1.Size = new System.Drawing.Size(238, 34);
            this.rating1.TabIndex = 2;
            this.rating1.Load += new System.EventHandler(this.rating1_Load);
            // 
            // UserPageReviewContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserPageReviewContainer";
            this.Size = new System.Drawing.Size(391, 246);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtReview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtMovieName;
        private System.Windows.Forms.Label readmorelink;
        private Rating rating1;
    }
}
