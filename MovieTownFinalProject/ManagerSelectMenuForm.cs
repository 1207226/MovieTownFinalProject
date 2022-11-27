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
        /// Opens the Movie Manager Form, and Closes the Select Menu Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openMoviesButton_Click(object sender, EventArgs e)
        {
            MovieManagerForm movieManager = new MovieManagerForm();
            this.Hide();
            movieManager.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Opens the Show Room Manager Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openShowRoom_Click(object sender, EventArgs e)
        {
            ShowRoomManagerForm showRoom = new ShowRoomManagerForm();
            this.Hide();
            showRoom.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Opens the Client Log-In Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openShowTimeButton_Click(object sender, EventArgs e)
        {
            ManageShowTimeForm manageShowTimeForm = new ManageShowTimeForm();
            this.Hide();
            manageShowTimeForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Opens the Client Log-In Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Broken at the momment. p(T_T')</remarks>
        private void openClientButton_Click(object sender, EventArgs e)
        {
            // Quick fix.
            MessageBox.Show("Sorry, form unavailible at the moment");
            //ManageClientForm manageClientForm = new ManageClientForm();
            //this.Hide();
            //manageClientForm.ShowDialog();
            //this.Close();
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
