// <copyright file="Genre.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A movie genre.
    /// </summary>
    internal class Genre
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Genre"/> class.
        /// </summary>
        /// <param name="genreId">The primary key of the genre.</param>
        /// <param name="genreName">The name of the genre.</param>
        public Genre(int genreId, string genreName)
        {
            this.GenreId = genreId;
            this.GenreName = genreName;
        }

        /// <summary>
        /// Gets and sets the Genre Id of Genre.
        /// </summary>
        public int GenreId { get; }

        /// <summary>
        /// Gets and sets the genre name of Genre.
        /// </summary>
        public string GenreName { get; }
    }
}
