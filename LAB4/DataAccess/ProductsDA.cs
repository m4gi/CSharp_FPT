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
    public class ProductsDA
    {
        readonly String connStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public List<Products> GetAllProducts()
        {
            List<Products> list = new List<Products>();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(connStr);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetAllProducts";
            SqlDataReader reader;
            Products products;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int products_ID;
                    int supplierID;
                    int categoryID;
                    float quantityPerUnit;
                    float unitPrice;
                    int unitsInStock;
                    int unitsOnOrder;
                    int reorderLevel;
                    bool discontinued;
                    Int32.TryParse(reader["ProductID"].ToString(), out products_ID);
                    Int32.TryParse(reader["SupplierID"].ToString(), out supplierID);
                    Int32.TryParse(reader["CategoryID"].ToString(), out categoryID);
                    float.TryParse(reader["QuantityPerUnit"].ToString(), out quantityPerUnit);
                    float.TryParse(reader["UnitPrice"].ToString(), out unitPrice);
                    Int32.TryParse(reader["UnitsInStock"].ToString(), out unitsInStock);
                    Int32.TryParse(reader["UnitsOnOrder"].ToString(), out unitsOnOrder);
                    Int32.TryParse(reader["ReorderLevel"].ToString(), out reorderLevel);
                    bool.TryParse(reader["Discontinued"].ToString(), out discontinued);
                    string productName = reader["ProductName"].ToString();
                    products = new Products(products_ID, productName, supplierID, categoryID, quantityPerUnit, unitPrice, unitsInStock, unitsOnOrder, reorderLevel, discontinued);
                    list.Add(products);
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

        public List<Products> SearchProductsByProductName(string name)
        {
            List<Products> list = new List<Products>();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(connStr);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SearchProductsByProductName";
            cmd.Parameters.AddWithValue("@ProductName", name);
            SqlDataReader reader;
            Products products;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int products_ID;
                    int supplierID;
                    int categoryID;
                    float quantityPerUnit;
                    float unitPrice;
                    int unitsInStock;
                    int unitsOnOrder;
                    int reorderLevel;
                    bool discontinued;
                    Int32.TryParse(reader["ProductID"].ToString(), out products_ID);
                    Int32.TryParse(reader["SupplierID"].ToString(), out supplierID);
                    Int32.TryParse(reader["CategoryID"].ToString(), out categoryID);
                    float.TryParse(reader["QuantityPerUnit"].ToString(), out quantityPerUnit);
                    float.TryParse(reader["UnitPrice"].ToString(), out unitPrice);
                    Int32.TryParse(reader["UnitsInStock"].ToString(), out unitsInStock);
                    Int32.TryParse(reader["UnitsOnOrder"].ToString(), out unitsOnOrder);
                    Int32.TryParse(reader["ReorderLevel"].ToString(), out reorderLevel);
                    bool.TryParse(reader["Discontinued"].ToString(), out discontinued);
                    string productName = reader["ProductName"].ToString();
                    products = new Products(products_ID, productName, supplierID, categoryID, quantityPerUnit, unitPrice, unitsInStock, unitsOnOrder, reorderLevel, discontinued);
                    list.Add(products);
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
