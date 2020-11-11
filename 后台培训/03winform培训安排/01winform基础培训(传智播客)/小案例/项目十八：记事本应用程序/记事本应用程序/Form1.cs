using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //窗体加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            //加载程序的时候，隐藏panel
            panel1.Visible = false;
            //取消文本框的自动换行功能
            textBox1.WordWrap = false;
        }
        /// <summary>
        /// 点击按钮的是时候，隐藏panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        //显示panel
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        List<string> list = new List<string>();
        //打开对话框
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建打开文件的对象
            OpenFileDialog ofd = new OpenFileDialog();
            //设置打开文件的标题
            ofd.Title = "请选择你要打开的文本文件";
            //设置文件的初始路径
            ofd.InitialDirectory = @"C:\Users\59881\Desktop";
            //设置是否可多选文件
            ofd.Multiselect = true;
            //设置可选的文件类型
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            //显示打开文件的对话框
            ofd.ShowDialog();

            //获得用户选中的文件的路径
            string path = ofd.FileName;
            //将文件的全路径存储到泛型集合中
            list.Add(path);
            //获得了用户打开文件的文件名
            string fileName = Path.GetFileName(path);
            //将文件名放到ListBox中
            listBox1.Items.Add(fileName);
            if (path=="")
            {
                return;
            }
            using (FileStream fsRead=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024*5];
                int r = fsRead.Read(buffer,0,buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer,0,0);
            }
        }
        /// <summary>
        /// 保存对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\Users\59881\Desktop";
            sfd.Title = "请选择要保存的的文件路径";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.ShowDialog();

            //获得用户要保存的文件的路径
            string path = sfd.FileName;
            if (path=="")
            {
                return;
            }
            using (FileStream fsWirte=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fsWirte.Write(buffer,0,buffer.Length);
            }
            MessageBox.Show("保存成功");
        }
        //【自动换行】
        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Text=="自动换行")
            {
                textBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "取消自动换行";
            }
            else if (自动换行ToolStripMenuItem.Text=="取消自动换行")
            {
                textBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "自动换行";
            }
        }
        //【字体】
        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            textBox1.Font = fd.Font;
        }
        //【颜色】
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }
        /// <summary>
        /// 双击打开对应的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //要获得双击的所对应的全路径
            string path = list[listBox1.SelectedIndex];
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024*5];
                int r = fsRead.Read(buffer,0,buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);
            }
        }
    }
}
