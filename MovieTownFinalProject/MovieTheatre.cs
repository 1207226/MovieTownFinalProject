// <copyright file="MovieTheatre.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
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

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieTheatre"/> class.
        /// </summary>
        public MovieTheatre()
        {
        }

        /// <summary>
        /// Gets list of rooms.
        /// </summary>
        public BindingList<Room> Rooms
        {
            get
            {
                BindingList<Room> tempList = new BindingList<Room>();

                SqlCommand command = new SqlCommand("SELECT * FROM Room", this.conn);

                this.conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int roomId = int.Parse(reader["RoomId"].ToString());

                    string roomName = reader["RoomName"].ToString();

                    int numberOfSeats = int.Parse(reader["NumberOfSeats"].ToString());

                    Room newRoom = new Room(roomId, roomName, numberOfSeats);

                    tempList.Add(newRoom);
                }

                return tempList;
            }
        }

        /// <summary>
        /// Gets list of users.
        /// </summary>
        public BindingList<User> Users
        {
            get
            {
                BindingList<User> tempList = new BindingList<User>();

                SqlCommand command = new SqlCommand("SELECT * FROM Client", this.conn);

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

                    tempList.Add(newClient);
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

                    string password = reader["FirstName"].ToString();

                    Employee newClient = new Employee(employeeId, employeeNumber, firstName, lastName, email, password);

                    tempList.Add(newClient);
                }

                return tempList;
            }
        }

        /// <summary>
        /// Gets list of movies.
        /// </summary>
        public BindingList<Movie> Movies
        {
            get
            {
                BindingList<Movie> tempList = new BindingList<Movie>();

                SqlCommand command = new SqlCommand("SELECT * FROM Movie", this.conn);

                this.conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int movieId = int.Parse(reader["MovieId"].ToString());

                    string movieName = reader["MovieName"].ToString();

                    string movieGenre = reader["movieGenre"].ToString();

                    Movie newMovie = new Movie(movieId, movieName, movieGenre);

                    tempList.Add(newMovie);
                }

                return tempList;
            }
        }
    }
}
