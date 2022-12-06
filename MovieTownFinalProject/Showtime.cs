using System;

namespace MovieTownFinalProject
{
    internal class Showtime
    {
        public Showtime(int showtimeId, Movie movie, Room room, DateTime dateTime)
        {
            ShowtimeId = showtimeId;
            ShowtimeMovie = movie;
            ShowtimeRoom = room;
            ShowtimeDate = dateTime;
        }

        public int ShowtimeId { get; set; }

        public Movie ShowtimeMovie { get; set; }

        public Room ShowtimeRoom { get; set; }

        public DateTime ShowtimeDate { get; set; }
    }
}
