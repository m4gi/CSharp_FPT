using BussinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class ProductsBL
    {
        ProductsDA _proDAO;

        public ProductsBL()
        {
            _proDAO = new ProductsDA();
        }

        public List<Products> getAllProducts()
        {
            return _proDAO.GetAllProducts();
        }

        public List<Products> SearchProductsByProductName(string ProductName)
        {
            return _proDAO.SearchProductsByProductName(ProductName);
        }

    }
}
