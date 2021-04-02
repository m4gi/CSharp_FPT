using System;
using System.Collections.Generic;
using System.Linq;
namespace LinQTest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> studentList = new List<Student> {
        new Student { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student { StudentID = 2, StudentName = "Steve", Age = 15 } ,
        new Student { StudentID = 3, StudentName = "Bill", Age = 25 } ,
        new Student { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student { StudentID = 5, StudentName = "Ron" , Age = 19 },
        new Student { StudentID = 6, StudentName = "Bill" , Age = 12 }
        };

            //using Query syntax
            IEnumerable<Student> Result = from s in studentList
                                          where s.Age > 12 && s.Age < 20
                                          select s;
            //using Method syntax
            IEnumerable<Student> fResult1 = studentList.Where(s => s.Age > 12 && s.Age < 20);

            foreach (Student item in studentList)
            {
                Console.WriteLine(item);
            }


            //1. viet theo kieu Query
            IEnumerable<string> resultName = from s in studentList
                                             where s.Age > 12 && s.Age < 20
                                             select s.StudentName;
            //viet theo kieu phuong thuc 
            IEnumerable<string> resultName1 = studentList.Where(s => s.Age > 12 && s.Age < 20).Select(s => s.StudentName);

            var result = from s in studentList
                         where s.Age > 12 && s.Age < 20
                         select new { ID = s.StudentID, Name = s.StudentName };

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }

            var result4 = studentList.Where(s => s.Age > 12 && s.Age < 20).Select(s => new { ID = s.StudentID, name = s.StudentName });
            foreach( var item in result4)
            {
                Console.WriteLine(item);
            }
        }
    }
}
