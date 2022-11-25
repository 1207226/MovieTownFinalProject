namespace MovieTownFinalProject
{
    partial class ManagerLogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerLogInForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.employeePasswordInput = new System.Windows.Forms.TextBox();
            this.employeeNumberInput = new System.Windows.Forms.TextBox();
            this.employeeLoginButton = new System.Windows.Forms.Button();
            this.clientLoginButton = new System.Windows.Forms.Button();
            this.EmployeeLogInLabel = new System.Windows.Forms.Label();
            this.invalidInputLable1 = new System.Windows.Forms.Label();
            this.invalidInputLabel2 = new System.Windows.Forms.Label();
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
            // employeePasswordInput
            // 
            this.employeePasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeePasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePasswordInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.employeePasswordInput.Location = new System.Drawing.Point(219, 478);
            this.employeePasswordInput.Margin = new System.Windows.Forms.Padding(4);
            this.employeePasswordInput.Name = "employeePasswordInput";
            this.employeePasswordInput.Size = new System.Drawing.Size(295, 23);
            this.employeePasswordInput.TabIndex = 4;
            this.employeePasswordInput.Text = "Enter Password";
            this.employeePasswordInput.Click += new System.EventHandler(this.employeePasswordInput_Click);
            // 
            // employeeNumberInput
            // 
            this.employeeNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.employeeNumberInput.Location = new System.Drawing.Point(219, 415);
            this.employeeNumberInput.Margin = new System.Windows.Forms.Padding(4);
            this.employeeNumberInput.Name = "employeeNumberInput";
            this.employeeNumberInput.Size = new System.Drawing.Size(295, 23);
            this.employeeNumberInput.TabIndex = 3;
            this.employeeNumberInput.Text = "Enter Employee Number";
            this.employeeNumberInput.Click += new System.EventHandler(this.employeeNumberInput_Click);
            // 
            // employeeLoginButton
            // 
            this.employeeLoginButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.employeeLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeLoginButton.FlatAppearance.BorderSize = 0;
            this.employeeLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLoginButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.employeeLoginButton.Location = new System.Drawing.Point(303, 597);
            this.employeeLoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.employeeLoginButton.Name = "employeeLoginButton";
            this.employeeLoginButton.Size = new System.Drawing.Size(127, 38);
            this.employeeLoginButton.TabIndex = 5;
            this.employeeLoginButton.Text = "Log-In";
            this.employeeLoginButton.UseVisualStyleBackColor = false;
            this.employeeLoginButton.Click += new System.EventHandler(this.employeeLoginButton_Click);
            // 
            // clientLoginButton
            // 
            this.clientLoginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clientLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientLoginButton.FlatAppearance.BorderSize = 0;
            this.clientLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLoginButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clientLoginButton.Location = new System.Drawing.Point(303, 734);
            this.clientLoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.clientLoginButton.Name = "clientLoginButton";
            this.clientLoginButton.Size = new System.Drawing.Size(127, 38);
            this.clientLoginButton.TabIndex = 6;
            this.clientLoginButton.Text = "Client Log-In";
            this.clientLoginButton.UseVisualStyleBackColor = false;
            this.clientLoginButton.Click += new System.EventHandler(this.clientLoginButton_Click);
            // 
            // EmployeeLogInLabel
            // 
            this.EmployeeLogInLabel.AutoSize = true;
            this.EmployeeLogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLogInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.EmployeeLogInLabel.Location = new System.Drawing.Point(251, 325);
            this.EmployeeLogInLabel.Name = "EmployeeLogInLabel";
            this.EmployeeLogInLabel.Size = new System.Drawing.Size(179, 25);
            this.EmployeeLogInLabel.TabIndex = 9;
            this.EmployeeLogInLabel.Text = "Enter Credentials";
            // 
            // invalidInputLable1
            // 
            this.invalidInputLable1.AutoSize = true;
            this.invalidInputLable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidInputLable1.ForeColor = System.Drawing.Color.Red;
            this.invalidInputLable1.Location = new System.Drawing.Point(187, 415);
            this.invalidInputLable1.Name = "invalidInputLable1";
            this.invalidInputLable1.Size = new System.Drawing.Size(28, 36);
            this.invalidInputLable1.TabIndex = 10;
            this.invalidInputLable1.Text = "*";
            this.invalidInputLable1.Visible = false;
            // 
            // invalidInputLabel2
            // 
            this.invalidInputLabel2.AutoSize = true;
            this.invalidInputLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidInputLabel2.ForeColor = System.Drawing.Color.Red;
            this.invalidInputLabel2.Location = new System.Drawing.Point(187, 478);
            this.invalidInputLabel2.Name = "invalidInputLabel2";
            this.invalidInputLabel2.Size = new System.Drawing.Size(28, 36);
            this.invalidInputLabel2.TabIndex = 11;
            this.invalidInputLabel2.Text = "*";
            this.invalidInputLabel2.Visible = false;
            // 
            // ManagerLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(732, 846);
            this.Controls.Add(this.invalidInputLabel2);
            this.Controls.Add(this.invalidInputLable1);
            this.Controls.Add(this.EmployeeLogInLabel);
            this.Controls.Add(this.employeeNumberInput);
            this.Controls.Add(this.clientLoginButton);
            this.Controls.Add(this.employeeLoginButton);
            this.Controls.Add(this.employeePasswordInput);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "ManagerLogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerLogInForm";
            this.Load += new System.EventHandler(this.ManagerLogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox employeePasswordInput;
        private System.Windows.Forms.TextBox employeeNumberInput;
        private System.Windows.Forms.Button employeeLoginButton;
        private System.Windows.Forms.Button clientLoginButton;
        private System.Windows.Forms.Label EmployeeLogInLabel;
        private System.Windows.Forms.Label invalidInputLable1;
        private System.Windows.Forms.Label invalidInputLabel2;
    }
}