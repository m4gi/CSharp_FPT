using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Circle : Shape
    {
        private int radius;
        public Circle()
        {
        }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
            set
            {
                Area = value;
            }

        }
        public Circle(int radius, int x, int y) : base(x, y)
        {
            this.radius = radius;
        }

        public override void show()
        {
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Arae of Circle = " + Area;
        }
    }
}
