using System;

namespace MovieTownFinalProject
{
    internal class Showtime
    {
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

        public Movie ShowtimeMovie { get; set; }

        public Room ShowtimeRoom { get; set; }

        public DateTime ShowtimeDate { get; set; }
    }
}
