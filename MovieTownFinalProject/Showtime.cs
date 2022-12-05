using System;

namespace MovieTownFinalProject
{
    internal class Showtime
    {
        public Showtime(Movie movie, Room room, DateTime dateTime)
        {
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
