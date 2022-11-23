// <copyright file="Room.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    /// <summary>
    /// A room.
    /// </summary>
    internal class Room
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Room"/> class.
        /// A room.
        /// </summary>
        /// <param name="roomName">Visible name for the room.</param>
        /// <param name="numberOfSeats">Number of seats in the room.</param>
        public Room(string roomName, int numberOfSeats)
        {
            this.RoomName = roomName;
            this.NumberOfSeats = numberOfSeats;
        }

        /// <summary>
        /// Gets system's name for the room.
        /// </summary>
        public int RoomId { get; }

        /// <summary>
        /// Gets or sets visible name for the room.
        /// </summary>
        public string RoomName { get; set; }

        /// <summary>
        /// Gets or sets number of seats in the room.
        /// </summary>
        public int NumberOfSeats { get; set; }
    }
}
