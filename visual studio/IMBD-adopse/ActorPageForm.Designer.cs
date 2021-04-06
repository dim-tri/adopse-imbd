
namespace IMBD_adopse
{
    partial class ActorPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorPageForm));
            this.ActorPhotoDefault = new System.Windows.Forms.PictureBox();
            this.ActorDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ActorPhotoDefault)).BeginInit();
            this.SuspendLayout();
            // 
            // ActorPhotoDefault
            // 
            this.ActorPhotoDefault.BackColor = System.Drawing.Color.Black;
            this.ActorPhotoDefault.Location = new System.Drawing.Point(61, 41);
            this.ActorPhotoDefault.Name = "ActorPhotoDefault";
            this.ActorPhotoDefault.Size = new System.Drawing.Size(200, 248);
            this.ActorPhotoDefault.TabIndex = 0;
            this.ActorPhotoDefault.TabStop = false;
            // 
            // ActorDescription
            // 
            this.ActorDescription.BackColor = System.Drawing.Color.OldLace;
            this.ActorDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActorDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ActorDescription.Location = new System.Drawing.Point(292, 129);
            this.ActorDescription.Multiline = true;
            this.ActorDescription.Name = "ActorDescription";
            this.ActorDescription.Size = new System.Drawing.Size(383, 160);
            this.ActorDescription.TabIndex = 1;
            this.ActorDescription.TabStop = false;
            this.ActorDescription.Text = resources.GetString("ActorDescription.Text");
            this.ActorDescription.TextChanged += new System.EventHandler(this.ActorDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(609, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Age: 74";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(292, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birthday: 30 July 1947";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(292, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arnold Alois Schwarzenegger";
            // 
            // ActorPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1131, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActorDescription);
            this.Controls.Add(this.ActorPhotoDefault);
            this.Name = "ActorPageForm";
            this.Text = "Actor Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ActorPhotoDefault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ActorPhotoDefault;
        private System.Windows.Forms.TextBox ActorDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}