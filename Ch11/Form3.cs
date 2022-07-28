using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnO1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush redBrush = new SolidBrush(Color.Red);
            Pen blackPen = new Pen(Color.Black);

            // args : xpos, ypos, width, height
            Rectangle rect = new Rectangle(10, 100, 100, 100);
            
            g.DrawRectangle(blackPen, rect);
            g.FillRectangle(redBrush, rect);
        }

        private void btnO2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush blueBrush = new SolidBrush(Color.Blue);
            Pen blackPen = new Pen(Color.Black);

            // args : xpos, ypos, width, height
            Rectangle rect = new Rectangle(160, 100, 100, 100);

            g.DrawEllipse(blackPen, rect);
            g.FillEllipse(blueBrush, rect);
        }

        private void btnO3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Black);


            g.DrawLine(blackPen, new Point(300, 150), new Point(500, 150));

        }
    }
}
