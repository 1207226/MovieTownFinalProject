
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
