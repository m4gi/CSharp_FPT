using System;
using System.Collections.Generic;
using System.Text;

namespace MyBookLibrary
{
    public class BookLibrary
    {
        List<Book> listBook;
        public BookLibrary()
        {
            listBook = new List<Book>();
        }
        public void Add()
        {
            Console.Write("Enter Book ID: ");
            String ID = Console.ReadLine();
            Console.Write("Enter Book Name: ");
            String Name = Console.ReadLine();
            Console.Write("Enter Book Publisher: ");
            String Publisher = Console.ReadLine();


            Double price = 0;
            while (true)
            {
                Console.Write("Enter Book Price: ");
                String curr = Console.ReadLine();
                if (Double.TryParse(curr, out price))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a double!");
                }
            }
            listBook.Add(new Book(ID, Name, Publisher, price));
            Console.WriteLine("Add Book Successfully!!!");
        }


        public void Edit()
        {
            Console.WriteLine("-----EDIT Book----");
            Console.Write("Enter Book ID to edit: ");
            String ID = Console.ReadLine();
            foreach (var index in listBook)
            {
                if (ID.Equals(index.bID))
                {
                    Console.Write("Enter Book Name : ");
                    String name = Console.ReadLine();
                    Console.Write("Enter Book Publisher: ");
                    String publisher = Console.ReadLine();
                    index.bName = name;
                    index.bPublisher = publisher;
                    Double price = 0;
                    while (true)
                    {
                        Console.Write("Enter Book Price: ");
                        String curr = Console.ReadLine();
                        if (Double.TryParse(curr, out price))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not a double!");
                        }
                    }
                    index.bPrice = price;
                    Console.WriteLine("UPDATE BOOK SUCCESSFULLY!!!");
                }
            }
        }

        public void Delete()
        {
            Console.WriteLine("-----DELETE BOOK----");
            Console.Write("Enter BOOK ID to delete: ");
            String ID = Console.ReadLine();
            foreach (var index in listBook)
            {
                if (ID.Equals(index.bID))
                {
                    Console.WriteLine("Found A Book With ID: " + ID + "\nDo you want delete ? (Y/N): ");
                    if (Validation.checkInputYN())
                    {
                        listBook.Remove(index);
                        Console.WriteLine("DELETE BOOK SUCCESSFULLY!!!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("DELETE BOOK FAIL!!!");
                        return;
                    }

                }
            }
            Console.WriteLine("Can't Delete Book ID: " + ID + ". It's not exits!!!");
        }

        public void Show()
        {
            Console.WriteLine("-----LIST ALL BOOK-----");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", "ID", "Book Name", "Publisher", "Price");
            foreach (var index in listBook)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15:0.##}", index.bID, index.bName, index.bPublisher, index.bPrice);
            }
        }

        public int Menu()
        {

            Console.WriteLine("\n-----MENU-----\n");
            Console.WriteLine("1. ADD NEW BOOK.");
            Console.WriteLine("2. UPDATE A BOOK.");
            Console.WriteLine("3. DELETE A BOOK.");
            Console.WriteLine("4. LIST ALL BOOK.");
            Console.WriteLine("5. EXIT!");
            int choice;
            while (true)
            {
                Console.Write("Enter your choice: ");
                String s = Console.ReadLine();
                if (Int32.TryParse(s, out choice))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a Integer!");
                }
            }

            return choice;
        }

    }
}
