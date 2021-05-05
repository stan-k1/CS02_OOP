using System;
using Animals_Example;
using CS02_Examples;

namespace CS02_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cat Cadife = new Cat("Cadife", 'F', "Calico");
            Cadife.printGreetings();
            Petshop.AddCat(Cadife);

            Console.WriteLine("Let there be snakes!");
            Mamba mamba = new Mamba();
            CornSnake cornSnake = new CornSnake();
            Console.WriteLine(Snake.Poisonous); //True
            Console.WriteLine(Mamba.Poisonous); //True
            Console.WriteLine(CornSnake.Poisonous); //False
            Console.WriteLine(mamba.greeting); //"Hello from Animal!"
            Console.WriteLine(cornSnake.greeting); //"Hello from Animal!"

            mamba.Length = 150; //The length of a snake cannot exceed 100!
            mamba.Length = 30.2768f; 
            Console.WriteLine(mamba.Length); //30.28

            IShape triangle = new Triangle(1,2);
            Console.WriteLine(ShapeOperations.DoubleAndRoundArea(triangle)); //2

            Customer annaCustomer = new ("Anna", "Karenina");
            Customer annaCustomerCopy = new ("Anna", "Karenina");
            Console.WriteLine(annaCustomer==annaCustomerCopy); //True
            Console.WriteLine(annaCustomer); //Customer { FirstName = Anna, LastName = Karenina }

            Customer annaChanged = annaCustomer with {FirstName = "Anneta"};
            Console.WriteLine(annaCustomer == annaChanged); //False

            BusinessCustomer annaBusinessCustomer = new("Anna", "Karenina", "Perfumes Corp");
            Console.WriteLine(annaCustomer == annaBusinessCustomer); //False because annaCustomer does not include the BusinessName field
        }
    }
}
