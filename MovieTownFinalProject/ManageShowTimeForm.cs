// <copyright file="ManageShowTimeForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
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
        private int saveEdit = 1;

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
            this.backButton.BackgroundImageLayout = ImageLayout.Stretch;

            BindingList<string> allShowtimes = this.GetShowtimes();

            this.ShowTimeListBox.DataSource = allShowtimes;
        }

        /// <summary>
        /// Get ShowTime from data base to bindinglist.
        /// </summary>
        /// <returns>Show time in bindinglist.</returns>
        private BindingList<string> GetShowtimes()
        {
            MovieTheatre theatre = new MovieTheatre();

            BindingList<string> allShowtimes = new BindingList<string>();

            foreach (Showtime showtime in theatre.Showtimes)
            {
                allShowtimes.Add(showtime.ShowtimeId + " Movie: " + showtime.ShowtimeMovie.MovieName + " Room: " + showtime.ShowtimeRoom.RoomName + " Date: " + showtime.ShowtimeDate.ToShortDateString() + " " + showtime.ShowtimeDate.ToShortTimeString());
            }

            return allShowtimes;
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

        /// <summary>
        /// Add new show time to database.
        /// </summary>
        /// <param name="sender">Add button is clicked.</param>
        /// <param name="e">Execption.</param>
        private void AddShowTimeButton_Click(object sender, EventArgs e)
        {
            MovieTheatre theatre = new MovieTheatre();

            this.showtimeIdTextBox.Text = string.Empty;
            this.movieComboBox.Text = string.Empty;
            this.roomComboBox.Text = string.Empty;

            foreach (Movie movie in theatre.Movies)
            {
                this.movieComboBox.Items.Add(movie.MovieName);
            }

            foreach (Room room in theatre.Rooms)
            {
                this.roomComboBox.Items.Add(room.RoomName);
            }

            this.showtimeDateDateTimePicker.Value = DateTime.Today;
            this.showtimeTimeDateTimePicker.Value = DateTime.Today;

            this.movieComboBox.Enabled = true;
            this.roomComboBox.Enabled = true;
            this.showtimeDateDateTimePicker.Enabled = true;
            this.showtimeTimeDateTimePicker.Enabled = true;
            this.saveShowTimeButton.Enabled = true;

            this.saveEdit = 1;
        }

        /// <summary>
        /// Save new and edited show times to database. 
        /// </summary>
        /// <param name="sender">Save Button Clicked.</param>
        /// <param name="e">Execption.</param>
        private void SaveShowTimeButton_Click(object sender, EventArgs e)
        {
            this.saveShowTimeButton.Enabled = false;

            if (this.saveEdit == 1)
            {
                this.AddShowtime();
            }
            else
            {
                this.EditShowtime();
            }
        }

        /// <summary>
        /// Function to add the show time.
        /// </summary>
        private void AddShowtime()
        {
            MovieTheatre theatre = new MovieTheatre();

            SqlConnection conn = new SqlConnection
            {
                ConnectionString =
                  "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                  "Initial Catalog=C:\\MOVIETOWNDB\\MOVIETOWNDB.MDF;",
            };

            foreach (Movie movie in theatre.Movies)
            {
                if (movie.MovieName == this.movieComboBox.Text)
                {
                    foreach (Room room in theatre.Rooms)
                    {
                        if (room.RoomName == this.roomComboBox.Text)
                        {
                            SqlCommand command = new SqlCommand($"INSERT INTO Showtime (MovieId, RoomId, Showtime) VALUES (@movieId, @roomId, @showtime)", conn);
                            command.Parameters.AddWithValue("@movieId", movie.MovieId);
                            command.Parameters.AddWithValue("@roomId", room.RoomId);
                            command.Parameters.AddWithValue("@showtime", this.showtimeDateDateTimePicker.Value.Date + this.showtimeDateDateTimePicker.Value.TimeOfDay);

                            conn.Open();

                            command.ExecuteReader();

                            MessageBox.Show("Showtime Added!");

                            this.ShowTimeListBox.DataSource = this.GetShowtimes();

                            conn.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Create list of movies.
        /// </summary>
        /// <returns>List of movies.</returns>
        private BindingList<string> GetMovies()
        {
            MovieTheatre theatre = new MovieTheatre();

            BindingList<string> allMovies = new BindingList<string>();

            foreach (Movie movie in theatre.Movies)
            {
                allMovies.Add(movie.MovieName);
            }

            return allMovies;
        }

        /// <summary>
        /// Function to edit the show time.
        /// </summary>
        private void EditShowtime()
        {
            MovieTheatre theatre = new MovieTheatre();

            if (MessageBox.Show("Are you sure you want to edit this showtime", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Movie movie in theatre.Movies)
                {
                    if (movie.MovieName == this.movieComboBox.Text)
                    {
                        int movieId = movie.MovieId;

                        foreach (Room room in theatre.Rooms)
                        {
                            if (room.RoomName == this.roomComboBox.Text)
                            {
                                int roomId = room.RoomId;

                                SqlConnection conn = new SqlConnection
                                {
                                    ConnectionString =
                                        "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                        "Initial Catalog=C:\\MOVIETOWNDB\\MOVIETOWNDB.MDF;",
                                };

                                SqlCommand command = new SqlCommand($"UPDATE Showtime SET MovieId = @movieId, RoomId = @roomId, Showtime = @showtime WHERE ShowtimeId = @showtimeId", conn);
                                command.Parameters.AddWithValue("@showtimeId", this.showtimeIdTextBox.Text);
                                command.Parameters.AddWithValue("@movieId", movieId);
                                command.Parameters.AddWithValue("@roomId", roomId);
                                command.Parameters.AddWithValue("@showtime", this.showtimeDateDateTimePicker.Value.Date + this.showtimeDateDateTimePicker.Value.TimeOfDay);

                                conn.Open();

                                command.ExecuteReader();

                                MessageBox.Show("Showtime Edited!");

                                this.ShowTimeListBox.DataSource = this.GetShowtimes();

                                conn.Close();
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Update the information under the list box to display selected value. 
        /// </summary>
        /// <param name="sender">A list box index is selected.</param>
        /// <param name="e">Execption.</param>
        private void ShowTimeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MovieTheatre theatre = new MovieTheatre();

            int showtimeId = int.Parse(this.ShowTimeListBox.SelectedItem.ToString().Substring(0, this.ShowTimeListBox.SelectedItem.ToString().IndexOf(" ")));

            foreach (Showtime showtime in theatre.Showtimes)
            {
                if (showtime.ShowtimeId == showtimeId)
                {
                    this.showtimeIdTextBox.Text = showtimeId.ToString();
                    this.movieComboBox.Text = showtime.ShowtimeMovie.MovieName;
                    this.roomComboBox.Text = showtime.ShowtimeRoom.RoomName;
                    this.showtimeDateDateTimePicker.Value = showtime.ShowtimeDate.Date;
                    this.showtimeTimeDateTimePicker.Value = showtime.ShowtimeDate;

                    this.showtimeIdTextBox.Enabled = false;
                    this.movieComboBox.Enabled = false;
                    this.roomComboBox.Enabled = false;
                    this.showtimeDateDateTimePicker.Enabled = false;
                    this.showtimeTimeDateTimePicker.Enabled = false;
                    this.saveShowTimeButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Deleted a selected show time.
        /// </summary>
        /// <param name="sender">Deleted Button is Clicked.</param>
        /// <param name="e">Execption.</param>
        private void deleteShowTimeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this showtime", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MovieTheatre theatre = new MovieTheatre();

                SqlConnection conn = new SqlConnection
                {
                    ConnectionString =
                      "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                      "Initial Catalog=C:\\MOVIETOWNDB\\MOVIETOWNDB.MDF;",
                };

                SqlCommand command = new SqlCommand($"DELETE FROM Showtime WHERE ShowtimeId = @showtimeId", conn);
                command.Parameters.AddWithValue("@showtimeId", this.showtimeIdTextBox.Text);

                conn.Open();

                command.ExecuteReader();

                MessageBox.Show("Showtime Deleted!");

                BindingList<string> allShowtimes = this.GetShowtimes();

                this.ShowTimeListBox.DataSource = allShowtimes;

                conn.Close();
            }
        }

        /// <summary>
        /// Allows the editing of a showtime.
        /// </summary>
        /// <param name="sender">Edit button is clicked.</param>
        /// <param name="e">Execption.</param>
        private void editShowTimeButton_Click(object sender, EventArgs e)
        {
            MovieTheatre theatre = new MovieTheatre();

            this.movieComboBox.Enabled = true;
            this.roomComboBox.Enabled = true;
            this.saveShowTimeButton.Enabled = true;
            this.showtimeDateDateTimePicker.Enabled = true;
            this.showtimeTimeDateTimePicker.Enabled = true;

            foreach (Movie movie in theatre.Movies)
            {
                this.movieComboBox.Items.Add(movie.MovieName);
            }

            foreach (Room room in theatre.Rooms)
            {
                this.roomComboBox.Items.Add(room.RoomName);
            }

            this.saveEdit = 2;
        }
    }
}
