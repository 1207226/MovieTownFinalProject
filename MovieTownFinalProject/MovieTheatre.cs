// <copyright file="MovieTheatre.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.SqlClient;

    /// <summary>
    /// A movie theatre.
    /// </summary>
    internal class MovieTheatre
    {
        private readonly SqlConnection conn = new SqlConnection
        {
            ConnectionString =
                  "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                  "Initial Catalog=C:\\MOVIETOWNDB\\MOVIETOWNDB.MDF;",
        };

        private BindingList<Movie> _movies = new BindingList<Movie>();
        private BindingList<Room> _rooms = new BindingList<Room>();
        private BindingList<User> _users = new BindingList<User>();
        private BindingList<Showtime> _showtimes = new BindingList<Showtime>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieTheatre"/> class.
        /// </summary>
        public MovieTheatre()
        {
            this._rooms = this.Rooms;
            this._users = this.Users;
            this._movies = this.Movies;
        }

        /// <summary>
        /// Gets list of rooms.
        /// </summary>
        public BindingList<Room> Rooms
        {
            get
            {
                if (this._rooms.Count == 0)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Room", this.conn);

                    this.conn.Close();
                    this.conn.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int roomId = int.Parse(reader["RoomId"].ToString());

                        string roomName = reader["RoomName"].ToString();

                        int numberOfSeats = int.Parse(reader["NumberOfSeats"].ToString());

                        Room newRoom = new Room(roomId, roomName, numberOfSeats);

                        this._rooms.Add(newRoom);
                    }

                    reader.Close();

                    return this._rooms;
                }
                else
                {
                    return this._rooms;
                }
            }
        }

        /// <summary>
        /// Gets list of users.
        /// </summary>
        public BindingList<User> Users
        {
            get
            {
                if (this._users.Count == 0)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Client", this.conn);

                    this.conn.Close();
                    this.conn.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int clientId = int.Parse(reader["ClientId"].ToString());

                        string username = reader["Username"].ToString();

                        string firstName = reader["FirstName"].ToString();

                        string lastName = reader["LastName"].ToString();

                        string email = reader["Email"].ToString();

                        string password = reader["Password"].ToString();

                        Client newClient = new Client(clientId, username, firstName, lastName, email, password);

                        this._users.Add(newClient);
                    }

                    reader.Close();

                    command = new SqlCommand("SELECT * FROM Employee", this.conn);

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int employeeId = int.Parse(reader["EmployeeId"].ToString());

                        int employeeNumber = int.Parse(reader["EmployeeNumber"].ToString());

                        string firstName = reader["FirstName"].ToString();

                        string lastName = reader["LastName"].ToString();

                        string email = reader["Email"].ToString();

                        string password = reader["Password"].ToString();

                        Employee newClient = new Employee(employeeId, employeeNumber, firstName, lastName, email, password);

                        this._users.Add(newClient);
                    }

                    reader.Close();

                    this.conn.Close();
                    return this._users;
                }
                else
                {
                    return this._users;
                }
            }
        }

        /// <summary>
        /// Gets list of movies.
        /// </summary>
        public BindingList<Movie> Movies
        {
            get
            {
                if (this._movies.Count == 0)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Movie", this.conn);

                    this.conn.Close();
                    this.conn.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int movieId = int.Parse(reader["MovieId"].ToString());

                        string movieName = reader["MovieName"].ToString();

                        string movieGenre = reader["movieGenre"].ToString();

                        Movie newMovie = new Movie(movieId, movieName, movieGenre);

                        this._movies.Add(newMovie);
                    }

                    reader.Close();

                    this.conn.Close();

                    return this._movies;
                }
                else
                {
                    return this._movies;
                }
            }
        }

        /// <summary>
        /// Gets list of showtimes.
        /// </summary>
        public BindingList<Showtime> Showtimes
        {
            get
            {
                if (this._showtimes.Count == 0)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Showtime", this.conn);

                    this.conn.Close();
                    this.conn.Open();

                    SqlDataReader showtimeReader = command.ExecuteReader();

                    while (showtimeReader.Read())
                    {
                        int showtimeId = int.Parse(showtimeReader["ShowtimeId"].ToString());

                        int movieId = int.Parse(showtimeReader["MovieId"].ToString());

                        int roomId = int.Parse(showtimeReader["RoomId"].ToString());

                        DateTime showtimeDate = DateTime.Parse(showtimeReader["Showtime"].ToString());

                        foreach (Movie tempMovie in this.Movies)
                        {
                            if (tempMovie.MovieId == movieId)
                            {
                                Movie movie = tempMovie;
                                foreach (Room tempRoom in this.Rooms)
                                {
                                    if (tempRoom.RoomId == roomId)
                                    {
                                        Room room = tempRoom;

                                        Showtime newShowtime = new Showtime(showtimeId, movie, room, showtimeDate);

                                        this._showtimes.Add(newShowtime);
                                    }
                                }
                            }
                        }
                    }

                    return this._showtimes;
                }
                else
                {
                    return this._showtimes;
                }
            }
        }
    }
}
