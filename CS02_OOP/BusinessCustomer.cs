using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS02_Examples
{
    public record BusinessCustomer (string FirstName, string LastName, string BusinessName) : Customer(FirstName, LastName);
}
