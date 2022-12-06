// <copyright file="ClientSignUpForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
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
        /// Lunch the AccuntValidation method.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        private void SignupButton_Click(object sender, EventArgs e)
        {
            this.AccountValidation();
        }

        /// <summary>
        /// Method to be called when an input is invalid to change the textBox text.
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
        /// <remarks>Also checks if other text boxes are empty by using the ResetEmptyTextBox method.</remarks>
        private void SignUpUserNameTextBox_Click(object sender, EventArgs e)
        {
            if (this.signUpUserNameTextBox.Text == "User Name" || this.signUpUserNameTextBox.Text == "Invalid Input")
            {
                this.ResetEmptyTextBox();
                this.CleanTextBox(this.signUpUserNameTextBox);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        /// <remarks>Also checks if other text boxes are empty by using the ResetEmptyTextBox method.</remarks>
        private void SignUpFirstNameTextBox_Click(object sender, EventArgs e)
        {
            if (this.signUpFirstNameTextBox.Text == "First Name" || this.signUpFirstNameTextBox.Text == "Invalid Input")
            {
                this.ResetEmptyTextBox();
                this.CleanTextBox(this.signUpFirstNameTextBox);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        /// <remarks>Also checks if other text boxes are empty by using the ResetEmptyTextBox method.</remarks>
        private void SignUpLastNameTextBox_Click(object sender, EventArgs e)
        {
            if (this.signUpLastNameTextBox.Text == "Last Name" || this.signUpLastNameTextBox.Text == "Invalid Input")
            {
                this.ResetEmptyTextBox();
                this.CleanTextBox(this.signUpLastNameTextBox);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        /// <remarks>Also checks if other text boxes are empty by using the ResetEmptyTextBox method.</remarks>
        private void SignUpEmailTextBox_Click(object sender, EventArgs e)
        {
            if (this.signUpEmailTextBox.Text == "E-mail" || this.signUpEmailTextBox.Text == "Invalid Input")
            {
                this.ResetEmptyTextBox();
                this.CleanTextBox(this.signUpEmailTextBox);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        /// <remarks>Also checks if other text boxes are empty by using the ResetEmptyTextBox method.</remarks>
        private void SignUpPasswordTextBox1_Click(object sender, EventArgs e)
        {
            if (this.signUpPasswordTextBox1.Text == "Password" || this.signUpPasswordTextBox1.Text == "Invalid Input")
            {
                this.ResetEmptyTextBox();
                this.CleanTextBox(this.signUpPasswordTextBox1);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Exeptions.</param>
        /// <remarks>Also checks if other text boxes are empty by using the ResetEmptyTextBox method.</remarks>
        private void SignUpPasswordTextBox2_Click(object sender, EventArgs e)
        {
            if (this.signUpPasswordTextBox2.Text == "Re-Enter Password" || this.signUpPasswordTextBox2.Text == "Invalid Input")
            {
                this.ResetEmptyTextBox();
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

        /// <summary>
        /// Goes through the full list of every textBoxes to make sure they are not empty, if so set them to their default values.
        /// </summary>
        private void ResetEmptyTextBox()
        {
           foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Name == "signUpUserNameTextBox")
                    {
                        if (c.Text == string.Empty)
                        {
                            c.Text = "User Name";
                            c.ForeColor = Color.Gray;
                        }
                    }

                    if (c.Name == "signUpFirstNameTextBox")
                    {
                        if (c.Text == string.Empty)
                        {
                            c.Text = "First Name";
                            c.ForeColor = Color.Gray;
                        }
                    }

                    if (c.Name == "signUpLastNameTextBox")
                    {
                        if (c.Text == string.Empty)
                        {
                            c.Text = "Last Name";
                            c.ForeColor = Color.Gray;
                        }
                    }

                    if (c.Name == "signUpEmailTextBox")
                    {
                        if (c.Text == string.Empty)
                        {
                            c.Text = "E-mail";
                            c.ForeColor = Color.Gray;
                        }
                    }

                    if (c.Name == "signUpPasswordTextBox1")
                    {
                        if (c.Text == string.Empty)
                        {
                            c.Text = "Password";
                            c.ForeColor = Color.Gray;
                            this.signUpPasswordTextBox1.PasswordChar = '\0';
                        }
                    }

                    if (c.Name == "signUpPasswordTextBox2")
                    {
                        if (c.Text == string.Empty)
                        {
                            c.Text = "Re-Enter Password";
                            c.ForeColor = Color.Gray;
                            this.signUpPasswordTextBox2.PasswordChar = '\0';
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Sets the text box so that password is hiden, incase the text box is being access by pressing tab.
        /// </summary>
        /// <param name="sender">Key being pressed.</param>
        /// <param name="e">Exeption.</param>
        private void SignUpPasswordTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.signUpPasswordTextBox1.Text == "Password" || this.signUpPasswordTextBox1.Text == "Invalid Input")
            {
                this.signUpPasswordTextBox1.Clear();
                this.signUpPasswordTextBox1.ForeColor = Color.Black;
                this.signUpPasswordTextBox1.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Sets the text box so that password is hiden, incase the text box is being access by pressing tab.
        /// </summary>
        /// <param name="sender">Key being pressed.</param>
        /// <param name="e">Execption.</param>
        /// <remarks>Also looks if the key being press was Enter, if so lunch the AccountValidation method.</remarks>
        private void SignUpPasswordTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.signUpPasswordTextBox2.Text == "Re-Enter Password" || this.signUpPasswordTextBox2.Text == "Invalid Input")
            {
                this.signUpPasswordTextBox2.Text = string.Empty;
                this.signUpPasswordTextBox2.ForeColor = Color.Black;
                this.signUpPasswordTextBox2.PasswordChar = '*';
            }

            if (e.KeyChar == (char)13)
            {
                this.AccountValidation();
            }
        }

        /// <summary>
        /// Checks if entered values are valid, if not calls methods to highligh mistakes. If all valid add a new client to db.
        /// </summary>
        /// <remarks>After adding a new client closes this form, and opens the movie select form.</remarks>
        private void AccountValidation()
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
                SqlConnection conn = new SqlConnection
                {
                    ConnectionString =
                  "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                  "Initial Catalog=C:\\MOVIETOWNDB\\MOVIETOWNDB.MDF;",
                };

                SqlCommand command = new SqlCommand($"INSERT INTO Client (Username, FirstName, LastName, Email, Password) VALUES (@username, @firstName, @lastName, @email, @password)", conn);
                command.Parameters.AddWithValue("@username", userName);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password1);

                conn.Open();

                command.ExecuteReader();

                MessageBox.Show("Account Created!");
                this.Hide();
                ClientMovieSelectionForm clientMovieSelectionForm = new ClientMovieSelectionForm();
                clientMovieSelectionForm.ShowDialog();
                this.Close();
            }
        }
    }
}
