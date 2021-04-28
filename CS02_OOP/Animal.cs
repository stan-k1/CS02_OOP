using System;
using System.Collections.Generic;
using System.Text;

namespace CS02_OOP
{
    class Animal
    {
        public string name { get; set; }
        public char gender { get; set; }
        public DateTime insertionDate = DateTime.MinValue;
        public string greeting = $"Hello from Cat!)";

        public void Eat()
        {
            //Do Something...
        }
    }

}
