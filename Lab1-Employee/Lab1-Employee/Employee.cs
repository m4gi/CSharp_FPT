using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Employee
{
    class Employee
    {
        private string emID;
        private string emName;
        private double currPay;
        private double amount;

        public Employee()
        {
        }

        public Employee(string emID, string emName, double currPay, double amount)
        {
            this.emID = emID;
            this.emName = emName;
            this.currPay = currPay;
            this.amount = amount;
        }

        public Employee(string emID, string emName, double currPay)
        {
            this.emID = emID;
            this.emName = emName;
            this.currPay = currPay;
        }

        public String EMName
        {
            get { return emName; }
            set
            {
                if (value.Length > 10)
                {
                    Console.WriteLine("The name must less than 10 character!");
                }
                else { emName = value; }
            }
        }
        public String EMID
        {
            get { return emID; }
            set { emID = value; }
        }
        public Double CURRPAY
        {
            get { return currPay; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Current Pay not valid!! Set defaul current pay = 0");
                    currPay = 0;
                }
                else currPay = value;
            }
        }
        public Double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public virtual Double addCurr(Double amount)
        {
            return CURRPAY += amount;
        }

        public virtual void display()
        {
            Console.WriteLine("Name: " + emName + " ID: " + emID + " Current Pay: " + currPay);

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
