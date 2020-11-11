using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 使用GDI绘制简单图形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //【绘制一条直线的单击事件】
        private void btnHuiZhi_Click(object sender, EventArgs e)
        {
            //创建GDI对象
            Graphics g = this.CreateGraphics();
            //创建画笔对象
            //里面带颜色
            Pen pen = new Pen(Brushes.Blue);
            //创建两个点
            Point p1 = new Point(100, 100);
            Point p2 = new Point(250, 250);
            g.DrawLine(pen, p1, p2);
        }

        //【在控件需要重新绘制时发生的事件】
        int i = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            i++;
            lblShu.Text = i.ToString();
            //创建GDI对象
            Graphics g = this.CreateGraphics();
            //创建画笔对象
            //里面带颜色
            Pen pen = new Pen(Brushes.Blue);
            //创建两个点
            Point p1 = new Point(100, 100);
            Point p2 = new Point(250, 250);
            g.DrawLine(pen, p1, p2);
        }

        //【绘制一个矩形的单击事件】
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            //创建对象
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            Size size = new System.Drawing.Size(100,100);
            Rectangle rec = new Rectangle(new Point(120,120),size);
            g.DrawRectangle(pen,rec);
        }

        //【绘制一个扇形的单击事件】
        private void btnSector_Click(object sender, EventArgs e)
        {
            //创建对象
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Purple);
            Size size = new System.Drawing.Size(180,180);
            Rectangle rec = new Rectangle(new Point(180,180),size);
            g.DrawPie(pen,rec,60,60);
        }

        //【绘制一个文本的单击事件】
        private void btnText_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawString("二哈是最帅的",new Font("小美字体",25,FontStyle.Underline),Brushes.Blue,new Point(300,300));
        }
    }
}
