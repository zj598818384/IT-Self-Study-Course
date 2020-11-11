using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureBox项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置图片如何在picturebox中显示
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"C:\Users\59881\Desktop\g.jpg");
        }
        int i = 0;
        //获得指定文件夹的所有文件的全路径
        //填写存有图片的文件夹的位置
        string[] path = Directory.GetFiles(@"C:\Users\59881\Desktop\g.jpg");
        /// <summary>
        /// 点击更换下一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i==path.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i<0)
            {
                i = path.Length - 1;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
