using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 进度条的实际操作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //【读取数据库信息按钮】的单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            //链接数据库
            string cs = "Server=.;Integrated Security=SSPI;DataBase=E_Market";
            //数据库连接字符串
            SqlConnection con = new SqlConnection(cs);
            //数据库查询字符串
            string sql = "select * from 商品信息表";
            //定义sqlCommand对象，命名为cmd
            SqlCommand cmd = new SqlCommand(sql,con);
            //定义sqlDataAdapter对象，命名为adp
            SqlDataAdapter adp = new SqlDataAdapter();
            //将sql查询命令结果缓冲至sqlDataAdapter对象
            adp.SelectCommand = cmd;
            //定义dataSet对象，命名为ds
            DataSet ds = new DataSet();
            //将缓冲至SqlDataAdapter对象的数据填充至DataSet对象，进行离线数据处理
            adp.Fill(ds);
            //释放数据库控件属性
            con.Dispose();
            con.Close();
            con = null;
            label1.Visible = true;
            //设置进度条控件属性
            progressBar1.Visible = true;//进度条控件可见
            progressBar1.Minimum = 0;//进度条控件的最小值为0
            progressBar1.Maximum = ds.Tables[0].Rows.Count;//进度条控件最大值为读取表内容行数
            progressBar1.BackColor = Color.Blue;//进度条控件的背景色为红色
            //循环读取数据表内容，读取次数为表内容行数
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //每次读取数据表，进度条值加1
                progressBar1.Value++;
                //当前程序处理消息队列内容
                Application.DoEvents();
                //将进度条当前值显示在标签控件
                this.label1.Text = progressBar1.Value.ToString();
            }
        }
    }
}
