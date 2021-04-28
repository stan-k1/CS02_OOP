using System;
using System.Collections.Generic;
using System.Text;
using CS02_OOP;

namespace Animals_Example
{
    public static class Petshop
    {
        public static string name = "PetWorld";
        public static List<Cat> AllCats = new List<Cat>();

        public static void AddCat(Cat cat)
        {
            AllCats.Add(cat);
        }

    }
}
