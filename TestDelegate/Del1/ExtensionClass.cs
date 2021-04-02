using System;
using System.Collections.Generic;
using System.Text;

namespace Del1
{
    static class ExtensionClass
    {
         public static bool isGreaterThan(this int i, int anothor)
        {
            return i > anothor;
        }

        public static int CountWords(this string line)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n','.','!',',','|', '?'};
            return line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
