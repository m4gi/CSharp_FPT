using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public abstract class Shape
    {

        private int x { get; set; }
        private int y { get; set; }

        Point point { get; set; }
        protected Shape()
        {
        }
        protected void move()
        {
            Console.WriteLine("Move point to {0}", point);
        }
        public abstract void show();

        public override string ToString() => base.ToString();
    }



}
