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

namespace 打开对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //【选择文件按钮】的单击事件
        //点击弹出对话框
        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog——打开文件对话框
            //SaveFileDialog——保存文件对话框
            //FontDialog——字体对话框
            //ColorDialog——颜色对话框

            //点击打开对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //设置对话框的标题
            ofd.Title = "请选择你需要的文本文件";
            //设置对话框可以多选
            ofd.Multiselect = true;
            //设置对话框的初始目录
            ofd.InitialDirectory = @"C:\Users\59881\Desktop";
            //设置打开文件的类型
            ofd.Filter = "文本文件|*.txt|媒体文件|*.wmv|图片文件|*.jpg|所有文件|*.*";
            //展示对话框
            ofd.ShowDialog();

            //获得在打开对话框中选中文件的路径
            string path=ofd.FileName;
            if (path=="")
            {
                return;
            }
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024*5];
                //实际读取到的字节数
                int r = fsRead.Read(buffer,0,buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer,0,buffer.Length);
            }
        }
    }
}
