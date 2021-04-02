using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesstEL.Model;

namespace TesstEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void loadForm()
        {
            var db = new EmployeeDBEntities();
            var emList = db.Employees.ToList();
            dataTable.DataSource = emList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
