using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace figurki_atempt_3
{
    public partial class Form1 : Form
    {
        int panelY;
        int panelX;
        private static readonly Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        Thread th;
        Thread th1;
        

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            th = new Thread(thread);
            th.Start();
        }

        public void thread()
        {
            for (int i = 0; i < 100; i++)
            {
                int size = 0;
                FillTriangle(new Point(panelX, panelY), size);
            }
           
        }

        public void FillTriangle(Point p, int size)
        {
            Graphics g = CreateGraphics();
            g.DrawPolygon(new Pen(RandomColor(), 4), new Point[] { p, new Point(p.X - size, p.Y + (int)(size * Math.Sqrt(3))), new Point(p.X + size, p.Y + (int)(size * Math.Sqrt(3))) });
        }
        private Color RandomColor()
        {
            return Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }
    }
}
