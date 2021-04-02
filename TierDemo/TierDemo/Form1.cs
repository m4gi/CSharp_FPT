using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject;
using BussinessLogic;
namespace TierDemo
{
    public partial class Form1 : Form
    {
        EmployeeBL emBL;
        public Form1()
        {
            InitializeComponent();
            emBL = new EmployeeBL();
        }

        private void LoadTable()
        {
            IList<Employee> employeesList = new List<Employee>();
            employeesList = emBL.getAllEmployee();
            dataTable.DataSource = employeesList;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Text = "Update";
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.dataTable.Rows[e.RowIndex];
                row.Cells["Employee_Id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String nameE = txtName.Text;
            String addressE = txtAddress.Text;
            String departmentE = txtDepartment.Text;
            String genderE;
            int rowIn = dataTable.CurrentRow.Index;
            int employee_ID;
            String idE = dataTable.Rows[rowIn].Cells["Employee_Id"].Value.ToString();
            Int32.TryParse(idE, out employee_ID);
            if (radMale.Checked)
            {
                genderE = "Nam";
            }
            else
            {
                genderE = "Nữ";
            }
            Employee em = new Employee(employee_ID, nameE, departmentE, addressE, genderE);

            emBL.deleteEmployee(em);
            LoadTable();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String nameE = txtName.Text;
            String addressE = txtAddress.Text;
            String departmentE = txtDepartment.Text;
            String genderE;
            int rowIn = dataTable.CurrentRow.Index;
            int employee_ID;
            String idE = dataTable.Rows[rowIn].Cells["Employee_Id"].Value.ToString();
            Int32.TryParse(idE, out employee_ID);
            if (radMale.Checked)
            {
                genderE = "Nam";
            }
            else
            {
                genderE = "Nữ";
            }
            Employee em = new Employee(employee_ID, nameE, departmentE, addressE, genderE);
            if (btnSave.Text == "Save")
            {
                emBL.addEmployee(em);
            }
            else
            {
                emBL.updateEmployee(em);
                btnSave.Text = "Save";
            }

            LoadTable();
        }
    }



}
