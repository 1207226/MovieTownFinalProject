using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTownFinalProject
{
    /// <summary>
    /// A Room.
    /// </summary>
    internal class Room
    {
        /// <summary>
        /// System's name for the room.
        /// </summary>
        public int RoomId { get; }
        /// <summary>
        /// Visible name for the room.
        /// </summary>
        public string RoomName { get; set; }
        /// <summary>
        /// Number of seats in the room.
        /// </summary>
        public int NumberOfSeats { get; set; }

        /// <summary>
        /// A Room.
        /// </summary>
        public Room(string roomName, int numberOfSeats)
        {
            RoomName = roomName;
            NumberOfSeats = numberOfSeats;
        }
    }
}
