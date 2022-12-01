// <copyright file="ShowRoomManagerForm.cs" company="PlaceholderCompany">
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
    /// Manage Show Room Form.
    /// </summary>
    public partial class ShowRoomManagerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowRoomManagerForm"/> class.
        /// </summary>
        public ShowRoomManagerForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Set the Size of the Back Arrow to the Size of the Button.
        /// </summary>
        /// <param name="sender">Form loading.</param>
        /// <param name="e">Execption.</param>
        private void ShowRoomManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieTownDbDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.movieTownDbDataSet.Room);
            this.backButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Opens Selection Menu Form Form and Closes the Show Room Manager Form.
        /// </summary>
        /// <param name="sender">Button Clicked.</param>
        /// <param name="e">Execption.</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            ManagerSelectMenuForm selectMenu = new ManagerSelectMenuForm();
            this.Hide();
            selectMenu.ShowDialog();
            this.Close();
        }

        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieTownDbDataSet);

        }
    }
}
