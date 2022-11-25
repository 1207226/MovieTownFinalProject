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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Opens the Empoloyee Log-In Form and Closes the Client Log-In Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogInForm mLForm = new ManagerLogInForm();
            mLForm.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Sets the Page Focus on the Login Button on Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomePage_Load(object sender, EventArgs e)
        {
            loginButton.TabIndex = 0;
        }
    }
}
