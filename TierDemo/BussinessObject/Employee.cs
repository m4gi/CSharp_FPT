using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class Employee
    {

        public int Employee_ID { get; set; }

        public String Name { get; set; }

        public String Department { get; set; }

        public String Address { get; set; }

        public String Gender { get; set; }

        public Employee(int employee_ID, string name, string department, string address, string gender)
        {
            Employee_ID = employee_ID;
            Name = name;
            Department = department;
            Address = address;
            Gender = gender;
        }
    }
}
