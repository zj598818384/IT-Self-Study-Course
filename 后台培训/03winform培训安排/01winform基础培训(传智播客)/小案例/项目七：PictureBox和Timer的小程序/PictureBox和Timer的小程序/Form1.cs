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
using System.Media;

namespace PictureBox和Timer的小程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            //播放音乐
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation=@"C:\Users\59881\Desktop\@滔滔吖-董小姐.wav";
            sp.Play();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            //在窗体加载的时候，给每一个picturebox都赋值一张图片的路径
            pictureBox1.Image = Image.FromFile(@"C:\Users\59881\Desktop\图片1.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\59881\Desktop\图片1.png");
            pictureBox3.Image = Image.FromFile(@"C:\Users\59881\Desktop\图片1.png");
            pictureBox4.Image = Image.FromFile(@"C:\Users\59881\Desktop\图片1.png");
            pictureBox5.Image = Image.FromFile(@"C:\Users\59881\Desktop\图片1.png");
            pictureBox6.Image = Image.FromFile(@"C:\Users\59881\Desktop\图片1.png");
        }
        //里面路径放存有图片的文件夹的路径
        string[] path=System.IO.Directory.GetFiles(@"C: \Users\59881\Desktop\图片1.png");
        int i = 0;
        //创建随机对象
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //每隔一秒钟换一张图片
            i++;
            if (i==path.Length)
            {
                i = 0;
            }
            //随机产生图片
            pictureBox1.Image = Image.FromFile(path[r.Next(0,path.Length)]);
            pictureBox2.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox3.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox4.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox5.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox6.Image = Image.FromFile(path[r.Next(0, path.Length)]);

        }
    }
}
