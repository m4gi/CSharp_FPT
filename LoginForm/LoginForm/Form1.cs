using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class FormMain : Form
    {
        List<UserAccount> listAcc;
        SimpleDrawing drawing = new SimpleDrawing();
        public FormMain()
        {

            listAcc = new List<UserAccount> {
            new UserAccount { username = "admin", password = "12345", status = true } ,
            new UserAccount {  username = "admin2", password = "123", status = false }
            };
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var rs = (from user in listAcc
                      where user.username == txt_Username.Text
                      select user).SingleOrDefault();
            if (rs != null)
            {
                if (rs.password == txt_Password.Text)
                {
                    if (rs.status != true)
                    {
                        MessageBox.Show("Your Account Has Been Locked !", "Waring!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Login Successful", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine("Login Successful");
                        this.Hide();
                        drawing.Closed += (s, args) => this.Close();
                        drawing.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Password Wrong!!!", "Please check your Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Console.WriteLine("Username/Password Wrong!!!");
                MessageBox.Show("Username/Password Wrong!!!", "Please check your Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Console.WriteLine(rs != null);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Confirm to close!", "Closing the form", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FormMain_KeyDown;
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }
    }
}
