using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTownFinalProject
{
    public partial class ClientSignUpForm : Form
    {
        public ClientSignUpForm()
        {
            this.InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Checks if entered values are valid, if not calls methods to highligh mistakes. If all valid add a new client to db. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>After adding a new client closes this form, and opens the movie select form.</remarks>
        private void SignupButton_Click(object sender, EventArgs e)
        {
            string userName = this.signUpUserNameTextBox.Text;
            string firstName = this.signUpFirstNameTextBox.Text;
            string lastName = this.signUpLastNameTextBox.Text;
            string email = this.signUpEmailTextBox.Text;
            string password1 = this.signUpPasswordTextBox1.Text;
            string password2 = this.signUpPasswordTextBox2.Text;

            string[] invalidChar = {" ", "!", "*", "@", "#","#", "=", "+", "-"};

            if (userName != "User Name" && invalidChar.Any(userName.Contains))
            {
                this.InvalidInput(this.signUpUserNameTextBox);
                ManagerLogInForm.ScreenShake(this);
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpLastNameTextBox_Click(object sender, EventArgs e)
        {
            if (this.signUpLastNameTextBox.Text == "Last Name" || this.signUpLastNameTextBox.Text == "invalid Input")
            {
                this.CleanTextBox(this.signUpLastNameTextBox);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpEmailTextBox_Click(object sender, EventArgs e)
        {
            if (this.signUpEmailTextBox.Text == "E-mail" || this.signUpEmailTextBox.Text == "invalid Input")
            {
                this.CleanTextBox(signUpEmailTextBox);
            }
        }

        /// <summary>
        /// Clear the textBox being clicked on, if it hold defult values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpPasswordTextBox2_Click(object sender, EventArgs e)
        {
            if (this.signUpPasswordTextBox2.Text == "Re-Enter Password" || this.signUpPasswordTextBox2.Text == "Invalid Input")
            {
                this.CleanTextBox(this.signUpPasswordTextBox2);
            }
        }
    }
}
