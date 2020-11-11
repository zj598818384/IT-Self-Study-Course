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

namespace 简单记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.Trim();
            string pwd = textBox3.Text;
            if (name == "" && pwd == "")
            {
                MessageBox.Show("你什么也不记得就来登录账号？好好想想吧", "登录提示");
                textBox2.Focus();
                return;
            }
            else if (name == "")
            {
                MessageBox.Show("你为什么不记得账号了？", "登录提示");
                textBox2.Clear();
                textBox3.Clear();
                //让文本框获得焦点
                textBox2.Focus();
                return;
            }
            else if (pwd == "")
            {
                MessageBox.Show("你为什么不记得密码了？", "登录提示");
                textBox2.Focus();
                textBox2.Clear();
                textBox3.Clear();
                return;
            }
            else if (name == "5"&&pwd!="s")
            {
                MessageBox.Show("账号错啦，再想想账号吧", "登录提示");
                textBox2.Clear();
                textBox3.Clear();
                //让文本框获得焦点
                textBox2.Focus();
                return;
            }
            else if (name != "5" && pwd == "s")
            {
                MessageBox.Show("密码错啦，再想想密码吧", "登录提示");
                textBox2.Clear();
                textBox3.Clear();
                textBox2.Focus();
                return;
            }
            else if (name != "5" && pwd != "s")
            {
                MessageBox.Show("密码和账号都错了！真的不记得了吗？", "登录提示");
                textBox2.Clear();
                textBox3.Clear();
                //让文本框获得焦点
                textBox2.Focus();
                return;
            }
            else
            {
                MessageBox.Show("谢天谢地，你终于想起来了", "登录提示");
                textBox1.WordWrap = true;
                button1.Visible = true;
                button2.Visible = true;
                textBox1.Visible = true;

                label1.Visible = false;
                label2.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.WordWrap = false;
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
        }
        /// <summary>
        /// 自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //当前是否是自动换行
            //textBox1.WordWrap = true;
            //取消自动换行
            if (button1.Text=="自动换行")
            {
                //取消自动换行
                textBox1.WordWrap = true;
                button1.Text = "取消自动换行";
            }
            else if (button1.Text=="取消自动换行")
            {
                textBox1.WordWrap = false;
                button1.Text = "自动换行";
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            using (FileStream fswrite = new FileStream(@"C: \Users\59881\Desktop\newnew.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = textBox1.Text.Trim();
                byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
                fswrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }
    }
}
