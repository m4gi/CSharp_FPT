using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Employee
{
    class EmployeeManagement
    {
        private List<Employee> listEm = new List<Employee>();

        public void Add()
        {
            Console.Write("Enter Employee ID: ");
            String emID = Console.ReadLine();
            Console.Write("Enter Employee Name: ");
            String emName = Console.ReadLine();

            double currPay = 0;
            while (true)
            {
                Console.Write("Enter Employee current pay: ");
                String curr = Console.ReadLine();
                if (Double.TryParse(curr, out currPay))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a double!");
                }
            }

            int salesNumber = 0;
            while (true)
            {
                Console.Write("Enter Employee sales number: ");
                String curr = Console.ReadLine();
                if (Int32.TryParse(curr, out salesNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a Integer!");
                }
            }

            Double amount = 0;
            while (true)
            {
                Console.Write("Enter Employee Amount: ");
                String curr = Console.ReadLine();
                if (Double.TryParse(curr, out amount))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a double!");
                }
            }
            listEm.Add(new SalesPerson(salesNumber, emID, emName, currPay, amount));
            Console.WriteLine("Add Employee Successfully!!!");
        }
        public void Edit()
        {
            Console.WriteLine("-----EDIT EMPLOYEE----");
            Console.Write("Enter Employee ID to edit: ");
            String emID = Console.ReadLine();
            foreach (var index in listEm)
            {
                if (emID.Equals(index.EMID))
                {
                    Console.WriteLine("Enter Employee name : ");
                    String name = Console.ReadLine();
                    index.EMName = name;
                    Console.WriteLine("UPDATE EMPLOYEE SUCCESSFULLY!!!");
                }
            }
        }


        public void sortEmployeeByName()
        {
            listEm.Sort(delegate (Employee x, Employee y)
            {
                if (x.EMName == null && y.EMName == null) return 0;
                else if (x.EMName == null) return -1;
                else if (y.EMName == null) return 1;
                else return x.EMName.CompareTo(y.EMName);
            });
            Console.WriteLine("Sort Employee By Name Successfully!!!");
            Show();
        }
        public void Delete()
        {
            Console.WriteLine("-----DELETE EMPLOYEE----");
            Console.Write("Enter Employee ID to delete: ");
            String emID = Console.ReadLine();
            foreach (var index in listEm)
            {
                if (emID.Equals(index.EMID))
                {
                    listEm.Remove(index);
                    Console.WriteLine("DELETE EMPLOYEE SUCCESSFULLY!!!");
                    return;
                }
            }
            Console.WriteLine("Can't Delete Employee ID: " + emID + ". It's not exits!!!");
        }

        public double Total(Employee em)
        {
            return em.CURRPAY + em.addCurr(em.Amount);
        }

        public void Show()
        {
            Console.WriteLine("-----LIST EMPLOYEE-----");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", "ID", "Name", "Current Pay", "Bonus", "Total Pay");
            foreach (var index in listEm)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", index.EMID, index.EMName, index.CURRPAY, index.addCurr(index.Amount), Total(index));
            }
        }

        public int Menu()
        {
            Console.WriteLine("\n-----MENU-----\n");
            Console.WriteLine("1. ADD NEW EMPLOYEE.");
            Console.WriteLine("2. EDIT EMPLOYEE.");
            Console.WriteLine("3. DELETE EMPLOYEE.");
            Console.WriteLine("4. SHOW ALL EMPLOYEE.");
            Console.WriteLine("5. SORT EMPLOYEE BY NAME.");
            Console.WriteLine("0. EXIT!");
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
