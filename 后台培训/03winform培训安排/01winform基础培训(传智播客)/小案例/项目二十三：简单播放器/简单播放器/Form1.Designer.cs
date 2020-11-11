namespace 简单播放器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MusicPlaer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpOldVersion = new System.Windows.Forms.GroupBox();
            this.btnPlayorPause = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.listFile = new System.Windows.Forms.ListBox();
            this.cmsFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnPutorStop = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblShowlyrics = new System.Windows.Forms.Label();
            this.lbllyrics_1 = new System.Windows.Forms.Label();
            this.lbllyrics_2 = new System.Windows.Forms.Label();
            this.lbllyrics_3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlaer)).BeginInit();
            this.grpOldVersion.SuspendLayout();
            this.cmsFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // MusicPlaer
            // 
            this.MusicPlaer.Enabled = true;
            this.MusicPlaer.Location = new System.Drawing.Point(12, 12);
            this.MusicPlaer.Name = "MusicPlaer";
            this.MusicPlaer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlaer.OcxState")));
            this.MusicPlaer.Size = new System.Drawing.Size(597, 282);
            this.MusicPlaer.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(15, 26);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(83, 30);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(15, 69);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(83, 30);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(15, 112);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(83, 30);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grpOldVersion
            // 
            this.grpOldVersion.Controls.Add(this.btnPlay);
            this.grpOldVersion.Controls.Add(this.btnStop);
            this.grpOldVersion.Controls.Add(this.btnPause);
            this.grpOldVersion.Location = new System.Drawing.Point(639, 12);
            this.grpOldVersion.Name = "grpOldVersion";
            this.grpOldVersion.Size = new System.Drawing.Size(120, 153);
            this.grpOldVersion.TabIndex = 4;
            this.grpOldVersion.TabStop = false;
            this.grpOldVersion.Text = "老版本播放器";
            // 
            // btnPlayorPause
            // 
            this.btnPlayorPause.Location = new System.Drawing.Point(100, 307);
            this.btnPlayorPause.Name = "btnPlayorPause";
            this.btnPlayorPause.Size = new System.Drawing.Size(83, 29);
            this.btnPlayorPause.TabIndex = 5;
            this.btnPlayorPause.Text = "播放";
            this.btnPlayorPause.UseVisualStyleBackColor = true;
            this.btnPlayorPause.Click += new System.EventHandler(this.btnPlayorPause_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(654, 189);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(83, 29);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // listFile
            // 
            this.listFile.ContextMenuStrip = this.cmsFile;
            this.listFile.FormattingEnabled = true;
            this.listFile.ItemHeight = 20;
            this.listFile.Location = new System.Drawing.Point(765, 12);
            this.listFile.Name = "listFile";
            this.listFile.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listFile.Size = new System.Drawing.Size(150, 324);
            this.listFile.TabIndex = 7;
            this.listFile.DoubleClick += new System.EventHandler(this.listFile_DoubleClick);
            // 
            // cmsFile
            // 
            this.cmsFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.cmsFile.Name = "cmsFile";
            this.cmsFile.Size = new System.Drawing.Size(109, 28);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(11, 307);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(83, 29);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "上一曲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(189, 307);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(83, 29);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "下一曲";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnPutorStop
            // 
            this.btnPutorStop.Location = new System.Drawing.Point(278, 307);
            this.btnPutorStop.Name = "btnPutorStop";
            this.btnPutorStop.Size = new System.Drawing.Size(83, 29);
            this.btnPutorStop.TabIndex = 11;
            this.btnPutorStop.Text = "放音";
            this.btnPutorStop.UseVisualStyleBackColor = true;
            this.btnPutorStop.Click += new System.EventHandler(this.btnPutorStop_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(367, 307);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(83, 29);
            this.btnCut.TabIndex = 12;
            this.btnCut.Text = "减小音量";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(456, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "增大音量";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(650, 242);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(69, 20);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "显示时间\r\n";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblShowlyrics
            // 
            this.lblShowlyrics.AutoSize = true;
            this.lblShowlyrics.Location = new System.Drawing.Point(203, 349);
            this.lblShowlyrics.Name = "lblShowlyrics";
            this.lblShowlyrics.Size = new System.Drawing.Size(69, 20);
            this.lblShowlyrics.TabIndex = 15;
            this.lblShowlyrics.Text = "歌词显示";
            // 
            // lbllyrics_1
            // 
            this.lbllyrics_1.AutoSize = true;
            this.lbllyrics_1.Location = new System.Drawing.Point(61, 370);
            this.lbllyrics_1.Name = "lbllyrics_1";
            this.lbllyrics_1.Size = new System.Drawing.Size(48, 20);
            this.lbllyrics_1.TabIndex = 15;
            this.lbllyrics_1.Text = "歌词1";
            // 
            // lbllyrics_2
            // 
            this.lbllyrics_2.AutoSize = true;
            this.lbllyrics_2.Location = new System.Drawing.Point(336, 392);
            this.lbllyrics_2.Name = "lbllyrics_2";
            this.lbllyrics_2.Size = new System.Drawing.Size(48, 20);
            this.lbllyrics_2.TabIndex = 15;
            this.lbllyrics_2.Text = "歌词2";
            // 
            // lbllyrics_3
            // 
            this.lbllyrics_3.AutoSize = true;
            this.lbllyrics_3.Location = new System.Drawing.Point(207, 390);
            this.lbllyrics_3.Name = "lbllyrics_3";
            this.lbllyrics_3.Size = new System.Drawing.Size(48, 20);
            this.lbllyrics_3.TabIndex = 16;
            this.lbllyrics_3.Text = "歌词3";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 421);
            this.Controls.Add(this.lbllyrics_3);
            this.Controls.Add(this.lbllyrics_2);
            this.Controls.Add(this.lbllyrics_1);
            this.Controls.Add(this.lblShowlyrics);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnPutorStop);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnPlayorPause);
            this.Controls.Add(this.grpOldVersion);
            this.Controls.Add(this.MusicPlaer);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "简单播放器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlaer)).EndInit();
            this.grpOldVersion.ResumeLayout(false);
            this.cmsFile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MusicPlaer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpOldVersion;
        private System.Windows.Forms.Button btnPlayorPause;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.ContextMenuStrip cmsFile;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button btnPutorStop;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblShowlyrics;
        private System.Windows.Forms.Label lbllyrics_1;
        private System.Windows.Forms.Label lbllyrics_2;
        private System.Windows.Forms.Label lbllyrics_3;
        private System.Windows.Forms.Timer timer2;
    }
}

