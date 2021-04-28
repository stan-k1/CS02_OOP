using System;
using System.Collections.Generic;
using System.Text;

namespace CS02_OOP
{
    class Cat : Animal
    {
        string breed { get; set; }
        string greeting = "Hello from Cat!";

        public Cat(string name, char gender, string breed)
        {
            this.name = name;
            this.gender = gender;
            this.breed = breed;
            insertionDate = DateTime.Now;
        }

        public Cat (string name, char gender)
        {
            this.name = name;
            this.gender = gender;
            breed = "Unknown";
            insertionDate = DateTime.Now;
        }

        public void printGreetings()
        {
            Console.WriteLine(greeting); //"Hello from Cat!"
            Console.WriteLine(base.greeting); //"Hello from Animal"
        }
    }
}
