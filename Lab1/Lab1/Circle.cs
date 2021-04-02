using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
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
            Console.WriteLine("Center is: "+center);
            Console.WriteLine("Radius is: "+radius);
        }
    }
}
