using System;
using MyBookLibrary;
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            BookLibrary bl = new BookLibrary();
            do
            {
                switch (bl.Menu())
                {
                    case 1:
                        bl.Add();
                        break;
                    case 2:
                        bl.Edit();
                        break;
                    case 3:
                        bl.Delete();
                        break;
                    case 4:
                        bl.Show();
                        break;
                    case 5:
                        Console.WriteLine("The program will be exit");
                        return;
                    default:
                        Console.WriteLine("Choose in range 1 - 5!!\nTry Again:");
                        break;
                }

            } while (true);
        }
    }
}
