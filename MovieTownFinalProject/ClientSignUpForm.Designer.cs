namespace MovieTownFinalProject
{
    partial class ClientSignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientSignUpForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.signUpUserNameTextBox = new System.Windows.Forms.TextBox();
            this.signUpFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.signUpEmailTextBox = new System.Windows.Forms.TextBox();
            this.signUpLastNameTextBox = new System.Windows.Forms.TextBox();
            this.signUpPasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.signUpPasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.invalidInputLable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // signUpUserNameTextBox
            // 
            this.signUpUserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signUpUserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpUserNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.signUpUserNameTextBox.Location = new System.Drawing.Point(219, 398);
            this.signUpUserNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.signUpUserNameTextBox.Name = "signUpUserNameTextBox";
            this.signUpUserNameTextBox.Size = new System.Drawing.Size(295, 23);
            this.signUpUserNameTextBox.TabIndex = 2;
            this.signUpUserNameTextBox.Text = "User Name";
            this.signUpUserNameTextBox.Click += new System.EventHandler(this.SignUpUserNameTextBox_Click);
            // 
            // signUpFirstNameTextBox
            // 
            this.signUpFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signUpFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpFirstNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.signUpFirstNameTextBox.Location = new System.Drawing.Point(219, 450);
            this.signUpFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.signUpFirstNameTextBox.Name = "signUpFirstNameTextBox";
            this.signUpFirstNameTextBox.Size = new System.Drawing.Size(295, 23);
            this.signUpFirstNameTextBox.TabIndex = 3;
            this.signUpFirstNameTextBox.Text = "First Name";
            this.signUpFirstNameTextBox.Click += new System.EventHandler(this.SignUpFirstNameTextBox_Click);
            // 
            // signUpEmailTextBox
            // 
            this.signUpEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signUpEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpEmailTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.signUpEmailTextBox.Location = new System.Drawing.Point(219, 554);
            this.signUpEmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.signUpEmailTextBox.Name = "signUpEmailTextBox";
            this.signUpEmailTextBox.Size = new System.Drawing.Size(295, 23);
            this.signUpEmailTextBox.TabIndex = 5;
            this.signUpEmailTextBox.Text = "E-mail";
            this.signUpEmailTextBox.Click += new System.EventHandler(this.SignUpEmailTextBox_Click);
            // 
            // signUpLastNameTextBox
            // 
            this.signUpLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signUpLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLastNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.signUpLastNameTextBox.Location = new System.Drawing.Point(219, 502);
            this.signUpLastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.signUpLastNameTextBox.Name = "signUpLastNameTextBox";
            this.signUpLastNameTextBox.Size = new System.Drawing.Size(295, 23);
            this.signUpLastNameTextBox.TabIndex = 4;
            this.signUpLastNameTextBox.Text = "Last Name";
            this.signUpLastNameTextBox.Click += new System.EventHandler(this.SignUpLastNameTextBox_Click);
            // 
            // signUpPasswordTextBox1
            // 
            this.signUpPasswordTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signUpPasswordTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPasswordTextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.signUpPasswordTextBox1.Location = new System.Drawing.Point(219, 606);
            this.signUpPasswordTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.signUpPasswordTextBox1.Name = "signUpPasswordTextBox1";
            this.signUpPasswordTextBox1.Size = new System.Drawing.Size(295, 23);
            this.signUpPasswordTextBox1.TabIndex = 6;
            this.signUpPasswordTextBox1.Text = "Password";
            this.signUpPasswordTextBox1.Click += new System.EventHandler(this.SignUpPasswordTextBox1_Click);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.signupButton.Location = new System.Drawing.Point(302, 727);
            this.signupButton.Margin = new System.Windows.Forms.Padding(4);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(129, 38);
            this.signupButton.TabIndex = 8;
            this.signupButton.Text = "Create Account";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.welcomeLabel.Location = new System.Drawing.Point(254, 337);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(224, 25);
            this.welcomeLabel.TabIndex = 10;
            this.welcomeLabel.Text = "Enter your Information";
            // 
            // signUpPasswordTextBox2
            // 
            this.signUpPasswordTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signUpPasswordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPasswordTextBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.signUpPasswordTextBox2.Location = new System.Drawing.Point(219, 658);
            this.signUpPasswordTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.signUpPasswordTextBox2.Name = "signUpPasswordTextBox2";
            this.signUpPasswordTextBox2.Size = new System.Drawing.Size(295, 23);
            this.signUpPasswordTextBox2.TabIndex = 11;
            this.signUpPasswordTextBox2.Text = "Re-Enter Password";
            this.signUpPasswordTextBox2.Click += new System.EventHandler(this.SignUpPasswordTextBox2_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(35, 28);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(74, 50);
            this.backButton.TabIndex = 12;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // invalidInputLable1
            // 
            this.invalidInputLable1.AutoSize = true;
            this.invalidInputLable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidInputLable1.ForeColor = System.Drawing.Color.Red;
            this.invalidInputLable1.Location = new System.Drawing.Point(184, 398);
            this.invalidInputLable1.Name = "invalidInputLable1";
            this.invalidInputLable1.Size = new System.Drawing.Size(28, 36);
            this.invalidInputLable1.TabIndex = 13;
            this.invalidInputLable1.Text = "*";
            this.invalidInputLable1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(184, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "*";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(184, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "*";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(184, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "*";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(184, 658);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 36);
            this.label4.TabIndex = 18;
            this.label4.Text = "*";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(184, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "*";
            this.label5.Visible = false;
            // 
            // ClientSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(732, 846);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invalidInputLable1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.signUpPasswordTextBox2);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.signUpPasswordTextBox1);
            this.Controls.Add(this.signUpEmailTextBox);
            this.Controls.Add(this.signUpLastNameTextBox);
            this.Controls.Add(this.signUpFirstNameTextBox);
            this.Controls.Add(this.signUpUserNameTextBox);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "ClientSignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox signUpUserNameTextBox;
        private System.Windows.Forms.TextBox signUpFirstNameTextBox;
        private System.Windows.Forms.TextBox signUpEmailTextBox;
        private System.Windows.Forms.TextBox signUpLastNameTextBox;
        private System.Windows.Forms.TextBox signUpPasswordTextBox1;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox signUpPasswordTextBox2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label invalidInputLable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}