using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01
{
    class Rectangles : Shape
    {
        private Point x { get; set; }
        private Point y { get; set; }
        public Rectangles() { }
        public Rectangles(Point x, Point y)
        {
            this.x = x;
            this.y = y;
        }


        public override void Show()
        {
            Console.WriteLine("Information of Rectangles");
            Console.WriteLine("First line: " + x);
            Console.WriteLine("Second line: " + y);
            Console.WriteLine();

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
