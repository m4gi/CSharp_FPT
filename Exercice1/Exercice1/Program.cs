using System;

namespace Exercice2
{
    class Employee
    {
        private string emName;
        private string emId;
        private int emCurrPay;

        public string Name
        {
            get { return emName; }
            set
            {
                if (value.Length < 10)
                {
                    Console.WriteLine("The length of name that must be less than 10 characters!");
                }
                else
                {
                    emName = value;
                }
            }
        }
        public string Id
        {
            get { return emId; }
            set { emId = value; }
        }
        public int CurrPay
        {
            get { return emCurrPay; }
            set
            {
                if (value < 0)
                {
                    emCurrPay = 0;
                }
                else
                {
                    emCurrPay = value;
                }
            }
        }

        public Employee()
        {

        }

        public Employee(string emName, string emId)
        {
            this.emName = emName;
            this.emId = emId;
        }

        public Employee(string emName, string emId, int emCurrPay)
        {

           
                this.emName = emName;
            
            this.emId = emId;
            if (emCurrPay < 0)
            {
                this.emCurrPay = 0;
            }
            else
            {
                this.emCurrPay = emCurrPay;
            }
        }

        public override string ToString()
        {
            return "ID : " + emId + "\nName : " + emName + "\nPay: " + emCurrPay;
        }

        public virtual void Display()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-10}", Id, Name, CurrPay);

        }
    }

    class Manager : Employee
    {
        int stockOptions;


        public int Options
        {
            get { return stockOptions; }
            set { stockOptions = value; }
        }

        public Manager()
        {
        }

        public Manager(int stockOptions)
        {
            this.stockOptions = stockOptions;
        }

        public Manager(string emName, string emId, int emCurrPay, int stockOptions) : base(emName, emId, emCurrPay)
        {
            this.stockOptions = stockOptions;

        }

        public override string ToString()
        {
            return "ID : " + Id + "\nName : " + Name + "\nPay: " + CurrPay + "\nOption : " + Options;
        }
        public override void Display()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}", Id, Name, CurrPay, Options);
        }
    }

    class SalePerson : Employee
    {
        int salesNumber;

        public int Number
        {
            get { return salesNumber; }
            set { salesNumber = value; }
        }


        public SalePerson()
        {
        }

        public SalePerson(int salesNumber)
        {
            this.salesNumber = salesNumber;
        }

        public SalePerson(string emName, string emId, int emCurrPay, int salesNumber) : base(emName, emId, emCurrPay)
        {
            this.salesNumber = salesNumber;
        }

        public override string ToString()
        {
            return "ID : " + Id + "\nName : " + Name + "\nPay: " + CurrPay + "\nNumber : " + Number;
        }
        public override void Display()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}", Id, Name, CurrPay, Number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}", "ID", "Name", "CurrPay", "Option/Number");
            Employee[] arrE = { new Manager("1", "Le Tuan", 1000, 100), 
                new SalePerson("2", "Anh Tuan", 200, 70), 
                new SalePerson("3", "Chi Nhan", 50, 3)};
            foreach(Employee index in arrE)
            {
                index.Display();
            }
        }
    }
}
