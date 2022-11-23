// <copyright file="MovieTheatre.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    using System.Collections.Generic;

    /// <summary>
    /// A movie theatre.
    /// </summary>
    internal class MovieTheatre
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovieTheatre"/> class.
        /// </summary>
        public MovieTheatre()
        {
        }

        /// <summary>
        /// Gets or sets list of rooms.
        /// </summary>
        public List<Room> Rooms { get; set; }

        /// <summary>
        /// Gets or sets list of users.
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// Gets or sets list of movies.
        /// </summary>
        public List<Movie> Movies { get; set; }
    }
}
