using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationDemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText(this);
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length == 0)
            {
                errorProvider1.SetError(ctrl, "You must input");
            }
            else
            {
                errorProvider1.SetError(ctrl, "");
            }
        }
    }
}
