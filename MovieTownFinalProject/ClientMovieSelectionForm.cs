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

        /// <summary>
        /// Increment the ticket value by 1.
        /// </summary>
        /// <param name="sender">Button is clicked.</param>
        /// <param name="e">Execption.</param>
        /// <remarks> A limit of 10 tickets is being implimented.</remarks>
        private void AddTicketButton_Click(object sender, EventArgs e)
        {
            int ticketNumber = int.Parse(this.ticketPurchaseLable.Text);

            if (ticketNumber < 10)
            {
                ticketNumber++;
                this.ticketPurchaseLable.Text = ticketNumber.ToString();
                this.reduceTicketButton.Enabled = true;
            }

            if (ticketNumber == 10)
            {
                this.addTicketButton.Enabled = false;
                ManagerLogInForm.ScreenShake(this);
                MessageBox.Show("Cannot select more then 10 tickets.");
            }
        }

        /// <summary>
        /// Decreases the ticket value by1.
        /// </summary>
        /// <param name="sender">Button is clicked.</param>
        /// <param name="e">Execption.</param>
        /// <remarks> A mininum of 1 ticket is being held.</remarks>
        private void ReduceTicketButton_Click(object sender, EventArgs e)
        {
            int ticketNumber = int.Parse(this.ticketPurchaseLable.Text);

            if (ticketNumber > 0)
            {
                ticketNumber--;
                this.ticketPurchaseLable.Text = ticketNumber.ToString();
                this.addTicketButton.Enabled = true;
            }

            if (ticketNumber == 0)
            {
                this.reduceTicketButton.Enabled = false;
                ManagerLogInForm.ScreenShake(this);
                MessageBox.Show("Cannot select less then 0 ticket.");
            }
        }
    }
}
