using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookLibrary
{
    class Validation
    {
        //check user input string
        public static String checkInputString()
        {
            //loop until user input correct
            while (true)
            {
                String result = Console.ReadLine();
                if (result.Length == 0)
                {
                    Console.WriteLine("Not empty");
                    Console.Write("Enter again: ");
                }
                else
                {
                    return result;
                }
            }
        }
        //check user input yes/ no
        public static bool checkInputYN()
        {
            //loop until user input correct
            while (true)
            {
                String result = checkInputString();
                //return true if user input y/Y
                if (result.Equals("Y") || result.Equals("y"))
                {
                    return true;
                }
                //return false if user input n/N
                if (result.Equals("N") || result.Equals("n"))
                {
                    return false;
                }
                Console.WriteLine("Please input y/Y or n/N.");
                Console.Write("Enter again: ");
            }
        }
    }
}
