
namespace IMBD_adopse
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.flowPanelNewReleases = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPanelTopMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowPanelRecommended = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxNextTop = new System.Windows.Forms.PictureBox();
            this.pictureBoxPreviousTop = new System.Windows.Forms.PictureBox();
            this.pictureBoxPreviousNew = new System.Windows.Forms.PictureBox();
            this.pictureBoxNextNew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviousTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviousNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextNew)).BeginInit();
            this.SuspendLayout();
            // 
            // flowPanelNewReleases
            // 
            this.flowPanelNewReleases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanelNewReleases.Location = new System.Drawing.Point(129, 67);
            this.flowPanelNewReleases.Name = "flowPanelNewReleases";
            this.flowPanelNewReleases.Size = new System.Drawing.Size(1100, 293);
            this.flowPanelNewReleases.TabIndex = 5;
            // 
            // flowPanelTopMovies
            // 
            this.flowPanelTopMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanelTopMovies.Location = new System.Drawing.Point(129, 408);
            this.flowPanelTopMovies.Name = "flowPanelTopMovies";
            this.flowPanelTopMovies.Size = new System.Drawing.Size(1100, 293);
            this.flowPanelTopMovies.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Releases";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Top Movies";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 717);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Recommended for You";
            // 
            // flowPanelRecommended
            // 
            this.flowPanelRecommended.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanelRecommended.Location = new System.Drawing.Point(31, 750);
            this.flowPanelRecommended.Name = "flowPanelRecommended";
            this.flowPanelRecommended.Size = new System.Drawing.Size(1154, 293);
            this.flowPanelRecommended.TabIndex = 9;
            // 
            // pictureBoxNextTop
            // 
            this.pictureBoxNextTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNextTop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNextTop.Image")));
            this.pictureBoxNextTop.Location = new System.Drawing.Point(1231, 521);
            this.pictureBoxNextTop.Name = "pictureBoxNextTop";
            this.pictureBoxNextTop.Size = new System.Drawing.Size(69, 66);
            this.pictureBoxNextTop.TabIndex = 14;
            this.pictureBoxNextTop.TabStop = false;
            this.pictureBoxNextTop.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxPreviousTop
            // 
            this.pictureBoxPreviousTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPreviousTop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPreviousTop.Image")));
            this.pictureBoxPreviousTop.Location = new System.Drawing.Point(63, 521);
            this.pictureBoxPreviousTop.Name = "pictureBoxPreviousTop";
            this.pictureBoxPreviousTop.Size = new System.Drawing.Size(69, 66);
            this.pictureBoxPreviousTop.TabIndex = 15;
            this.pictureBoxPreviousTop.TabStop = false;
            this.pictureBoxPreviousTop.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxPreviousNew
            // 
            this.pictureBoxPreviousNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPreviousNew.Image = global::IMBD_adopse.Properties.Resources.icons8_back_64;
            this.pictureBoxPreviousNew.Location = new System.Drawing.Point(63, 159);
            this.pictureBoxPreviousNew.Name = "pictureBoxPreviousNew";
            this.pictureBoxPreviousNew.Size = new System.Drawing.Size(69, 66);
            this.pictureBoxPreviousNew.TabIndex = 16;
            this.pictureBoxPreviousNew.TabStop = false;
            this.pictureBoxPreviousNew.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxNextNew
            // 
            this.pictureBoxNextNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNextNew.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNextNew.Image")));
            this.pictureBoxNextNew.Location = new System.Drawing.Point(1231, 159);
            this.pictureBoxNextNew.Name = "pictureBoxNextNew";
            this.pictureBoxNextNew.Size = new System.Drawing.Size(69, 66);
            this.pictureBoxNextNew.TabIndex = 17;
            this.pictureBoxNextNew.TabStop = false;
            this.pictureBoxNextNew.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1403, 788);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxNextNew);
            this.Controls.Add(this.pictureBoxPreviousNew);
            this.Controls.Add(this.pictureBoxPreviousTop);
            this.Controls.Add(this.pictureBoxNextTop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowPanelRecommended);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowPanelTopMovies);
            this.Controls.Add(this.flowPanelNewReleases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeForm";
            this.Text = "IMBD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviousTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviousNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowPanelNewReleases;
        private System.Windows.Forms.FlowLayoutPanel flowPanelTopMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowPanelRecommended;
        private System.Windows.Forms.PictureBox pictureBoxNextTop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxPreviousNew;
        private System.Windows.Forms.PictureBox pictureBoxNextNew;
        private System.Windows.Forms.PictureBox pictureBoxPreviousTop;
    }
}

