using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 练习21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //【窗体加载事件】
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbYunSuanFu.SelectedIndex = 0;
        }

        //【等于按钮的】单击事件
        private void btnDengyu_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(txtNum1.Text.Trim());
                int n2 = Convert.ToInt32(txtNum2.Text.Trim());
                string oper = cmbYunSuanFu.SelectedItem.ToString();
                switch (oper)
                {
                    case "+":
                        lblNum3.Text = (n1 + n2).ToString();
                        break;
                    case "-":
                        lblNum3.Text = (n1 - n2).ToString();
                        break;
                    case "*":
                        lblNum3.Text = (n1 * n2).ToString();
                        break;
                    case "/":
                        lblNum3.Text = (n1 / n2).ToString();
                        break;
                    default:
                        MessageBox.Show("请选择正确的操作符");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的数字");
            }
        }
    }
}
