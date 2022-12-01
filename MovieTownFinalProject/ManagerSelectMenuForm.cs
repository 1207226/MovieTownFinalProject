// <copyright file="ManagerSelectMenuForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Selection menu form.
    /// </summary>
    public partial class ManagerSelectMenuForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerSelectMenuForm"/> class.
        /// </summary>
        public ManagerSelectMenuForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Opens the Movie Manager Form, and Closes the Select Menu Form.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Execption.</param>
        private void OpenMoviesButton_Click(object sender, EventArgs e)
        {
            MovieManagerForm movieManager = new MovieManagerForm();
            this.Hide();
            movieManager.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Opens the Show Room Manager Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender">Button cliked.</param>
        /// <param name="e">Execption.</param>
        private void OpenShowRoom_Click(object sender, EventArgs e)
        {
            ShowRoomManagerForm showRoom = new ShowRoomManagerForm();
            this.Hide();
            showRoom.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Opens the Client Log-In Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Execption.</param>
        private void OpenShowTimeButton_Click(object sender, EventArgs e)
        {
            ManageShowTimeForm manageShowTimeForm = new ManageShowTimeForm();
            this.Hide();
            manageShowTimeForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Opens the Client Log-In Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Execption.</param>
        private void OpenClientButton_Click(object sender, EventArgs e)
        {
            // Quick fix.
            // MessageBox.Show("Sorry, form unavailible at the moment");
            ManageClientForm manageClientForm = new ManageClientForm();
            this.Hide();
            manageClientForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Opens the Client Log-In Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Execption.</param>
        private void EmployeeLogoutButton_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            this.Hide();
            homepage.ShowDialog();
            this.Close();
        }
    }
}
