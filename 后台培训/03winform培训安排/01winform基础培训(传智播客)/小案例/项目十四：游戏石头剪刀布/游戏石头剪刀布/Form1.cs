using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 游戏石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //【石头按钮】的单击事件
        private void btnStone_Click(object sender, EventArgs e)
        {
            string str = "石头";
            IblPlayer.Text = str;
            //玩家显示
            Player player = new Player();
            int playerNumber = player.ShowFist(str);
            //电脑显示
            Computer cpu = new Computer();
            int cpuNumber = cpu.ShowFist();
            lblComputer.Text = cpu.Fist;
            //裁判显示
           Result res= Caipan.Judge(playerNumber,cpuNumber);
            lblResult.Text = res.ToString();
        }
        //【剪刀按钮】的单击事件
        private void btnCut_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            IblPlayer.Text = str;
            //玩家显示
            Player player = new Player();
            int playerNumber = player.ShowFist(str);
            //电脑显示
            Computer cpu = new Computer();
            int cpuNumber = cpu.ShowFist();
            lblComputer.Text = cpu.Fist;
            //裁判显示
            Result res = Caipan.Judge(playerNumber,cpuNumber);
            lblResult.Text = res.ToString();
        }
        //【布按钮】的单击事件
        private void btnNo_Click(object sender, EventArgs e)
        {
            string str = "布";
            IblPlayer.Text = str;
            //玩家显示
            Player player = new Player();
            int playerNumber = player.ShowFist(str);
            //电脑显示
            Computer cpu = new Computer();
            int cpuNumber = cpu.ShowFist();
            lblComputer.Text = cpu.Fist;
            //裁判显示
            Result res = Caipan.Judge(playerNumber,cpuNumber);
            lblResult.Text = res.ToString();
        }
    }
}
