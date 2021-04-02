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
    public partial class SimpleDrawing : Form
    {
        private Color _color;                 // save the color somewhere
        private bool iKnowDaColor = false;    // this will be set to true when we know the color
        private Graphics g;                   // Create the Graphics
        public SimpleDrawing()
        {
            InitializeComponent();
            //Add items to combox
            combox_Color.Items.Add("Green");
            combox_Color.Items.Add("Red");
            combox_Color.Items.Add("Yellow");
            combox_Color.Items.Add("Orange");
        }


        private void btnDraw_Click(object sender, EventArgs e)
        {
            g.Clear(panelDraw.BackColor);
            Console.WriteLine("Drawing");
            switch (combox_Color.SelectedItem)
            {
                case "Green":
                    _color = Color.Green;
                    iKnowDaColor = true;
                    break;
                case "Red":
                    _color = Color.Red;
                    iKnowDaColor = true;
                    break;
                case "Yellow":
                    _color = Color.Yellow;
                    iKnowDaColor = true;
                    break;
                case "Orange":
                    _color = Color.Orange;
                    iKnowDaColor = true;
                    break;
            }
            if (iKnowDaColor)
            {
                Console.WriteLine("Color: " + combox_Color.SelectedItem);
                SolidBrush brush = new SolidBrush(_color);
                
                if (radRectangle.Checked)
                {                   
                    g.FillRectangle(brush, 0, 30, 250, 150);
                }
                else
                {
                    Rectangle r = new Rectangle(0, 0, 250, 250);
                    g.FillEllipse(brush, r);
                }

            }
            else
            {
                MessageBox.Show("Choose Color Of Shape !!!", "Color not null....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SimpleDrawing_Load(object sender, EventArgs e)
        {
            g = panelDraw.CreateGraphics();
        }
    }
}
