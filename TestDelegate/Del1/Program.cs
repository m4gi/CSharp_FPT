using System;
namespace Del1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 10;
            //i.isGreaterThan(3);
            Console.WriteLine(i.isGreaterThan(3));
            String s = "xin        chao        moi     nguoi ";
            Console.WriteLine(s.CountWords());
        }
    }
}
