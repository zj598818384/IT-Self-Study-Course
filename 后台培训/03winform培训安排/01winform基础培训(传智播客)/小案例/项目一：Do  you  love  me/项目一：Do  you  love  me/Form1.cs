using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 项目一_Do__you__love__me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当鼠标进入按钮的课件部分的时候，给按钮一个新的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你呦");
            this.Close();//关闭主窗体
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还是被你这个屌丝点到了");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //给按钮一个新的坐标
            //这个按钮活动的最大宽度就是窗体的宽度减去按钮的宽度
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Height;
            Random r = new Random();
            //要给按钮一个随机的坐标
            button2.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
        }
    }
}
