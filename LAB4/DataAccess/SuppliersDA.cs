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
    public class SuppliersDA
    {
       readonly String connStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public List<Suppliers> getAllSuppliers()
        {
            List<Suppliers> list = new List<Suppliers>();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(connStr);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetAllSupplier";
            SqlDataReader reader;
            Suppliers suppliers;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int suppliers_ID;
                    Int32.TryParse(reader["SupplierID"].ToString(), out suppliers_ID);
                    string companyName = reader["CompanyName"].ToString();
                    string contactName = reader["ContactName"].ToString();
                    string contactTitle = reader["ContactTitle"].ToString();
                    string address = reader["Address"].ToString();
                    string city = reader["City"].ToString();
                    string region = reader["Region"].ToString();
                    string postalCode = reader["PostalCode"].ToString();
                    string country = reader["Country"].ToString();
                    string phone = reader["Phone"].ToString();
                    string fax = reader["Fax"].ToString();
                    string homePage = reader["HomePage"].ToString();
                    suppliers = new Suppliers(suppliers_ID, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax, homePage);
                    list.Add(suppliers);
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

        public List<Suppliers> SearchSuppliersByCompanyName(string name)
        {
            List<Suppliers> list = new List<Suppliers>();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(connStr);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SearchSuppliersByCompanyName";
            cmd.Parameters.AddWithValue("@CompanyName", name);
            SqlDataReader reader;
            Suppliers suppliers;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int suppliers_ID;
                    Int32.TryParse(reader["SupplierID"].ToString(), out suppliers_ID);
                    string companyName = reader["CompanyName"].ToString();
                    string contactName = reader["ContactName"].ToString();
                    string contactTitle = reader["ContactTitle"].ToString();
                    string address = reader["Address"].ToString();
                    string city = reader["City"].ToString();
                    string region = reader["Region"].ToString();
                    string postalCode = reader["PostalCode"].ToString();
                    string country = reader["Country"].ToString();
                    string phone = reader["Phone"].ToString();
                    string fax = reader["Fax"].ToString();
                    string homePage = reader["HomePage"].ToString();
                    suppliers = new Suppliers(suppliers_ID, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax, homePage);
                    list.Add(suppliers);
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
