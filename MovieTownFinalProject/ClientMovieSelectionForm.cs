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

            this.showtimeListBox.DataSource = this.GetShowtimes(DateTime.Now);
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

        private void MovieDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            BindingList<string> currentMovies = this.GetShowtimes(this.movieDateTimePicker.Value.Date);

            this.showtimeListBox.DataSource = currentMovies;
        }

        private BindingList<string> GetShowtimes(DateTime selectedDate)
        {
            MovieTheatre theatre = new MovieTheatre();

            BindingList<string> currentMovies = new BindingList<string>();

            foreach (Showtime showtime in theatre.Showtimes)
            {
                if (showtime.ShowtimeDate >= selectedDate && showtime.ShowtimeDate.Date == selectedDate.Date)
                {
                    currentMovies.Add(showtime.ShowtimeMovie.MovieName + " " + showtime.ShowtimeDate.ToShortTimeString());
                }
            }

            return currentMovies;
        }

        private void AvailibilityButton_Click(object sender, EventArgs e)
        {
            if (this.showtimeListBox.SelectedItems.Count == 1)
            {
                MessageBox.Show("You purchased " + ticketPurchaseLable.Text + " tickets for " + this.showtimeListBox.SelectedValue.ToString());
            }
            else
            {
                ManagerLogInForm.ScreenShake(this);

                MessageBox.Show("Please select a movie.");
            }
        }
    }
}