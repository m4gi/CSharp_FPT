using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Employee
{
    class Manager : Employee
    {
        private String stockOptions;

        public Manager()
        {
        }

        public Manager(string stockOptions)
        {
            this.stockOptions = stockOptions;
        }
        public Manager(string stockOptions, string emName, string emID, double currPay, double amount) : base(emName, emID, currPay, amount)
        {
            this.stockOptions = stockOptions;
        }
        public String STOCKOP
        {
            get { return stockOptions; }
            set { stockOptions = value; }
        }
        public override void display()
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3, -15}", EMID, EMName, CURRPAY, STOCKOP);
        }
    }
}
