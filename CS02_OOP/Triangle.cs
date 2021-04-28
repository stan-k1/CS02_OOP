using System;
using System.Collections.Generic;
using System.Text;
using Animals_Example;

namespace CS02_Examples
{
    class Triangle : IShape
    {
        public int baseCM { get; set; }
        public int heightCM { get; set; }

        public float GetArea()
        {
            return 0.5f * baseCM * heightCM;
        }

        public Triangle(int baseCM, int heightCM)
        {
            this.baseCM = baseCM;
            this.heightCM = heightCM;
        }
    }
}
