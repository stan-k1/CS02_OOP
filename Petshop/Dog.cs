using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    class Dog
    {
        public string name;
        public string breed;
        public char gender;
        public DateTime insertionDate;

        public Dog(string name, char gender, string breed)
        {
            this.name = name;
            this.gender = gender;
            this.breed = breed;
            insertionDate = DateTime.Now;
        }

        public Dog(string name, char gender)
        {
            this.name = name;
            this.gender = gender;
            breed = "Unknown";
            insertionDate = DateTime.Now;
        }

    }
}
