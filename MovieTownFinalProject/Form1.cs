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
    /// <summary>
    ///
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
        /// Sets the Page Focus on the Login Button on Load.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Execption.</param>
        private void HomePage_Load(object sender, EventArgs e)
        {
            this.loginButton.TabIndex = 0;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.FeatureMissing();
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
    }
}
