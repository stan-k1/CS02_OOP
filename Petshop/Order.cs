using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    class Order
    {
        public Customer customer;
        public Dog dog;

        public Order(Customer customer, Dog dog)
        {
            this.customer = customer;
            this.dog = dog;
        }
    }
}
