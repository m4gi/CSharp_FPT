using BussinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class SuppliersBL
    {
        SuppliersDA _supDAO;

        public SuppliersBL()
        {
            _supDAO = new SuppliersDA();
        }

        public List<Suppliers> getAllSuppliers()
        {
            return _supDAO.getAllSuppliers();
        }
        public List<Suppliers> SearchSuppliersByCompanyName(string CompanyName)
        {
            return _supDAO.SearchSuppliersByCompanyName(CompanyName);
        }
    }
}
