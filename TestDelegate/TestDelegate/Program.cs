using System;

namespace TestDelegate
{
    class Program
    {
        public delegate void HiDelegate(string message);
        public delegate int MathDelegate(int a, int b);
        
        static void Main(string[] args)
        {
            //HiDelegate hiDel = new HiDelegate(sayHi);
            //hiDel("my");
            MathCompute compute = new MathCompute();
            //MathDelegate math = compute.Add;
            //Console.WriteLine("Add :" + math(1, 2));

            //1. Phuong thuc nac danh
            /*MathDelegate math = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(math(1,2));

            //2. Phuong thuc lamda
            MathDelegate mathDel1 = (int a, int b) => a + b;
            Console.WriteLine(mathDel1(1, 3));*/

            //1. Delegate func tro den phuong thuc Add
            Func<int, int, int> addFunc = compute.Add;
            int res = addFunc(1, 2);

            //2. Delecate Func lamda exprestion
            Func<int, int, int> addFunc1 = (int a, int b) => compute.Add(a, b);

            res = addFunc1(1, 2);

            //Predicate Test
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("Hello World");

            Console.WriteLine(result);
            //Predicate with Anonymous Method
            Predicate<string> isUpper1 = delegate (string s)
            {
                return s.Equals(s.ToUpper());
            };

            //Predicate with Lamda Expression
            Predicate<string> isUpper2 = s => s.Equals(s.ToUpper());



            //
            Predicate<int> postiveNum = a => a > 0;

            Console.WriteLine(postiveNum(2));
            Console.WriteLine(postiveNum(-1));

        }

        static void sayHi(string message)
        {
            Console.WriteLine("Method sayHi" + message);
        }
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }

    class MathCompute
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multip(int a, int b)
        {
            return a *b;
        }
    }
}
