using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BussinessObject;
namespace BussinessLogic
{
    public class EmployeeBL
    {
        EmployeeDA _empDAO;

        public EmployeeBL()
        {
            _empDAO = new EmployeeDA();
        }

        public List<Employee> getAllEmployee()
        {
            return _empDAO.getAllEmployee();
        }

        public int deleteEmployee(Employee e)
        {
            return _empDAO.deleteEmployee(e);
        }

        public int addEmployee(Employee e)
        {
            return _empDAO.addEmployee(e);
        }
        public int updateEmployee(Employee e)
        {
            return _empDAO.updateEmployee(e);
        }
    }
}
