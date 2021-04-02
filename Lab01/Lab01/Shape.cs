using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01
{
    abstract class Shape
    {
        public Shape() { }
        public void Move(Point y)
        {
            Console.WriteLine("This shape is moved to " + y);
        }
        public abstract void Show();


    }
}
