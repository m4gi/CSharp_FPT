using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Demo textbox event";
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your name is: "+ txtName.Text, "Hello", MessageBoxButtons.OK);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Click Me";
            btn.Name = "btnShow";
            btn.Location = new Point(180, 100);
            btn.Click += new EventHandler(btnShow_Click);
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
           
            this.Controls.Add(btn);
        }
    }
}
