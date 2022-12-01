// <copyright file="Movie.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    /// <summary>
    /// A movie.
    /// </summary>
    internal class Movie
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class.
        /// </summary>
        /// <param name="movieId">System's name for the movie.</param>
        /// <param name="movieName">Visible name for the movie.</param>
        /// <param name="movieGenre">Movie's genre.</param>
        public Movie(int movieId, string movieName, string movieGenre)
        {
            this.MovieId = movieId;
            this.MovieName = movieName;
            this.MovieGenre = movieGenre;
        }

        /// <summary>
        /// Gets the system's name for the movie.
        /// </summary>
        public int MovieId { get; }

        /// <summary>
        /// Gets or sets the visible name for the movie.
        /// </summary>
        public string MovieName { get; set; }

        /// <summary>
        /// Gets or sets the movie's genre.
        /// </summary>
        public string MovieGenre { get; set; }
    }
}
