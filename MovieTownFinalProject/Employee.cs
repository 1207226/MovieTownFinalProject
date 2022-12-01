// <copyright file="Employee.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieTownFinalProject
{
    /// <summary>
    /// An employee.
    /// </summary>
    internal class Employee : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="employeeId">System's name for the employee.</param>
        /// <param name="employeeNumber">Employee's number.</param>
        /// <param name="firstName">Employee's first name.</param>
        /// <param name="lastName">Employee's last name.</param>
        /// <param name="email">Employee's email.</param>
        /// <param name="password">Employee's password.</param>
        public Employee(int employeeId, int employeeNumber, string firstName, string lastName, string email, string password)
        {
            this.EmployeeId = employeeId;
            this.EmployeeNumber = employeeNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
        }

        /// <summary>
        /// Gets the system's name for the employee.
        /// </summary>
        public int EmployeeId { get; }

        /// <summary>
        /// Gets or sets the employee's number.
        /// </summary>
        public int EmployeeNumber { get; set; }
    }
}
