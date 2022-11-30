// <copyright file="MovieManagerForm.cs" company="PlaceholderCompany">
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
    /// Movie Manager Form.
    /// </summary>
    public partial class MovieManagerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovieManagerForm"/> class.
        /// </summary>
        public MovieManagerForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Set the Size of the Back Arrow to the Size of the Button.
        /// </summary>
        /// <param name="sender">Form being loaded.</param>
        /// <param name="e">Execption.</param>
        private void MovieManagerForm_Load(object sender, EventArgs e)
        {
            this.backButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Opens the Show Room Manager Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Execption.</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            ManagerSelectMenuForm selectMenu = new ManagerSelectMenuForm();
            this.Hide();
            selectMenu.ShowDialog();
            this.Close();
        }
    }
}
