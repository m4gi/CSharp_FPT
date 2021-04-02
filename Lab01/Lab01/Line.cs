using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01
{
    class Line : Shape
    {
        public Point x { get; private set; }
        public Point y { get; private set; }
        public Line() { }
        public Line(Point x, Point y)
        {
            this.x = x;
            this.y = y;
        }
        public override void Show()
        {
            Console.WriteLine("First point: " + x);
            Console.WriteLine("Second point: " + y);
        }
    }
}
