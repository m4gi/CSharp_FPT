using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01
{
    class Point
    {
        protected double x { get; set; }
        protected double y { get; set; }

        public Point() { }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}
