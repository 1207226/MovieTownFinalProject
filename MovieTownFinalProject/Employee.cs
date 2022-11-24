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
        public Employee()
        {
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
