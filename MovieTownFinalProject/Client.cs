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
        public Client()
        {
        }

        /// <summary>
        /// Gets the system's name for the client.
        /// </summary>
        public int ClientId { get; }
    }
}
