
namespace IMBD_adopse
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.PictureBox();
            this.surnameBox = new System.Windows.Forms.PictureBox();
            this.emailBox = new System.Windows.Forms.PictureBox();
            this.usernameBox = new System.Windows.Forms.PictureBox();
            this.passwordBox = new System.Windows.Forms.PictureBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.correctIcon = new System.Windows.Forms.PictureBox();
            this.RegisterForm = new System.Windows.Forms.Label();
            this.wrongIcon = new System.Windows.Forms.PictureBox();
            this.registerIcon = new System.Windows.Forms.PictureBox();
            this.lineBox2 = new System.Windows.Forms.PictureBox();
            this.lineBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.name.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.name.Location = new System.Drawing.Point(121, 182);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(309, 29);
            this.name.TabIndex = 0;
            this.name.Text = " name";
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.surname.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surname.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.surname.Location = new System.Drawing.Point(121, 225);
            this.surname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(309, 29);
            this.surname.TabIndex = 1;
            this.surname.Text = " surname";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.email.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.email.Location = new System.Drawing.Point(121, 268);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(309, 29);
            this.email.TabIndex = 2;
            this.email.Text = " email";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.username.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.username.Location = new System.Drawing.Point(121, 310);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(309, 29);
            this.username.TabIndex = 3;
            this.username.Text = " username";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.password.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.password.Location = new System.Drawing.Point(121, 353);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(309, 29);
            this.password.TabIndex = 4;
            this.password.Text = " password";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nameBox.Location = new System.Drawing.Point(90, 182);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(32, 28);
            this.nameBox.TabIndex = 5;
            this.nameBox.TabStop = false;
            this.nameBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // surnameBox
            // 
            this.surnameBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.surnameBox.Location = new System.Drawing.Point(90, 225);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(32, 28);
            this.surnameBox.TabIndex = 6;
            this.surnameBox.TabStop = false;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.emailBox.Location = new System.Drawing.Point(90, 268);
            this.emailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(32, 28);
            this.emailBox.TabIndex = 7;
            this.emailBox.TabStop = false;
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.usernameBox.Location = new System.Drawing.Point(90, 310);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(32, 28);
            this.usernameBox.TabIndex = 8;
            this.usernameBox.TabStop = false;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.passwordBox.Location = new System.Drawing.Point(90, 353);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(32, 28);
            this.passwordBox.TabIndex = 9;
            this.passwordBox.TabStop = false;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Gold;
            this.registerBtn.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.registerBtn.Location = new System.Drawing.Point(90, 400);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(340, 28);
            this.registerBtn.TabIndex = 10;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // correctIcon
            // 
            this.correctIcon.Location = new System.Drawing.Point(435, 182);
            this.correctIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.correctIcon.Name = "correctIcon";
            this.correctIcon.Size = new System.Drawing.Size(33, 28);
            this.correctIcon.TabIndex = 11;
            this.correctIcon.TabStop = false;
            // 
            // RegisterForm
            // 
            this.RegisterForm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RegisterForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterForm.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RegisterForm.Location = new System.Drawing.Point(90, 40);
            this.RegisterForm.Name = "RegisterForm";
            this.RegisterForm.Size = new System.Drawing.Size(340, 42);
            this.RegisterForm.TabIndex = 12;
            this.RegisterForm.Text = "Registration Form";
            this.RegisterForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrongIcon
            // 
            this.wrongIcon.Location = new System.Drawing.Point(435, 225);
            this.wrongIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wrongIcon.Name = "wrongIcon";
            this.wrongIcon.Size = new System.Drawing.Size(33, 28);
            this.wrongIcon.TabIndex = 13;
            this.wrongIcon.TabStop = false;
            // 
            // registerIcon
            // 
            this.registerIcon.Image = ((System.Drawing.Image)(resources.GetObject("registerIcon.Image")));
            this.registerIcon.Location = new System.Drawing.Point(232, 93);
            this.registerIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerIcon.Name = "registerIcon";
            this.registerIcon.Size = new System.Drawing.Size(57, 76);
            this.registerIcon.TabIndex = 14;
            this.registerIcon.TabStop = false;
            // 
            // lineBox2
            // 
            this.lineBox2.Image = ((System.Drawing.Image)(resources.GetObject("lineBox2.Image")));
            this.lineBox2.Location = new System.Drawing.Point(313, 128);
            this.lineBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineBox2.Name = "lineBox2";
            this.lineBox2.Size = new System.Drawing.Size(116, 9);
            this.lineBox2.TabIndex = 15;
            this.lineBox2.TabStop = false;
            // 
            // lineBox1
            // 
            this.lineBox1.Image = ((System.Drawing.Image)(resources.GetObject("lineBox1.Image")));
            this.lineBox1.Location = new System.Drawing.Point(90, 128);
            this.lineBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineBox1.Name = "lineBox1";
            this.lineBox1.Size = new System.Drawing.Size(116, 9);
            this.lineBox1.TabIndex = 16;
            this.lineBox1.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(530, 471);
            this.Controls.Add(this.lineBox1);
            this.Controls.Add(this.lineBox2);
            this.Controls.Add(this.registerIcon);
            this.Controls.Add(this.wrongIcon);
            this.Controls.Add(this.RegisterForm);
            this.Controls.Add(this.correctIcon);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.email);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            ((System.ComponentModel.ISupportInitialize)(this.nameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox nameBox;
        private System.Windows.Forms.PictureBox surnameBox;
        private System.Windows.Forms.PictureBox emailBox;
        private System.Windows.Forms.PictureBox usernameBox;
        private System.Windows.Forms.PictureBox passwordBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.PictureBox correctIcon;
        private System.Windows.Forms.Label RegisterForm;
        private System.Windows.Forms.PictureBox wrongIcon;
        private System.Windows.Forms.PictureBox registerIcon;
        private System.Windows.Forms.PictureBox lineBox2;
        private System.Windows.Forms.PictureBox lineBox1;
    }
}