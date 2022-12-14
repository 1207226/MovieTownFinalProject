// <copyright file="ManagerLogInForm.cs" company="PlaceholderCompany">
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
    using System.Runtime.Remoting.Channels;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    /// <summary>
    /// Manager logIn form.
    /// </summary>
    public partial class ManagerLogInForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerLogInForm"/> class.
        /// </summary>
        public ManagerLogInForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Methode to Shake the Application, to be used incasae of wrong input.
        /// </summary>
        /// <param name="form">Gets the "this" parameter to use its location.</param>
        /// <remarks>Because i could, and it's kind of fun.</remarks>
        public static void ScreenShake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake = 5;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake, shake), original.Y + rnd.Next(-shake, shake));
                System.Threading.Thread.Sleep(20);
            }

            form.Location = original;
        }

        /// <summary>
        ///  Opens the Client Log-In Form and Closes the Empoloyee Log-In Form.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Execption.</param>
        private void ClientLoginButton_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            this.Hide();
            homepage.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Lunch the CheckLogin Methode to verify user's credential.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Execption.</param>
        private void EmployeeLoginButton_Click(object sender, EventArgs e)
        {
            this.CheckLogin();
        }

        /// <summary>
        /// Sets the Page Focus on the Employee Login Button on Load.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Exeption.</param>
        private void ManagerLogInForm_Load(object sender, EventArgs e)
        {
            this.employeeLoginButton.TabIndex = 0;
        }

        /// <summary>
        /// Ereases the Text from employeeNumberInput TextBox when Clicked if Text has Default Value.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Execption.</param>
        /// <remarks>Also Changes the Text Color.</remarks>
        private void EmployeeNumberInput_Click(object sender, EventArgs e)
        {
            if (this.employeeNumberInput.Text == "Enter Employee Number" || this.employeeNumberInput.Text == "Re-Enter Employee Number")
            {
                this.employeeNumberInput.Clear();
                this.employeeNumberInput.ForeColor = Color.Black;
            }

            if (this.employeePasswordInput.Text == string.Empty)
            {
                this.employeePasswordInput.PasswordChar = '\0';
                this.employeePasswordInput.Text = "Enter Password";
                this.employeePasswordInput.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Ereases the Text from employeePasswordInput TextBox when Clicked if Text has Default Value.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Execption.</param>
        /// <remarks>Also Changes the Text Color & Sets PasswordChar.</remarks>
        private void EmployeePasswordInput_Click(object sender, EventArgs e)
        {
            if (this.employeePasswordInput.Text == "Enter Password" || this.employeePasswordInput.Text == "Re-Enter Password")
            {
                this.employeePasswordInput.Clear();
                this.employeePasswordInput.ForeColor = Color.Black;
                this.employeePasswordInput.PasswordChar = '*';
            }

            if (this.employeeNumberInput.Text == string.Empty)
            {
                this.employeeNumberInput.Text = "Enter Employee Number";
                this.employeeNumberInput.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Ereases the Text from employeePassowrdInput TextBox when Clicked if Text has Default Value.
        /// </summary>
        /// <param name="sender">Key press from keyboard.</param>
        /// <param name="e">Execption.</param>
        /// <remarks>Also Changes the Text Color & Sets PasswordChar.</remarks>
        /// <remarks>Checks if the enter key is press, if so lunches the CheckLogin methode.</remarks>
        private void EmployeePasswordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.employeePasswordInput.Text == "Enter Password" || this.employeePasswordInput.Text == "Re-Enter Password")
            {
                this.employeePasswordInput.Clear();
                this.employeePasswordInput.ForeColor = Color.Black;
                this.employeePasswordInput.PasswordChar = '*';
            }

            if (e.KeyChar == (char)13)
            {
                this.CheckLogin();
            }
        }

        /// <summary>
        /// Post note memo interactive text on click.
        /// </summary>
        /// <param name="sender">Label is Cliked.</param>
        /// <param name="e">Execption.</param>
        private void PostNoteLabel_Click(object sender, EventArgs e)
        {
            if (this.postNoteLabel.Text == "\r\nLogin Information:\r\n\r\nEmployee # : 123456\r\n\r\nPassword  : qwerty1\r\n")
            {
                this.postNoteLabel.Text = "PS: Please do not leave sensitive information publicly accesseble.";
            }
            else
            {
                this.postNoteLabel.Text = "\r\nLogin Information:\r\n\r\nEmployee # : 123456\r\n\r\nPassword  : qwerty1\r\n";
            }
        }

        /// <summary>
        /// Opens the Manager Selection Menu Form and Closes the Empoloyee Log-In Form.
        /// </summary>
        /// <remarks>Check if the Empolyee Number & Password are valid and correspond to each others.</remarks>
        /// <remarks>Responds to Invalid Input by Reseting TextBox Text with New Message & Style.</remarks>
        private void CheckLogin()
        {
            // TODO : Add a conditional statement to to check credentials, if valid do below.
            if (int.TryParse(this.employeeNumberInput.Text, out int employeeNumber))
            {
                string password = this.employeePasswordInput.Text;

                if (this.CheckEmployeeNumber(employeeNumber, password))
                {
                    ManagerSelectMenuForm selectMenu = new ManagerSelectMenuForm();
                    this.Hide();
                    selectMenu.ShowDialog();
                    this.Close();
                }

                if ((this.employeeNumberInput.Text == "Enter Employee Number" && password == "Enter Password") || (this.employeeNumberInput.Text == "Re-Enter Employee Number" && password == "Re-Enter Password"))
                {
                    ScreenShake(this);
                }
                else
                {
                    ScreenShake(this);
                    this.invalidInputLable1.Visible = true;
                    this.invalidInputLabel2.Visible = true;
                    this.employeeNumberInput.ForeColor = Color.Red;
                    this.employeeNumberInput.Text = "Re-Enter Employee Number";
                    this.employeePasswordInput.PasswordChar = '\0';
                    this.employeePasswordInput.ForeColor = Color.Red;
                    this.employeePasswordInput.Text = "Re-Enter Password";
                }
            }
            else
            {
                ScreenShake(this);
                this.invalidInputLable1.Visible = true;
                this.invalidInputLabel2.Visible = true;
                this.employeeNumberInput.ForeColor = Color.Red;
                this.employeeNumberInput.Text = "Re-Enter Employee Number";
                this.employeePasswordInput.PasswordChar = '\0';
                this.employeePasswordInput.ForeColor = Color.Red;
                this.employeePasswordInput.Text = "Re-Enter Password";
            }
        }

        private bool CheckEmployeeNumber(int employeeNumber, string password)
        {
            MovieTheatre theatre = new MovieTheatre();

            foreach (User user in theatre.Users)
            {
                if (user is Employee)
                {
                    Employee employee = (Employee)user;

                    if (employee.EmployeeNumber == employeeNumber && employee.Password == password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
