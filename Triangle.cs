using System;

namespace Shapes
{
    class Triangle
    {
        private double height;
        private double baseLength;

        public Triangle()
        {
            this.height = 1;
            this.baseLength = 1;
        }

        public double GetArea()
        {
            return height * baseLength * 0.5;
        }
    }
}