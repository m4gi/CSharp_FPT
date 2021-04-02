using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Employee
{
    class SalesPerson : Employee
    {
        private int salesNumber;

        public SalesPerson(int salesNumber)
        {
            this.salesNumber = salesNumber;
        }

        public SalesPerson(int salesNumber, string emID, string emName, double currPay, double amount) : base(emID, emName, currPay, amount)
        {
            this.salesNumber = salesNumber;
        }

        public int SalesNumber
        {
            get { return salesNumber; }
            set { salesNumber = value; }
        }

        public override void display()
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", EMID, EMName, CURRPAY, salesNumber);
        }
        public override double addCurr(double amount)
        {
            int bonus = 0;
            if(SalesNumber <=100) { bonus = 10; }
            else if (SalesNumber <= 200) { bonus = 15; }
            else { bonus = 20; }
            return amount * bonus + CURRPAY;
        }

    }
}
