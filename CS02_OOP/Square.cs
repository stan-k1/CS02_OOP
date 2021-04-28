using System;
using System.Collections.Generic;
using System.Text;
using CS02_Examples;

namespace Animals_Example
{
    class Square : Rectangle, IShape
    {
        public int heightCM { get; set; }
        public int widthCM { get; set; }

        public float GetArea()
        {
            return heightCM * widthCM;
        }
    }
}
