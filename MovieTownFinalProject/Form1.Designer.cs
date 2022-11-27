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
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(116, 63);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(501, 236);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // homePageUserNameInput
            // 
            this.homePageUserNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.homePageUserNameInput.Enabled = false;
            this.homePageUserNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageUserNameInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.homePageUserNameInput.Location = new System.Drawing.Point(219, 415);
            this.homePageUserNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.homePageUserNameInput.Name = "homePageUserNameInput";
            this.homePageUserNameInput.Size = new System.Drawing.Size(295, 23);
            this.homePageUserNameInput.TabIndex = 1;
            this.homePageUserNameInput.Text = "Enter User Name";
            // 
            // homePagePasswordInput
            // 
            this.homePagePasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.homePagePasswordInput.Enabled = false;
            this.homePagePasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePagePasswordInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.homePagePasswordInput.Location = new System.Drawing.Point(219, 478);
            this.homePagePasswordInput.Margin = new System.Windows.Forms.Padding(4);
            this.homePagePasswordInput.Name = "homePagePasswordInput";
            this.homePagePasswordInput.Size = new System.Drawing.Size(295, 23);
            this.homePagePasswordInput.TabIndex = 2;
            this.homePagePasswordInput.Text = "Enter Password";
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.signupButton.Location = new System.Drawing.Point(444, 592);
            this.signupButton.Margin = new System.Windows.Forms.Padding(4);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(129, 38);
            this.signupButton.TabIndex = 3;
            this.signupButton.Text = "Sign-Up";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginButton.Location = new System.Drawing.Point(160, 592);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(127, 38);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log-In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.employeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.employeeButton.Location = new System.Drawing.Point(303, 734);
            this.employeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(127, 38);
            this.employeeButton.TabIndex = 5;
            this.employeeButton.Text = "Employee";
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.welcomeLabel.Location = new System.Drawing.Point(312, 325);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(109, 25);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(732, 846);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.employeeButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.homePagePasswordInput);
            this.Controls.Add(this.homePageUserNameInput);
            this.Controls.Add(this.pictureBoxLogo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Town";
            this.Load += new System.EventHandler(this.HomePage_Load);
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
        private System.Windows.Forms.Label welcomeLabel;
    }
}

