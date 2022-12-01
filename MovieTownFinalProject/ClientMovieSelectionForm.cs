// <copyright file="ClientMovieSelectionForm.cs" company="PlaceholderCompany">
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
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Movie Selection Form for Clients.
    /// </summary>
    public partial class ClientMovieSelectionForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMovieSelectionForm"/> class.
        /// </summary>
        public ClientMovieSelectionForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Closes the Client Movie Selection Form, and starts the Home Page Form.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Execption.</param>
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }
    }
}
