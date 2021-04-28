using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    class Customer
    {
        public string FirstName;
        public string LastName;

        public Customer(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public string GetFullName()
        {
            return FirstName+" "+LastName;
        }
    }
}
