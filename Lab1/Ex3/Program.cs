using System;

namespace Ex3
{
    class SavingAccount
    {
        double balance;

        public SavingAccount()
        {
            balance = 1000;
        }
        public SavingAccount(double initialAmount)
        {
            balance = initialAmount;
        }
        public void GetBalance()
        {
            Console.WriteLine("Balance : {0}", this.balance);
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
            Console.WriteLine("Desposit successfully!!! Balance : {0}", this.balance);
        }
        public void Withdraw(double amount)
        {
            if (this.balance >= amount)
            {
                this.balance -= amount;
                Console.WriteLine("Withdraw successfully!!! Balance: {0}", this.balance);
            }
            else
            {
                Console.WriteLine("Withdraw fail!!!Balance: {0}", this.balance);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sv1 = new SavingAccount();
            SavingAccount sv2 = new SavingAccount(2000);

            sv1.GetBalance();
            sv1.Deposit(500);
            sv1.Withdraw(2000);
            Console.WriteLine();
            sv2.GetBalance();
            sv2.Withdraw(1000);
            sv2.Deposit(200);
        }
    }
}
