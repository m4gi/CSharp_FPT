using BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class Form1 : Form
    {
        CategoriesBL categoriesBL;
        SuppliersBL suppliersBL;
        ProductsBL productsBL;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            dataTable.DataSource = productsBL.getAllProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            categoriesBL = new CategoriesBL();
            suppliersBL = new SuppliersBL();
            productsBL = new ProductsBL();
        }

        private void btnListSuppliers_Click(object sender, EventArgs e)
        {
            dataTable.DataSource = suppliersBL.getAllSuppliers();
        }

        private void btnListCategories_Click(object sender, EventArgs e)
        {
            dataTable.DataSource = categoriesBL.getAllCategories();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            GetName frm = new GetName();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                dataTable.DataSource = productsBL.SearchProductsByProductName(frm.getName);
            }
        }

        private void btnSearchSuppliers_Click(object sender, EventArgs e)
        {
            GetName frm = new GetName();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dataTable.DataSource = suppliersBL.SearchSuppliersByCompanyName(frm.getName);
            }
        }
    }
}
