using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生或者老师登录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdostudent.Checked||rdoteacher.Checked)
            {
                string name = txtname.Text.Trim();
                string pwd = txtpwd.Text;
                if (rdostudent.Checked)
                {
                    if (name == "student" && pwd == "student")
                    {
                        MessageBox.Show("学生登录成功!", "登录信息");
                    }
                    else
                    {
                        MessageBox.Show("登录失败!", "登录信息");
                        txtname.Clear();
                        txtpwd.Clear();
                        txtname.Focus();
                    }
                }
                else//选择的是老师
                {
                    if (name == "teacher" && pwd == "teacher")
                    {
                        MessageBox.Show("老师登录成功", "登录信息");
                    }
                    else
                    {
                        MessageBox.Show("登录失败!", "登录信息");
                        txtname.Clear();
                        txtpwd.Clear();
                        txtname.Focus();
                    }
                }
            }
            else//都没有选择
            {
                MessageBox.Show("请首先选择登录身份!","登录信息");
            }
            
        }
    }
}
