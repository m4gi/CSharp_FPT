using System;
using System.Collections.Generic;
using System.Text;

namespace LinQTest
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("ID = {0}, Name = {1}, Age = {2}", StudentID, StudentName, Age);
        }
    }
}
