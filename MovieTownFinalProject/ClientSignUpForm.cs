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
            InitializeComponent();
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
        private void signupButton_Click(object sender, EventArgs e)
        {
            string userName = signUpUserNameTextBox.Text;
            string firstName = signUpFirstNameTextBox.Text;
            string lastName = signUpLastNameTextBox.Text;
            string email = signUpEmailTextBox.Text;
            string password1 = signUpPasswordTextBox1.Text;
            string password2 = signUpPasswordTextBox2.Text;
            string[] invalidChar = {" ", "!", "*", "@", "#","#", "=", "+", "-"};
            //Work in progress; needs to get the contains statment work with an array.
            //if (userName != "User Name" && userName.Contains(invalidChar[]))
            //{
            //    invalidInput(signUpUserNameTextBox);
            //    ManagerLogInForm.ScreenShake(this);
            //}
        }

        public void invalidInput(TextBox textBox)
        {
            textBox.Clear();
            textBox.Text = "Invalid Input";
            textBox.ForeColor = Color.Red;

            if(textBox.PasswordChar == '*')
            {
                textBox.PasswordChar = '\0';
            }
        }
    }
}
