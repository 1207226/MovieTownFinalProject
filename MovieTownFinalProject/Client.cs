// <copyright file="Client.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    /// <summary>
    /// A client.
    /// </summary>
    internal class Client : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="clientId">System's name for the client.</param>
        /// <param name="username">Clien't username.</param>
        /// <param name="firstName">Client's first name.</param>
        /// <param name="lastName">Client's last name.</param>
        /// <param name="email">Client's email.</param>
        /// <param name="password">Client's password.</param>
        public Client(int clientId, string username, string firstName, string lastName, string email, string password)
        {
            this.ClientId = clientId;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
        }

        /// <summary>
        /// Gets the system's name for the client.
        /// </summary>
        public int ClientId { get; }

        /// <summary>
        /// Gets or sets the client's username.
        /// </summary>
        public string Username { get; set; }
    }
}
