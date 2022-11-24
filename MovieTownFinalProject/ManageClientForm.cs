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
    public partial class ManageClientForm : Form
    {
        public ManageClientForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Set the Size of the Back Arrow to the Size of the Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageClientForm_Load(object sender, EventArgs e)
        {
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Opens Selection Menu Form Form and Closes the Show Time Manager Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            ManagerSelectMenuForm frm = new ManagerSelectMenuForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

 
    }
}
