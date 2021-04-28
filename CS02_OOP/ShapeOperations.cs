using System;
using System.Collections.Generic;
using System.Text;
using Animals_Example;

namespace CS02_Examples
{
    public static class ShapeOperations
    {
        public static float DoubleAndRoundArea(IShape shape)
        {
            return (float)Math.Round(shape.GetArea()) * 2;
        }
    }
}
