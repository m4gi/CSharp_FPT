using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;
namespace DataAccess
{
    public class EmployeeDA
    {
        String connStr = ConfigurationManager.ConnectionStrings["EmployeeStr"].ConnectionString;

        public List<Employee> getAllEmployee()
        {
            List<Employee> list = new List<Employee>();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(connStr);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Employee_DE140280";
            SqlDataReader reader;
            Employee employee = null;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int employee_ID;
                    Int32.TryParse(reader["Employee_Id"].ToString(), out employee_ID);
                    employee = new Employee(employee_ID, reader["Name"].ToString(), reader["Department"].ToString(), reader["Address"].ToString(), reader["Gender"].ToString());
                    list.Add(employee);
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

        public int deleteEmployee(Employee e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Employee_DE140280 WHERE Employee_Id = @id";
            cmd.Parameters.AddWithValue("@id", e.Employee_ID);
            try
            {
                con.Open();
                int rs = cmd.ExecuteNonQuery();
                return rs;

            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public int addEmployee(Employee e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Employee_DE140280(Name, Address, Department, Gender) VALUES (@na, @ad, @de, @ge)";
            cmd.Parameters.AddWithValue("@na", e.Name);
            cmd.Parameters.AddWithValue("@ad", e.Address);
            cmd.Parameters.AddWithValue("@de", e.Department);
            cmd.Parameters.AddWithValue("@ge", e.Gender);
            try
            {
                con.Open();
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (SqlException ex)
            {
                return -1;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public int updateEmployee(Employee e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Employee_DE140280 SET Name = @na , Address = @ad , Department = @de , Gender = @ge WHERE Employee_Id = @id";
            cmd.Parameters.AddWithValue("@na", e.Name);
            cmd.Parameters.AddWithValue("@ad", e.Address);
            cmd.Parameters.AddWithValue("@de", e.Department);
            cmd.Parameters.AddWithValue("@ge", e.Gender);
            cmd.Parameters.AddWithValue("@id", e.Employee_ID);
            try
            {
                con.Open();
                int rs = cmd.ExecuteNonQuery();
                return rs;
            }
            catch (SqlException ex)
            {
                return -1;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
