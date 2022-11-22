namespace MovieTownFinalProject
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.homePageUserNameInput = new System.Windows.Forms.TextBox();
            this.homePagePasswordInput = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(91, 51);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(376, 192);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // homePageUserNameInput
            // 
            this.homePageUserNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.homePageUserNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageUserNameInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.homePageUserNameInput.Location = new System.Drawing.Point(171, 320);
            this.homePageUserNameInput.Name = "homePageUserNameInput";
            this.homePageUserNameInput.Size = new System.Drawing.Size(221, 19);
            this.homePageUserNameInput.TabIndex = 1;
            this.homePageUserNameInput.Text = "Enter User Name";
            // 
            // homePagePasswordInput
            // 
            this.homePagePasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.homePagePasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePagePasswordInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.homePagePasswordInput.Location = new System.Drawing.Point(171, 371);
            this.homePagePasswordInput.Name = "homePagePasswordInput";
            this.homePagePasswordInput.Size = new System.Drawing.Size(221, 19);
            this.homePagePasswordInput.TabIndex = 2;
            this.homePagePasswordInput.Text = "Enter Password";
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.signupButton.Location = new System.Drawing.Point(340, 453);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(97, 31);
            this.signupButton.TabIndex = 3;
            this.signupButton.Text = "Sign-Up";
            this.signupButton.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginButton.Location = new System.Drawing.Point(127, 453);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(95, 31);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log-In";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.employeeButton.Location = new System.Drawing.Point(228, 596);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(95, 31);
            this.employeeButton.TabIndex = 5;
            this.employeeButton.Text = "Employee";
            this.employeeButton.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(549, 687);
            this.Controls.Add(this.employeeButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.homePagePasswordInput);
            this.Controls.Add(this.homePageUserNameInput);
            this.Controls.Add(this.pictureBoxLogo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.Text = "Movie Town";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox homePageUserNameInput;
        private System.Windows.Forms.TextBox homePagePasswordInput;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button employeeButton;
    }
}

