// <copyright file="MovieManagerForm.cs" company="PlaceholderCompany">
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
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    /// <summary>
    /// Movie Manager Form.
    /// </summary>
    public partial class MovieManagerForm : Form
    {
        private int saveEdit = 1;

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
            // TODO: This line of code loads data into the 'movieTownDbDataSet.Movie' table. You can move, or remove it, as needed.
            this.backButton.BackgroundImageLayout = ImageLayout.Stretch;

            BindingList<string> allMovies = this.GetMovies();

            this.MovieListBox.DataSource = allMovies;
        }

        /// <summary>
        /// Opens the Show Room Manager Form and Closes the Selection Menu Form.
        /// </summary>
        /// <param name="sender">Back Button clicked.</param>
        /// <param name="e">Execption.</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            ManagerSelectMenuForm selectMenu = new ManagerSelectMenuForm();
            this.Hide();
            selectMenu.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Creates a binding list, and add the data base movie to it.
        /// </summary>
        /// <returns>All the Movies from the data base.</returns>
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
        /// Changes the information displayed in the movie text boxes to reflect the list box selection.
        /// </summary>
        /// <param name="sender">An Index of the List Box is selected.</param>
        /// <param name="e">Execption.</param>
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MovieTheatre theatre = new MovieTheatre();

            foreach (Movie movie in theatre.Movies)
            {
                if (movie.MovieName == this.MovieListBox.SelectedItem.ToString())
                {
                    this.movieIdTextBox.Text = movie.MovieId.ToString();
                    this.movieNameTextBox.Text = movie.MovieName;
                    this.movieGenreComboBox.Text = movie.MovieGenre.GenreName;

                    this.movieNameTextBox.Enabled = false;
                    this.movieGenreComboBox.Enabled = false;
                    this.movieSaveButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Clears the movie text boxes to allow for user input.
        /// </summary>
        /// <param name="sender">The Add Button is Clicked.</param>
        /// <param name="e">Execption.</param>
        private void MovieAddButton_Click(object sender, EventArgs e)
        {
            MovieTheatre theatre = new MovieTheatre();

            this.movieIdTextBox.Text = string.Empty;
            this.movieNameTextBox.Text = string.Empty;

            foreach (Genre genre in theatre.Genres)
            {
                this.movieGenreComboBox.Items.Add(genre.GenreName);
            }

            this.movieNameTextBox.Enabled = true;
            this.movieGenreComboBox.Enabled = true;
            this.movieSaveButton.Enabled = true;

            this.saveEdit = 1;
        }

        /// <summary>
        /// Saves the Movie entry, or edited information to the database.
        /// </summary>
        /// <param name="sender">Save Button is Clicked.</param>
        /// <param name="e">Exception.</param>
        private void MovieSaveButton_Click(object sender, EventArgs e)
        {
            this.movieSaveButton.Enabled = false;

            if (this.saveEdit == 1)
            {
                this.AddMovie();
            }
            else
            {
                this.EditMovie();
            }
        }

        /// <summary>
        /// Delete the selected movie entry.
        /// </summary>
        /// <param name="sender"> The Delete Button was Clicked.</param>
        /// <param name="e">Execption.</param>
        /// <remarks>Opens a message box the validate the user input.</remarks>
        private void MovieDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete " + this.movieNameTextBox.Text, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MovieTheatre theatre = new MovieTheatre();

                SqlConnection conn = new SqlConnection
                {
                    ConnectionString =
                      "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                      "Initial Catalog=C:\\MOVIETOWNDB\\MOVIETOWNDB.MDF;",
                };

                SqlCommand command = new SqlCommand($"DELETE FROM Movie WHERE MovieId = @movieId", conn);
                command.Parameters.AddWithValue("@movieId", this.movieIdTextBox.Text);

                conn.Open();

                command.ExecuteReader();

                MessageBox.Show("Movie Deleted!");

                BindingList<string> allMovies = this.GetMovies();

                this.MovieListBox.DataSource = allMovies;

                conn.Close();
            }
        }

        /// <summary>
        /// Enables the save button, the text box, and combo box to edit the a movie entry.
        /// </summary>
        /// <param name="sender">Edit Button Clicked.</param>
        /// <param name="e">Exception.</param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            this.movieNameTextBox.Enabled = true;
            this.movieGenreComboBox.Enabled = true;
            this.movieSaveButton.Enabled = true;

            this.saveEdit = 2;
        }

        /// <summary>
        /// Function that adds a new entry to the movie data base, and resets the movie binding list.
        /// </summary>
        private void AddMovie()
        {
            MovieTheatre theatre = new MovieTheatre();

            SqlConnection conn = new SqlConnection
            {
                ConnectionString =
                  "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                  "Initial Catalog=C:\\MOVIETOWNDB\\MOVIETOWNDB.MDF;",
            };

            if (this.movieNameTextBox.Text != string.Empty)
            {
                foreach (Genre genre in theatre.Genres)
                {
                    if (genre.GenreName == this.movieGenreComboBox.Text)
                    {
                        SqlCommand command = new SqlCommand($"INSERT INTO Movie (MovieName, MovieGenre) VALUES (@movieName, @movieGenre)", conn);
                        command.Parameters.AddWithValue("@movieName", this.movieNameTextBox.Text);
                        command.Parameters.AddWithValue("@movieGenre", genre.GenreId);

                        conn.Open();

                        command.ExecuteReader();

                        MessageBox.Show("Movie Added!");

                        BindingList<string> allMovies = this.GetMovies();

                        this.MovieListBox.DataSource = allMovies;

                        conn.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Function that edits the entry of a selected movie to the data base, and reset the movie binding list.
        /// </summary>
        private void EditMovie()
        {
            MovieTheatre theatre = new MovieTheatre();

            if (MessageBox.Show("Are you sure you want to edit " + this.movieNameTextBox.Text, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string movieName = this.movieNameTextBox.Text;
                foreach (Genre genre in theatre.Genres)
                {
                    if (genre.GenreName == this.movieGenreComboBox.Text)
                    {
                        SqlConnection conn = new SqlConnection
                        {
                            ConnectionString =
                      "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                      "Initial Catalog=C:\\MOVIETOWNDB\\MOVIETOWNDB.MDF;",
                        };

                        SqlCommand command = new SqlCommand($"UPDATE Movie SET MovieName = @movieName, MovieGenre = @movieGenre WHERE MovieId = @movieId", conn);
                        command.Parameters.AddWithValue("@movieId", this.movieIdTextBox.Text);
                        command.Parameters.AddWithValue("@movieName", movieName);
                        command.Parameters.AddWithValue("@movieGenre", genre.GenreId);

                        conn.Open();

                        command.ExecuteReader();

                        MessageBox.Show("Movie Edited!");

                        BindingList<string> allMovies = this.GetMovies();

                        this.MovieListBox.DataSource = allMovies;

                        conn.Close();
                    }
                }
            }
        }
    }
}
