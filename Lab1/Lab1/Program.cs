using System;

namespace Lab1
{
    class Area
    {

        public enum Shape
        {
            Circle,
            Square
        }
        public void AreaShape(int x, Shape shape)
        {
            double area;
            switch (shape)
            {
                case Shape.Circle:
                    area = Math.PI * Math.Pow(x, 2);
                    Console.WriteLine("Circle area = {0:0.##}", area);
                    break;
                case Shape.Square:
                    area = Math.Pow(x, 2);
                    Console.WriteLine("Square area = {0}", area);
                    break;
                default:
                    Console.WriteLine("Invalid value!!!");
                    break;
            }
        }
    }
    class Program
    {
        public static void change(ref int x)
        {
            x += 10;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Area area = new Area();
            //area.AreaShape(5, Area.Shape.Circle);
            //area.AreaShape(10, Area.Shape.Square);
            int x = 5;
            int y = 10;
            Console.WriteLine("Before swap: {0}   {1}", x,y);
            //change(ref x);
            Swap(ref x, ref y);
            Console.WriteLine("After swap: {0}   {1}", x, y);

        }
    }
}
