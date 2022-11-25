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

namespace MovieTownFinalProject
{
    public partial class ManagerLogInForm : Form
    {
        public ManagerLogInForm()
        {
            InitializeComponent();
        }
        //Temporary Employee Number & Password for Testing.
        const string testEmpNumber = "123456";
        const string testPassword = "qwerty1";

        
        /// <summary>
        ///  Opens the Client Log-In Form and Closes the Empoloyee Log-In Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientLoginButton_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            this.Hide();
            homepage.ShowDialog();
            this.Close();

        }
        /// <summary>
        /// Opens the Manager Selection Menu Form and Closes the Empoloyee Log-In Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Check if the Empolyee Number & Password are valid and correspond to each others.</remarks>
        /// <remarks>Responds to Invalid Input by Reseting TextBox Text with New Message & Style.</remarks>
        private void employeeLoginButton_Click(object sender, EventArgs e)
        {
            //TODO : Add a conditional statement to to check credentials, if valid do below.

            string employeeNumber = employeeNumberInput.Text;
            string password = employeePasswordInput.Text;

            if (employeeNumber == testEmpNumber && password == testPassword)
            {
                ManagerSelectMenuForm SelectMenu = new ManagerSelectMenuForm();
                this.Hide();
                SelectMenu.ShowDialog();
                this.Close();
            }
            if ((employeeNumber == "Enter Employee Number" && password == "Enter Password") || (employeeNumber == "Re-Enter Employee Number" && password == "Re-Enter Password"))
            {
                ScreenShake(this);
            } 
            else if (employeeNumber != testEmpNumber || password != testPassword)
            {
                ScreenShake(this);
                invalidInputLable1.Visible = true;
                invalidInputLabel2.Visible = true;
                employeeNumberInput.ForeColor = Color.Red;
                employeeNumberInput.Text = "Re-Enter Employee Number";
                employeePasswordInput.PasswordChar = '\0';
                employeePasswordInput.ForeColor = Color.Red;
                employeePasswordInput.Text = "Re-Enter Password";
            }   
        }
        /// <summary>
        /// Sets the Page Focus on the Employee Login Button on Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerLogInForm_Load(object sender, EventArgs e)
        {
            employeeLoginButton.TabIndex = 0;

        }
        /// <summary>
        /// Ereases the Text from employeeNumberInput TextBox when Clicked if Text has Default Value. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Also Changes the Text Color.</remarks>
        private void employeeNumberInput_Click(object sender, EventArgs e)
        {
            if (employeeNumberInput.Text == "Enter Employee Number" || employeeNumberInput.Text == "Re-Enter Employee Number")
            {
                employeeNumberInput.Clear();
                employeeNumberInput.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Ereases the Text from employeePasswordInput TextBox when Clicked if Text has Default Value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Also Changes the Text Color & Sets PasswordChar.</remarks>
        private void employeePasswordInput_Click(object sender, EventArgs e)
        {
            if (employeePasswordInput.Text == "Enter Password" || employeePasswordInput.Text == "Re-Enter Password")
            {
                employeePasswordInput.Clear();
                employeePasswordInput.ForeColor = Color.Black;
                employeePasswordInput.PasswordChar = '*';
            }
        }
        /// <summary>
        /// Methode to Shake the Application, to be used incasae of wrong input.
        /// </summary>
        /// <param name="form">Gets the "this" parameter to use its location.</param>
        /// <remarks>Because i could, and it's kind of fun.</remarks>
        private static void ScreenShake(Form form)
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
    }
}
