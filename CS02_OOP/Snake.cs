using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using CS02_OOP;

namespace Animals_Example
{
    class Snake : Animal
    {
        public static bool Poisonous { get; } = true;
        private float _length;
        
        public float Length{
            get => Length=(float)Math.Round(_length, 2);
            set
            {
                if (value < 100) _length = value;
                else Console.WriteLine("The length of a snake cannot exceed 100!");
            }
        }
    }
}
