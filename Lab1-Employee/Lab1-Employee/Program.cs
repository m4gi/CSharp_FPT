using System;
using System.Threading.Tasks;
namespace Lab1_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagement em = new EmployeeManagement();
            do
            {
                switch (em.Menu())
                {
                    case 1:
                        em.Add();
                        break;
                    case 2:
                        em.Edit();
                        break;
                    case 3:
                        em.Delete();
                        break;
                    case 4:
                        em.Show();
                        break;
                    case 5:
                        em.sortEmployeeByName();
                        break;
                    case 0:
                        Console.WriteLine("The program will be exit");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choose in range 0 - 5!!\nTry Again:");
                        break;
                }

            } while (true);
        }
    }
}
