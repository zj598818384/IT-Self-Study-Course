using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 字体和颜色对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //【字体按钮】的单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            textBox1.Font = fd.Font;
        }
        //【颜色按钮】的单击事件
        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd=new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }
    }
}
