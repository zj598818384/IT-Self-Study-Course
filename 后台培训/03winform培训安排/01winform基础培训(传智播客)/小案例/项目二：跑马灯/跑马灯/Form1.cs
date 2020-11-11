using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 跑马灯
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 将文本框中的内容赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
        /// <summary>
        /// 每隔一秒钟的就把当前的时间赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
            //播放音乐叫我起床
            if (DateTime.Now.Hour==14&&DateTime.Now.Minute==15&&DateTime.Now.Second==00)
            {
                //播放音乐 
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"C:\Users\59881\Desktop\@滔滔吖-董小姐.wav";
                sp.Play();
            }
        }
        /// <summary>
        /// 当窗体加载的时候，将当前系统的时间赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text=label3.Text.Substring(1) + label3.Text.Substring(0, 1);
        }
    }
}
