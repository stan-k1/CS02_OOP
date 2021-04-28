using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CS02_OOP
{
    public abstract class Animal
    {
        public string name { get; set; }
        public char gender { get; set; }
        private protected DateTime insertionDate = DateTime.MinValue;
        public string greeting { get; } = "Hello from Animal!";

        public void Eat()
        {
            //Do Something...
        }

        //public abstract void Move(int distance);
    }

}
