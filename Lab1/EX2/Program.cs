using System;

namespace EX2
{
    class Program
    {
        public static void add(int a, int b, out int ans)
        {
            ans = a + b;
        }
        public static void CalAverage(int[] arr, out double ans)
        {
            double sum = 0;
            foreach(var i in arr)
            {
                sum += i;
            }
            ans = sum / arr.Length;
        }
        public static void display(object[] data)
        {
            foreach(var item in data){
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 12;
            //int ans;
            //add(x, y, out ans);
            //Console.WriteLine("ADD : " + ans);
            //object[] nhan = { 1, -1, -1.5, "nhan" };
            //display(nhan);
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            double ave;
            CalAverage(arr, out ave);
            Console.WriteLine(ave);
        }
    }
}
