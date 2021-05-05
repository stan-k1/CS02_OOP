using System;
using System.Collections.Generic;
using System.Text;

namespace CS02_Examples
{
    public record Customer
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    // public record Customer (string FirstName, string LastName);
}
