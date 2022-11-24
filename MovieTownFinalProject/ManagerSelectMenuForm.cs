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
    public partial class ManagerSelectMenuForm : Form
    {
        public ManagerSelectMenuForm()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openMoviesButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Opens the Client Log-In Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openShowRoom_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Opens the Client Log-In Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openShowTimeButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Opens the Client Log-In Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openClientButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Opens the Client Log-In Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeLogoutButton_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            this.Hide();
            homepage.ShowDialog();
            this.Close();

        }
    }
}
