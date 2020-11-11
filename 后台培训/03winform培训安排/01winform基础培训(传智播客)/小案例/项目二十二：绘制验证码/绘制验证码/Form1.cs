using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 绘制验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //【点击更换验证码】
        private void picCode_Click(object sender, EventArgs e)
        {
            //Random r = new Random();
            //string str = null;
            ////生成随机数
            //for (int i = 0; i < 5; i++)
            //{
            //    int rNumber = r.Next(0,10);
            //    str += rNumber;
            //}
            ////MessageBox.Show(str);
            ////创建图像对象，并指定初始化大小
            //Bitmap bmp = new Bitmap(120,20);
            ////创建GDI对象
            //Graphics g = Graphics.FromImage(bmp);
            ////绘制
            //for (int i = 0; i < 5; i++)
            //{
            //    //创建点的对象
            //    Point p = new Point(i*20,0);
            //    string[] fonts = { "微软雅黑","小美字体","宋体","楷体","隶书"};
            //    Color[] colors = { Color.Yellow,Color.Blue,Color.Black,Color.Red,Color.Green,Color.Purple};
            //    g.DrawString(str[i].ToString(),new Font(fonts[r.Next(0,5)],15,FontStyle.Bold),new SolidBrush(colors[r.Next(0,6)]),p);
            //}
            ////绘制线条
            //for (int i = 0; i < 15; i++)
            //{
            //    //创建点的对象
            //    Point p1 = new Point(r.Next(0,bmp.Width),r.Next(0,bmp.Height));
            //    Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
            //    g.DrawLine(new Pen(Brushes.Green),p1,p2);
            //}
            ////给图片添加像素颗粒
            //for (int i = 0; i < 200; i++)
            //{
            //    Point p = new Point(r.Next(0,bmp.Width),r.Next(0,bmp.Height));
            //    bmp.SetPixel(p.X,p.Y,Color.Black);
            //}
            ////将图片镶嵌到picturebox中
            //picCode.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string str = null;
            //生成随机数
            for (int i = 0; i < 5; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber;
            }
            //MessageBox.Show(str);
            //创建图像对象，并指定初始化大小
            Bitmap bmp = new Bitmap(120, 20);
            //创建GDI对象
            Graphics g = Graphics.FromImage(bmp);
            //绘制
            for (int i = 0; i < 5; i++)
            {
                //创建点的对象
                Point p = new Point(i * 20, 0);
                string[] fonts = { "微软雅黑", "小美字体", "宋体", "楷体", "隶书" };
                Color[] colors = { Color.Yellow, Color.Blue, Color.Black, Color.Red, Color.Green, Color.Purple };
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 5)], 15, FontStyle.Bold), new SolidBrush(colors[r.Next(0, 6)]), p);
            }
            //绘制线条
            for (int i = 0; i < 15; i++)
            {
                //创建点的对象
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                g.DrawLine(new Pen(Brushes.Green), p1, p2);
            }
            //给图片添加像素颗粒
            for (int i = 0; i < 200; i++)
            {
                Point p = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Black);
            }
            //将图片镶嵌到picturebox中
            picCode.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            string str = null;
            //生成随机数
            for (int i = 0; i < 5; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber;
            }
            //MessageBox.Show(str);
            //创建图像对象，并指定初始化大小
            Bitmap bmp = new Bitmap(120, 20);
            //创建GDI对象
            Graphics g = Graphics.FromImage(bmp);
            //绘制
            for (int i = 0; i < 5; i++)
            {
                //创建点的对象
                Point p = new Point(i * 20, 0);
                string[] fonts = { "微软雅黑", "小美字体", "宋体", "楷体", "隶书" };
                Color[] colors = { Color.Yellow, Color.Blue, Color.Black, Color.Red, Color.Green, Color.Purple };
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 5)], 15, FontStyle.Bold), new SolidBrush(colors[r.Next(0, 6)]), p);
            }
            //绘制线条
            for (int i = 0; i < 15; i++)
            {
                //创建点的对象
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                g.DrawLine(new Pen(Brushes.Green), p1, p2);
            }
            //给图片添加像素颗粒
            for (int i = 0; i < 200; i++)
            {
                Point p = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Black);
            }
            //将图片镶嵌到picturebox中
            picCode.Image = bmp;
        }
    }
}
