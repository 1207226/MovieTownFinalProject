// <copyright file="Showtime.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    using System;

    /// <summary>
    /// A show time.
    /// </summary>
    internal class Showtime
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Showtime"/> class.
        /// </summary>
        /// <param name="showtimeId">The primary key of the ShowTime object.</param>
        /// <param name="movie">The name of the movie attached to the showtime.</param>
        /// <param name="room">The room name of the room attached to the showtime.</param>
        /// <param name="dateTime">The date and time attached to the showtime.</param>
        public Showtime(int showtimeId, Movie movie, Room room, DateTime dateTime)
        {
            this.ShowtimeId = showtimeId;
            this.ShowtimeMovie = movie;
            this.ShowtimeRoom = room;
            this.ShowtimeDate = dateTime;
        }

        /// <summary>
        /// Gets the system's name for the Showtime.
        /// </summary>
        public int ShowtimeId { get; }

        /// <summary>
        /// Gets or sets  the Movie name for the Showtime.
        /// </summary>
        public Movie ShowtimeMovie { get; set; }

        /// <summary>
        /// Gets or sets the Room name for the Showtime.
        /// </summary>
        public Room ShowtimeRoom { get; set; }

        /// <summary>
        /// Gets or sets get the Date and Time for the Showtime.
        /// </summary>
        public DateTime ShowtimeDate { get; set; }
    }
}
