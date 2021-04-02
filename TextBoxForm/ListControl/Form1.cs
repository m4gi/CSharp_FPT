using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBoxItems.Items.Add("C#");
            //listBoxItems.Items.Add("Java");
            //listBoxItems.Items.Add("C++");
            //listBoxItems.Items.Add("Python");
            //listBoxItems.Items.Add("NodeJS");
            //listBoxItems.Items.Add("Ruby");
            List<Employee> list = new List<Employee> {
                new Employee { ID = 1, lastName = "Tuan", birthday = new DateTime(2000, 09, 07) },
                new Employee { ID = 2, lastName = "Nhan", birthday = new DateTime(2000, 09, 07) },
                new Employee { ID = 3, lastName = "Le", birthday = new DateTime(2000, 7, 27) },
                new Employee { ID = 4, lastName = "Hoang", birthday = new DateTime(2002, 10, 10) }
            };

            listBoxItems.DataSource = list;
            txtEmployee.DataBindings.Add("Text", list, "Name");

        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listBoxItems.SelectedItem.ToString());
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("You should choose items in the list!");
            }
            StringBuilder sb = new System.Text.StringBuilder();
            foreach (object item in listBoxItems.SelectedItems)
            {
                sb.Append(item.ToString());
                sb.Append(Environment.NewLine);
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
