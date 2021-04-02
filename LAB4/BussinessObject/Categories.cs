using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class Categories
    {
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }
        public String Description { get; set; }
        public String Picture { get; set; }

        public Categories(int categoryID, string categoryName, string description, string picture)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;
            Picture = picture;
        }
    }
}
