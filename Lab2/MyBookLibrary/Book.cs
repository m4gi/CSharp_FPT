using System;
using System.Collections.Generic;
using System.Text;

namespace MyBookLibrary
{
    public class Book
    {
        private string bookID;
        private string bookName;
        private string bookPublisher;
        private double bookPrice;

        public Book()
        {
        }

        public Book(string bookID, string bookName, string bookPublisher, double bookPrice)
        {
            this.bookID = bookID;
            this.bookName = bookName;
            this.bookPublisher = bookPublisher;
            this.bookPrice = bookPrice;
        }

        public String bID
        {
            get
            {
                return bookID;
            }
            set
            {
                bookID = value;
            }
        }
        public String bName
        {
            get
            {
                return bookName;
            }
            set
            {
                bookName = value;
            }
        }
        public String bPublisher
        {
            get
            {
                return bookPublisher;
            }
            set
            {
                bookPublisher = value;
            }
        }
        public Double bPrice
        {
            get
            {
                return bookPrice;
            }
            set
            {
                bookPrice = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("{0, -15} {1,-15} {2,-15} {3:0.##,-15}", bID, bName, bPublisher, bPrice);
        }
    }
}
