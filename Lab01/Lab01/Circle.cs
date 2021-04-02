using System;

namespace Lab01
{
    class Circle : Shape
    {
        public double radius { get; set; }
        public Point center { get; set; }
        public Circle() { }
        public Circle(double radius, Point center)
        {
            this.radius = radius;
            this.center = center;
        }
        public override void Show()
        {
            Console.WriteLine("Center is: " + center);
            Console.WriteLine("Radius is: " + radius);
        }

        public override string ToString()
        {
            return "Radis of circle: " + radius;
        }
    }
}
