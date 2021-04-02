using BussinessObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoriesDA 
    {
        readonly String connStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public List<Categories> GetAllCategories()
        {
            List<Categories> list = new List<Categories>();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(connStr);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetAllCategories";
            SqlDataReader reader;
            Categories categories;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int category_ID;
                    Int32.TryParse(reader["CategoryID"].ToString(), out category_ID);
                    categories = new Categories(category_ID, reader["CategoryName"].ToString(), reader["Description"].ToString(), reader["Picture"].ToString());
                    list.Add(categories);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error:" + ex);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return list;
        }
       
    }
}
