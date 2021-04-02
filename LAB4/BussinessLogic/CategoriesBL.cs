using BussinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class CategoriesBL
    {
        CategoriesDA _caDAO;

        public CategoriesBL()
        {
            _caDAO = new CategoriesDA();
        }

        public List<Categories> getAllCategories()
        {
            return _caDAO.GetAllCategories();
        }
    }
}
