// <copyright file="MovieTheatre.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;

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
        public List<Room> Rooms
        {
            get
            {
                SqlConnection conn = new SqlConnection
                {
                    ConnectionString =
                  "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                  "Initial Catalog=MovieTownDb;",
                };
                SqlCommand command = new SqlCommand("SELECT * FROM Room", conn);

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int roomId = int.Parse(reader["RoomId"].ToString());

                    string roomName = reader["RoomName"].ToString();

                    int numberOfSeats = int.Parse(reader["NumberOfSeats"].ToString());

                    Room newRoom = new Room(roomId, roomName, numberOfSeats)
                }
            }
            set;
        }

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
