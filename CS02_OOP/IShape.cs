using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_Example
{
    public interface IShape
    {
        public float GetArea();

        public void Greet()
        {
            Console.WriteLine("Hello World from a shape!");
        }
    }
}
