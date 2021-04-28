using System;

namespace Petshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat Cadife = new Cat("Cadife", 'F', "Calico");
            var Annie = new Cat("Annie", 'F');
            var Snoopy = new Dog("Snoopy", 'M');
            Customer Anna = new Customer("Anna", "Karenina");
            Console.WriteLine(Anna.GetFullName());
            Order snoopyAnna = new Order(Anna, Snoopy);

        }
    }
}
