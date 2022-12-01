// <copyright file="ManageShowTimeForm.cs" company="PlaceholderCompany">
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
    /// Manage Show times form.
    /// </summary>
    public partial class ManageShowTimeForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageShowTimeForm"/> class.
        /// </summary>
        public ManageShowTimeForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Set the Size of the Back Arrow to the Size of the Button.
        /// </summary>
        /// <param name="sender">Form is loading.</param>
        /// <param name="e">Execption.</param>
        private void ManageShowTimeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieTownDbDataSet.Showtime' table. You can move, or remove it, as needed.
            this.showtimeTableAdapter.Fill(this.movieTownDbDataSet.Showtime);
            this.backButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Opens Selection Menu Form Form and Closes the Show Time Manager Form.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Exception.</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            ManagerSelectMenuForm selectMenu = new ManagerSelectMenuForm();
            this.Hide();
            selectMenu.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Saves the changes to the Show time Data.
        /// </summary>
        /// <param name="sender">Save Button Cliecked.</param>
        /// <param name="e">Execption.</param>
        private void ShowtimeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.showtimeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieTownDbDataSet);
        }
    }
}
