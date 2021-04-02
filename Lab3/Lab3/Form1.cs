using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadTable()
        {
            SqlCommand cmd = new SqlCommand();
            String connStr = ConfigurationManager.ConnectionStrings["EmployeeStr"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Employee";
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataTable.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public static void deleteRow(string table, string columnName, string IDNumber)
        {
            String connStr = ConfigurationManager.ConnectionStrings["EmployeeStr"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            try
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM " + table + " WHERE " + columnName + " = " + IDNumber, con))
                {
                    command.ExecuteNonQuery();
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }


        private void SetFirstRowSelected()
        {
            if (dataTable.Rows.Count > 0)
            {
                var row = dataTable.Rows[0];

                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAddress.Text = row.Cells["City"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
                if (row.Cells["Gender"].Value.ToString().Equals("Nam"))
                {
                    radMale.Checked = true;
                }
                else
                {
                    radFemale.Checked = true;
                }
                dataTable.CurrentCell = row.Cells[0]; //set focus to first cell in first row
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTable();
            SetFirstRowSelected();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            String connStr = ConfigurationManager.ConnectionStrings["EmployeeStr"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            String nameE = txtName.Text;
            String cityE = txtAddress.Text;
            String departmentE = txtDepartment.Text;
            String genderE;
            int rowIn = dataTable.CurrentRow.Index;
            String idE = dataTable.Rows[rowIn].Cells["EmployeeID"].Value.ToString();
            if (radMale.Checked)
            {
                genderE = "Nam";
            }
            else
            {
                genderE = "Nữ";
            }
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Employee SET Name = N'" + nameE + "' , City = N'" + cityE + "' , Department = N'" + departmentE + "' , Gender = N'" + genderE + "' WHERE EmployeeID = '" + idE + "'";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            LoadTable();
            disableInput();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIn = dataTable.CurrentRow.Index;
            String idE = dataTable.Rows[rowIn].Cells["EmployeeID"].Value.ToString();
            if (dataTable.SelectedRows.Count > 0)
            {
                deleteRow("Employee", "EmployeeID", idE);
                dataTable.Rows.RemoveAt(dataTable.SelectedRows[0].Index);
            }
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disableInput();
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.dataTable.Rows[e.RowIndex];
                row.Cells["EmployeeID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAddress.Text = row.Cells["City"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
                if (row.Cells["Gender"].Value.ToString().Equals("Nam"))
                {
                    radMale.Checked = true;
                }
                else
                {
                    radFemale.Checked = true;
                }
            }
        }

        private void clearText(Control ctrl)
        {
            if (ctrl is TextBox)
            {
                ctrl.Text = String.Empty;
            }
            foreach (Control c in ctrl.Controls)
            {
                clearText(c);
            }
        }

        private void enableInput()
        {
            txtAddress.Enabled = true;
            txtName.Enabled = true;
            txtDepartment.Enabled = true;
            radFemale.Enabled = true;
            radMale.Enabled = true;
        }
        private void disableInput()
        {
            txtAddress.Enabled = false;
            txtName.Enabled = false;
            txtDepartment.Enabled = false;
            radFemale.Enabled = false;
            radMale.Enabled = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText(this);
            enableInput();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text.Equals("Save"))
            {
                String nameE = txtName.Text;
                String cityE = txtAddress.Text;
                String departmentE = txtDepartment.Text;
                String genderE = null;
                SqlCommand cmd = new SqlCommand();
                String connStr = ConfigurationManager.ConnectionStrings["EmployeeStr"].ConnectionString;
                SqlConnection con = new SqlConnection(connStr);

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Employee(Name, City, Department, Gender) VALUES (@na, @ct, @de, @ge)";
                cmd.Parameters.AddWithValue("@na", nameE);
                cmd.Parameters.AddWithValue("@ct", cityE);
                cmd.Parameters.AddWithValue("@de", departmentE);
                if (radMale.Checked)
                {
                    genderE = "Nam";
                }
                else
                {
                    genderE = "Nữ";
                }
                cmd.Parameters.AddWithValue("@ge", genderE);

                try
                {
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
                LoadTable();
                disableInput();
                btnSave.Text = "Add New";
            }
            else
            {
                clearText(this);
                enableInput();
                btnSave.Text = "Save";
            }
        }
    }
}



