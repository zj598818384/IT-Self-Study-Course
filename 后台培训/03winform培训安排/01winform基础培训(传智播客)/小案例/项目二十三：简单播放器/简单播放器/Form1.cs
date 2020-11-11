using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 简单播放器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //【播放按钮的单击事件】
        private void btnPlay_Click(object sender, EventArgs e)
        {
            MusicPlaer.Ctlcontrols.play();
        }

        //【暂停按钮的单击事件】
        private void btnPause_Click(object sender, EventArgs e)
        {
            MusicPlaer.Ctlcontrols.pause();
        }

        //【停止按钮的单击事件】
        private void btnStop_Click(object sender, EventArgs e)
        {
            MusicPlaer.Ctlcontrols.stop();
        }

        //【在程序加载的时候，取消播放器的自动播放功能】
        private void Form1_Load(object sender, EventArgs e)
        {
            MusicPlaer.settings.autoStart = false;
            //MusicPlaer.URL = @"C:\Users\59881\Desktop\黄金瞳音乐\我的小小世界.mp3";
        }

        //【播放或暂停按钮的单击事件】
        bool b = true;
        private void btnPlayorPause_Click(object sender, EventArgs e)
        {
            if (btnPlayorPause.Text=="播放")
            {
                if (b)
                {
                    //获得选中的歌曲,选中歌曲，不进行双击点击播放则能进行播放音乐
                    //让音乐从暂停的地方开始播放
                    MusicPlaer.URL = listPath[listFile.SelectedIndex];
                }
                MusicPlaer.Ctlcontrols.play();
                btnPlayorPause.Text = "暂停";
            }
            else if (btnPlayorPause.Text=="暂停")
            {
                MusicPlaer.Ctlcontrols.pause();
                btnPlayorPause.Text = "播放";
                b = false;
            }
        }

        //存储音乐文件的全路径
        List<string> listPath = new List<string>();

        //【打开按钮的单击事件】
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\59881\Desktop\黄金瞳音乐";
            ofd.Filter = "音乐文件|*.wav|mp3文件|*.mp3|所有文件|*.*";
            ofd.Title = "请选择音乐文件";
            ofd.Multiselect = true;
            ofd.ShowDialog();
            //获得在文本框中选择文件的全路径
            string[] path= ofd.FileNames;
            //遍历输出
            for (int i = 0; i < path.Length; i++)
            {
                //将音乐文件的全路径存储到泛型集合中
                listPath.Add(path[i]);
                //将音乐文件的文件名存储到listbox中
                listFile.Items.Add(Path.GetFileName(path[i]));
            }
        }

        //【双击播放音乐】
        private void listFile_DoubleClick(object sender, EventArgs e)
        {
            if (listFile.Items.Count==0)
            {
                MessageBox.Show("请首先选择音乐文件");
                return;
            }
            try
            {
                MusicPlaer.URL = listPath[listFile.SelectedIndex];
                MusicPlaer.Ctlcontrols.play();
                btnPlayorPause.Text = "暂停";
                //lblInfo.Text = MusicPlaer.currentMedia.duration.ToString();
                IsExistLrc(listPath[listFile.SelectedIndex]);
            }
            catch
            {
                MessageBox.Show("请先选择音乐文件");
            }
            
        }

        //【下一曲按钮的单击事件】
        private void btnDown_Click(object sender, EventArgs e)
        {
            //获得当前选中项的索引
            int index = listFile.SelectedIndex;
            //下一首
            index++;
            //如果下一首的索引等于所以歌曲的最长索引，就让index的索引为0
            if (index==listFile.Items.Count)
            {
                index = 0;
            }
            listFile.ClearSelected();
            //将改变后的索引重新的赋值给当前选中项的索引
            listFile.SelectedIndex = index;
            MusicPlaer.URL = listPath[index];
            MusicPlaer.Ctlcontrols.play();
        }

        //【上一曲按钮的单击事件】
        private void btnUp_Click(object sender, EventArgs e)
        {
            //获得当前选中项的索引
            int index = listFile.SelectedIndex;
            //清空所有选中项的索引
            //listFile.SelectedIndices.Clear();
            //上一首
            index--;
            //如果上一首的索引等于所有歌曲的最起始的索引，就让index的索引为最长索引
            if (index<0)
            {
                //选中最后一个
                index = listFile.Items.Count-1;
            }
            //清空所有选中项的索引
            listFile.ClearSelected();
            //将改变后的索引重新的赋值给当前选中项的索引
            listFile.SelectedIndex = index;
            //找到路径的全路径赋值给URL
            MusicPlaer.URL = listPath[index];
            MusicPlaer.Ctlcontrols.play();
        }

        //【listfile中右键删除选项的单击事件】
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //首先获得要删除的歌曲的数量 
            int count = listFile.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                //先删集合
                //删除集合里面的元素按索引
                listPath.RemoveAt(listFile.SelectedIndex);
                //在删列表
                listFile.Items.RemoveAt(listFile.SelectedIndex);
            }
        }

        //【放音或静音按钮的单击事件】
        private void btnPutorStop_Click(object sender, EventArgs e)
        {
            if (btnPutorStop.Text=="放音")
            {
                //放音
                //目的：让你静音
                MusicPlaer.settings.mute = true;
                btnPutorStop.Text = "静音";
            }
            else if(btnPutorStop.Text=="静音")
            {
                //静音
                //目的：让你放音
                MusicPlaer.settings.mute = false;
                btnPutorStop.Text = "放音";
            }
        }

        //【减小音量按钮的单击事件】
        private void btnCut_Click(object sender, EventArgs e)
        {
            //设置音量的大小
            MusicPlaer.settings.volume -= 10;
        }

        //【增大音量按钮的单击事件】
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MusicPlaer.settings.volume += 10;
        }

        //自动播放下一曲
        private void timer1_Tick(object sender, EventArgs e)
        {
            //如果播放器的状态等于正在播放中
            if (MusicPlaer.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                lblInfo.Text = MusicPlaer.currentMedia.durationString + "  " + MusicPlaer.Ctlcontrols.currentPositionString;
                double d1 = double.Parse(MusicPlaer.currentMedia.duration.ToString());
                double d2 = double.Parse(MusicPlaer.Ctlcontrols.currentPosition.ToString())+1;
                //如果歌曲播放的总时间等于歌曲的总时间
                if (d1 <=d2)
                {
                    //获得当前选中项的索引
                    int index = listFile.SelectedIndex;
                    //下一首
                    index++;
                    //如果下一首的索引等于所以歌曲的最长索引，就让index的索引为0
                    if (index == listFile.Items.Count)
                    {
                        index = 0;
                    }
                    listFile.ClearSelected();
                    //将改变后的索引重新的赋值给当前选中项的索引
                    listFile.SelectedIndex = index;
                    MusicPlaer.URL = listPath[index];
                    MusicPlaer.Ctlcontrols.play();
                }
            }
        }

        void IsExistLrc(string songPath)
        {
            //清空两个集合
            listtime.Clear();
            listLrcText.Clear();
            songPath += ".lrc";
            //存在歌词文件
            if (File.Exists(songPath))
            {
                //读取歌词文件
                string[] lrcText=File.ReadAllLines(songPath,Encoding.Default);
                //格式化歌词
                FormatLrc(lrcText);
            }
            //不存在歌词文件
            else
            {
                lbllyrics_1.Text = "歌词未找到";
            }
        }
        //存储时间
        List<double> listtime = new List<double>();
        //存储歌词
        List<string> listLrcText = new List<string>();
        //格式化歌词
        void FormatLrc(string[] lrcText)
        {
            for (int i = 0; i < lrcText.Length; i++)
            {
                //第一行
                string[] lrcTemp= lrcText[i].Split(new char[] { '[',']'},StringSplitOptions.RemoveEmptyEntries);
                string[] lrcNewTemp= lrcTemp[0].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                double time= double.Parse(lrcNewTemp[0])*60+double.Parse(lrcNewTemp[1]);//返回总时间
                //把截取出来的时间加到泛型集合中
                listtime.Add(time);
                //把这个事件所对应的歌词存储到泛型集合中
            }
        }
        //播放歌词
        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listtime.Count; i++)
            {
                if (MusicPlaer.Ctlcontrols.currentPosition>=listtime[i]&&MusicPlaer.Ctlcontrols.currentPosition<listtime[i+1])
                {
                   lbllyrics_1.Text= listLrcText[i];
                }
            }
        }
    }
}
