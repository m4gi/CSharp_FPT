using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListControl
{
    class Employee
    {
        public int ID { get; set; }
        //public String firstName { get; set; }
        public String lastName { get; set; }
        public DateTime birthday { get; set; }

        public override string ToString()
        {
            return ID + " - " + lastName + " - " + birthday;
        }
    }
}
