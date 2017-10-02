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

        public Triangle(double height, double baseLength)
        {
            this.height = height;
            this.baseLength = baseLength;
        }
        public double Height
        {
            // Access
            get
            {
                return height;
            }

            // Mutate
            set
            {
                if(value < 1 || value > double.MaxValue)
                {
                    throw new OverflowException();
                }
                height = value;
            }
        }

                public double Baselength
        {
            // Access
            get
            {
                return baseLength;
            }

            // Mutate
            set
            {
                if(value < 1 || value > double.MaxValue)
                {
                    throw new OverflowException();
                }
                baseLength = value;
            }
        }

        public double GetArea()
        {
            return height * baseLength * 0.5;
        }

        public double GetPerimeter()
        {
            return baseLength + (Math.Sqrt((baseLength*baseLength) + (4 * height) *height));
        }
    }
}