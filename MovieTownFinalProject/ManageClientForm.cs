// <copyright file="ManageClientForm.cs" company="PlaceholderCompany">
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
    /// Manage Client Form.
    /// </summary>
    public partial class ManageClientForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageClientForm"/> class.
        /// </summary>
        public ManageClientForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Set the Size of the Back Arrow to the Size of the Button.
        /// </summary>
        /// <param name="sender">Form Loadgin.</param>
        /// <param name="e">Exception.</param>
        private void ManageClientForm_Load(object sender, EventArgs e)
        {
            this.backButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Opens Selection Menu Form Form and Closes the Show Time Manager Form.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Exception.</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            ManagerSelectMenuForm frm = new ManagerSelectMenuForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
