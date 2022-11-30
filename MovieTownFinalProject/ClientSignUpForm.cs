// <copyright file="ClientSignUpForm.cs" company="PlaceholderCompany">
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
    /// Client SignUp Form.
    /// </summary>
    public partial class ClientSignUpForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSignUpForm"/> class.
        /// Initialize the components of ClientSignUpForm.
        /// </summary>
        public ClientSignUpForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Button to close this form and open Form1.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Checks if entered values are valid, if not calls methods to highligh mistakes. If all valid add a new client to db. 
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions</param>
        /// <remarks>After adding a new client closes this form, and opens the movie select form.</remarks>
        private void SignupButton_Click(object sender, EventArgs e)
        {
            int validField = 0;
            string userName = this.signUpUserNameTextBox.Text;
            string firstName = this.signUpFirstNameTextBox.Text;
            string lastName = this.signUpLastNameTextBox.Text;
            string email = this.signUpEmailTextBox.Text;
            string password1 = this.signUpPasswordTextBox1.Text;
            string password2 = this.signUpPasswordTextBox2.Text;

            string[] invalidChar = { " ", "!", "*", "@", "#", "#", "=", "+", "-" };
            string[] emailRequirement = { ".com", ".ca", ".net" };

            if (userName != "User Name" && invalidChar.Any(userName.Contains))
            {
                this.InvalidInput(this.signUpUserNameTextBox);
            }
            else
            {
                validField++;
            }

            if (firstName != "First Name" && invalidChar.Any(firstName.Contains))
            {
                this.InvalidInput(this.signUpFirstNameTextBox);
            }
            else
            {
                validField++;
            }

            if (lastName != "Last Name" && invalidChar.Any(lastName.Contains))
            {
                this.InvalidInput(this.signUpLastNameTextBox);
            }
            else
            {
                validField++;
            }

            if (email != "E-mail" && emailRequirement.Any(email.Contains) && email.Contains("@"))
            {
                validField++;
            }
            else
            {
                this.InvalidInput(this.signUpEmailTextBox);
            }

            if (password1 != password2)
            {
                this.InvalidInput(this.signUpPasswordTextBox2);
            }
            else
            {
                validField++;
            }

            if (validField != 5)
            {
                ManagerLogInForm.ScreenShake(this);
            }
            else
            {
                MessageBox.Show("Account Created!");
            }
        }

        /// <summary>
        /// Methode to be called when an input is invalid to change the textBox text.
        /// </summary>
        /// <param name="textBox">The name of the textBox the method is being applied to.</param>
        private void InvalidInput(TextBox textBox)
        {
            textBox.Clear();
            textBox.Text = "Invalid Input";
            textBox.ForeColor = Color.Red;

            if (textBox.PasswordChar == '*')
            {
                textBox.PasswordChar = '\0';
            }
        }

        /// <summary>
        /// Methode to be callled when the text field or passwarChar need to be reset for user input.
        /// </summary>
        /// <param name="textBox">The name of the textBox the method is being applied to.</param>
        private void CleanTextBox(TextBox textBox)
        {
            textBox.Clear();
            textBox.ForeColor = Color.Black;

            if (textBox.Name == "signUpPasswordTextBox1" || textBox.Name == "signUpPasswordTextBox2")
            {
                textBox.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        private void SignUpUserNameTextBox_Click(object sender, EventArgs e)
        {
            if (this.signUpUserNameTextBox.Text == "User Name" || this.signUpUserNameTextBox.Text == "Invalid Input")
            {
                this.CleanTextBox(this.signUpUserNameTextBox);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        private void SignUpFirstNameTextBox_Click(object sender, EventArgs e)
        {
            if (this.signUpFirstNameTextBox.Text == "First Name" || this.signUpFirstNameTextBox.Text == "Invalid Input")
            {
                this.CleanTextBox(this.signUpFirstNameTextBox);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        private void SignUpLastNameTextBox_Click(object sender, EventArgs e)
        {
            if (this.signUpLastNameTextBox.Text == "Last Name" || this.signUpLastNameTextBox.Text == "Invalid Input")
            {
                this.CleanTextBox(this.signUpLastNameTextBox);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        private void SignUpEmailTextBox_Click(object sender, EventArgs e)
        {
            if (this.signUpEmailTextBox.Text == "E-mail" || this.signUpEmailTextBox.Text == "Invalid Input")
            {
                this.CleanTextBox(this.signUpEmailTextBox);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        private void SignUpPasswordTextBox1_Click(object sender, EventArgs e)
        {
            if (this.signUpPasswordTextBox1.Text == "Password" || this.signUpPasswordTextBox1.Text == "Invalid Input")
            {
                this.CleanTextBox(this.signUpPasswordTextBox1);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        private void SignUpPasswordTextBox2_Click(object sender, EventArgs e)
        {
            if (this.signUpPasswordTextBox2.Text == "Re-Enter Password" || this.signUpPasswordTextBox2.Text == "Invalid Input")
            {
                this.CleanTextBox(this.signUpPasswordTextBox2);
            }
        }

        /// <summary>
        /// Set the focus on the SignUp button when the from is being loaded.
        /// </summary>
        /// <param name="sender">Form being loaded.</param>
        /// <param name="e">Exception.</param>
        private void ClientSignUpForm_Load(object sender, EventArgs e)
        {
            this.signupButton.TabIndex = 0;
        }
    }
}
