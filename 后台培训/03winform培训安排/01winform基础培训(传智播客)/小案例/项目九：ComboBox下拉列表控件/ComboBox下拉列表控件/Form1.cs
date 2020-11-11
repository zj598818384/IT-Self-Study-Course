using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox下拉列表控件
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
            //获得当前年份
            int year = DateTime.Now.Year;
            for (int i =year; i >1949; i--)
            {
                comboBox1.Items.Add(i+"年");
            }
        }
        //当Combobox1里面的值的索引发生改变时，加载月份
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i+"月");
            }
        }
        //当Combobox2里面的值的索引发生改变时，加载天数
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            int day = 0;//定义一个变量来存储天数
            //获得月份
            string strMonth = comboBox2.SelectedItem.ToString().Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0];
            string strYear = comboBox1.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];
            int year = Convert.ToInt32(strYear);
            int month = Convert.ToInt32(strMonth);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    if ((year%400==0)||(year%4==0&&year%100!=0))
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default:
                    day = 30;
                    break;
            }
            // MessageBox.Show(comboBox3.SelectedItem.ToString());

            for (int i = 1; i <= day; i++)
            {
                comboBox3.Items.Add(i+"日");
            }
        }
    }
}
