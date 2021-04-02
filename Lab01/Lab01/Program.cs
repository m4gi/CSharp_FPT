using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Point x = new Point(10, 8);
            Point y = new Point(3, 5);
            Rectangles re = new Rectangles(x, y);
            re.Show();
            Circle cl = new Circle(4.7, y);
            Line l = new Line(x, y);
            Point z = new Point(6, 7);
            cl.Show();
            cl.Move(z);
            Console.WriteLine();
            l.Show();
            l.Move(z);
            Console.WriteLine();
            re.Show();
            re.Move(z);
        }
    }
}
