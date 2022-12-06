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
        /// Lunch the CheckLogin Methode to verify users credential for validation.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Execption.</param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.CheckLogIn();
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

            if (this.homePagePasswordInput.Text == string.Empty)
            {
                this.homePagePasswordInput.PasswordChar = '\0';
                this.homePagePasswordInput.Text = "Enter Password";
                this.homePagePasswordInput.ForeColor = Color.Gray;
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

            if (this.homePageUserNameInput.Text == string.Empty)
            {
                this.homePageUserNameInput.Text = "Enter User Name";
                this.homePageUserNameInput.ForeColor = Color.Gray;
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
        /// <remarks> Also checks if the enter key is press, if so lunch the CheckLogin methode.</remarks>
        private void HomePagePasswordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.homePagePasswordInput.Text == "Enter Password" || this.homePagePasswordInput.Text == "Re-Enter Password")
            {
                this.homePagePasswordInput.Clear();
                this.homePagePasswordInput.ForeColor = Color.Black;
                this.homePagePasswordInput.PasswordChar = '*';
            }

            if (e.KeyChar == (char)13)
            {
                this.CheckLogIn();
            }
        }

        /// <summary>
        /// Check the login credential of the client. If valid open the movie selection form.
        /// </summary>
        /// <remarks>Also only checks the input to some variables, integration with the database is not complete.</remarks>
        private void CheckLogIn()
        {
            string userName = this.homePageUserNameInput.Text;
            string userPassword = this.homePagePasswordInput.Text;

            if (this.CheckUsername(userName, userPassword))
            {
                this.Hide();
                ClientMovieSelectionForm movieSelectionForm = new ClientMovieSelectionForm();
                movieSelectionForm.ShowDialog();
                this.Close();
            }

            if ((userName == "Enter User Name" || userName == "Re-Enter User Name") && (userPassword == "Enter Password" || userPassword == "Re-Enter Password"))
            {
                ManagerLogInForm.ScreenShake(this);
            }
            else
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

        private bool CheckUsername(string username, string password)
        {
            MovieTheatre theatre = new MovieTheatre();

            foreach (User user in theatre.Users)
            {
                if (user is Client)
                {
                    Client client = (Client)user;

                    if (client.Username == username && client.Password == password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
