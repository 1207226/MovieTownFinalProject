﻿using System;
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
    public partial class MovieManagerForm : Form
    {
        public MovieManagerForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Set the Size of the Back Arrow to the Size of the Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieManagerForm_Load(object sender, EventArgs e)
        {
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Opens the Show Room Manager Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            ManagerSelectMenuForm SelectMenu = new ManagerSelectMenuForm();
            this.Hide();
            SelectMenu.ShowDialog();
            this.Close();
        }
    }
}
