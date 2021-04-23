
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
            this.flowPanelNewReleases = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPanelTopMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowPanelRecommended = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowPanelNewReleases
            // 
            this.flowPanelNewReleases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanelNewReleases.Location = new System.Drawing.Point(34, 89);
            this.flowPanelNewReleases.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowPanelNewReleases.Name = "flowPanelNewReleases";
            this.flowPanelNewReleases.Size = new System.Drawing.Size(1545, 391);
            this.flowPanelNewReleases.TabIndex = 5;
            // 
            // flowPanelTopMovies
            // 
            this.flowPanelTopMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanelTopMovies.Location = new System.Drawing.Point(35, 544);
            this.flowPanelTopMovies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowPanelTopMovies.Name = "flowPanelTopMovies";
            this.flowPanelTopMovies.Size = new System.Drawing.Size(1544, 391);
            this.flowPanelTopMovies.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Releases";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Top Movies";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 956);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Recommended for You";
            // 
            // flowPanelRecommended
            // 
            this.flowPanelRecommended.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanelRecommended.Location = new System.Drawing.Point(35, 1000);
            this.flowPanelRecommended.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowPanelRecommended.Name = "flowPanelRecommended";
            this.flowPanelRecommended.Size = new System.Drawing.Size(1544, 391);
            this.flowPanelRecommended.TabIndex = 9;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1656, 1102);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowPanelRecommended);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowPanelTopMovies);
            this.Controls.Add(this.flowPanelNewReleases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeForm";
            this.Text = "IMBD";
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
    }
}

