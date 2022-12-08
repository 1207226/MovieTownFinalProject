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
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Execption.</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            ManagerSelectMenuForm selectMenu = new ManagerSelectMenuForm();
            this.Hide();
            selectMenu.ShowDialog();
            this.Close();
        }

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
        }

        private void movieSaveButton_Click(object sender, EventArgs e)
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
    }
}
