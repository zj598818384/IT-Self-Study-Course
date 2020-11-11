namespace 使用GDI绘制简单图形
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
            this.btnBeeline = new System.Windows.Forms.Button();
            this.lblShu = new System.Windows.Forms.Label();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnSector = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBeeline
            // 
            this.btnBeeline.Location = new System.Drawing.Point(352, 12);
            this.btnBeeline.Name = "btnBeeline";
            this.btnBeeline.Size = new System.Drawing.Size(137, 33);
            this.btnBeeline.TabIndex = 0;
            this.btnBeeline.Text = "绘制一条直线";
            this.btnBeeline.UseVisualStyleBackColor = true;
            this.btnBeeline.Click += new System.EventHandler(this.btnHuiZhi_Click);
            // 
            // lblShu
            // 
            this.lblShu.AutoSize = true;
            this.lblShu.Location = new System.Drawing.Point(562, 67);
            this.lblShu.Name = "lblShu";
            this.lblShu.Size = new System.Drawing.Size(53, 20);
            this.lblShu.TabIndex = 1;
            this.lblShu.Text = "label1";
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(182, 12);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(137, 33);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "绘制一个矩形";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnSector
            // 
            this.btnSector.Location = new System.Drawing.Point(12, 12);
            this.btnSector.Name = "btnSector";
            this.btnSector.Size = new System.Drawing.Size(137, 33);
            this.btnSector.TabIndex = 3;
            this.btnSector.Text = "绘制一个扇形";
            this.btnSector.UseVisualStyleBackColor = true;
            this.btnSector.Click += new System.EventHandler(this.btnSector_Click);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(518, 12);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(137, 33);
            this.btnText.TabIndex = 4;
            this.btnText.Text = "绘制一个文本";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 392);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnSector);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.lblShu);
            this.Controls.Add(this.btnBeeline);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "使用GDI绘制简单图形";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeeline;
        private System.Windows.Forms.Label lblShu;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnSector;
        private System.Windows.Forms.Button btnText;
    }
}

