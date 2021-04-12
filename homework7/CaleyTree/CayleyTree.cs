using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CayleyTree
{
    public partial class CayleyTree : Form
    {
        private Graphics graphics;

        private GraphicsState graphicsRe;
        private Color Pencolor=Color.Black;
        int depth = 8;
        double length = 100;
        double th1 = 30 ;
        double th2 = 20 ;
        double per1 = 0.6;
        double per2 = 0.7;
        double x0;
        double y0;


        public CayleyTree()
        {
            InitializeComponent();
        }

        private void CayleyTree_Load(object sender, EventArgs e)
        {
            double height = PanelPrint.Height;
            double width = PanelPrint.Width;
            x0 = width / 2;
            y0 = height - height / 7;
        }

        private void CaleyTree_SizeChanged(object sender,EventArgs e)
        {
            double height = PanelPrint.Height;
            double width = PanelPrint.Width;
            x0 = width / 2 ;
            y0 = height - height / 7;
            graphics.Restore(graphicsRe);
        }

        private void button_draw_Click(object sender, EventArgs e)
        {
            graphics = PanelPrint.CreateGraphics();
            graphics.Clear(PanelPrint.BackColor);

            drawCayleyTree(depth, x0, y0, length, -Math.PI / 2);
            graphicsRe= graphics.Save();
        }



        private void drawCayleyTree(int n,double x0,double y0,double length,double th)
        {
            Pen pen=new Pen(Pencolor);
            if (n == 0) return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);
            
            graphics.DrawLine(pen,(float)x0, (float)y0, (float)x1, (float)y1);

            drawCayleyTree(n - 1, x1, y1, per1 * length, th + th1 * Math.PI / 180);
            drawCayleyTree(n - 1, x1, y1, per2 * length, th - th2 * Math.PI / 180);
        }

        private void button_SelectColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Pencolor=colorDialog1.Color;
            button_draw_Click(sender,e);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            depth = trackBar1.Value;
        }

        private void textBox_length_TextChanged(object sender, EventArgs e)
        {
            length = Convert.ToDouble(textBox_length.Text);
        }

        private void textBox_per1_TextChanged(object sender, EventArgs e)
        {
            per1 = Convert.ToDouble(textBox_per1.Text);
        }

        private void textBox_per2_TextChanged(object sender, EventArgs e)
        {
            per2 = Convert.ToDouble(textBox_per2.Text);
        }

        private void textBox_th1_TextChanged(object sender, EventArgs e)
        {
            th1 = Convert.ToDouble(textBox_th1.Text);
        }

        private void textBox_th2_TextChanged(object sender, EventArgs e)
        {
            th2 = Convert.ToDouble(textBox_th2.Text);
        }
    }
}
