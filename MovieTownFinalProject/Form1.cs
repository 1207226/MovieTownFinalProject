// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Home Page Form.
    /// </summary>
    public partial class HomePage : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// </summary>
        public HomePage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Sets the Page Focus on the Login Button on Load.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Execption.</param>
        private void HomePage_Load(object sender, EventArgs e)
        {
            this.loginButton.TabIndex = 0;
        }

        /// <summary>
        /// Opens the Empoloyee Log-In Form and Closes the Client Log-In Form.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Execption.</param>
        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogInForm mLForm = new ManagerLogInForm();
            mLForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Check the login credential of the client. If valid open the movie selection form.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Execption.</param>
        /// <remarks>At the moment only shows a message box. To change when movie selection form is made.</remarks>
        /// <remarks>Also only checks the input to some variables, integration with the database is not complete.</remarks>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Temporary testing values for user credential.
            string tempClientUserName = "user";
            string tempClientPassword = "password";

            string userName = this.homePageUserNameInput.Text;
            string userPassword = this.homePagePasswordInput.Text;

            if (userName == tempClientUserName && userPassword == tempClientPassword)
            {
                this.FeatureMissing();
            }

            if ((userName == "Enter User Name" || userName == "Re-Enter User Name") && (userPassword == "Enter Password" || userPassword == "Re-Enter Password"))
            {
                ManagerLogInForm.ScreenShake(this);
            }
            else if (userName != tempClientUserName || userPassword != tempClientPassword)
            {
                this.invalidInputLable1.Visible = true;
                this.invalidInputLabel2.Visible = true;
                this.homePageUserNameInput.ForeColor = Color.Red;
                this.homePageUserNameInput.Text = "Re-Enter User Name";
                this.homePagePasswordInput.PasswordChar = '\0';
                this.homePagePasswordInput.ForeColor = Color.Red;
                this.homePagePasswordInput.Text = "Re-Enter Password";

                ManagerLogInForm.ScreenShake(this);
            }
        }

        /// <summary>
        ///  Opens the Client Sign-Up Form and Closes the Client Log-In Form.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Execption.</param>
        private void SignupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientSignUpForm clientSignUpForm = new ClientSignUpForm();
            clientSignUpForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Opens a message box warning the user.
        /// </summary>
        private void FeatureMissing()
        {
            MessageBox.Show("Feature not yet availble. Please Login as an Employee.");
        }

        /// <summary>
        /// Calls a methode to clean the text if it holds a default value.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Exception.</param>
        private void HomePageUserNameInput_Click(object sender, EventArgs e)
        {
            if (this.homePageUserNameInput.Text == "Enter User Name" || this.homePageUserNameInput.Text == "Re-Enter User Name")
            {
                this.ClearTextBox(this.homePageUserNameInput);
            }
        }

        /// <summary>
        /// Calls a methode to clean the text if it holds a default value.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Execption.</param>
        private void HomePagePasswordInput_Click(object sender, EventArgs e)
        {
            if (this.homePagePasswordInput.Text == "Enter Password" || this.homePagePasswordInput.Text == "Re-Enter Password")
            {
                this.ClearTextBox(this.homePagePasswordInput);
            }
        }

        /// <summary>
        /// Checks the value being hold in a textBox and erases it depending of its value.
        /// </summary>
        /// <param name="textBox">Name of the textBox to be Cleared.</param>
        private void ClearTextBox(TextBox textBox)
        {
            textBox.Clear();
            textBox.ForeColor = Color.Black;

            if (textBox.Name == "homePagePasswordInput")
            {
                textBox.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Ereases the Text from HomePagePassowrdInput TextBox when Clicked if Text has Default Value.
        /// </summary>
        /// <param name="sender">A key is press while on the homePagePasswordInput textBox.</param>
        /// <param name="e">Exception.</param>
        private void HomePagePasswordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.homePagePasswordInput.Text == "Enter Password" || this.homePagePasswordInput.Text == "Re-Enter Password")
            {
                this.homePagePasswordInput.Clear();
                this.homePagePasswordInput.ForeColor = Color.Black;
                this.homePagePasswordInput.PasswordChar = '*';
            }
        }
    }
}
