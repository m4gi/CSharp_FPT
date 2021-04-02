using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ADOTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //String connStr = @"Data Source = MAGI\MAGI; Initial Catalog = DemoDB; Integrated Security=True; User ID=magi;Password=letuan";
            SqlCommand cmd = new SqlCommand();
            String connStr = ConfigurationManager.ConnectionStrings["DemoDBStr"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Employee";
            SqlDataReader reader;
            try
            {
                con.Open();
                //MessageBox.Show("Connect successfully!");
                reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

    }
}
