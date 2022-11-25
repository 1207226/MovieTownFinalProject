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
        private void employeeLoginButton_Click(object sender, EventArgs e)
        {
            //TODO : Add a conditional statement to to check credentials, if valid do below.
            ManagerSelectMenuForm SelectMenu = new ManagerSelectMenuForm();
            this.Hide();
            SelectMenu.ShowDialog();
            this.Close();
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
    }
}
