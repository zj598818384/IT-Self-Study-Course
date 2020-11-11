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

namespace ListBox图片点击更换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //用来存储图片文件的全路径
        List<string> list = new List<string>();
        //窗体加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] path = Directory.GetFiles(@"C:\Users\59881\Desktop\picture", "*.jpg");
            for (int i = 0; i < path.Length; i++)
            {
                string fileName=Path.GetFileName(path[i]);
                listBox1.Items.Add(fileName);
                //将图片的全路径添加到List泛型集合中
                list.Add(path[i]);
                //listBox1.Items.Add(path[i]);
            }
        }
        //双击播放图片
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(list[listBox1.SelectedIndex]);
        }
    }
}
