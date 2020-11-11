namespace 练习21
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.cmbYunSuanFu = new System.Windows.Forms.ComboBox();
            this.btnDengyu = new System.Windows.Forms.Button();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 31);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(93, 27);
            this.txtNum1.TabIndex = 0;
            // 
            // cmbYunSuanFu
            // 
            this.cmbYunSuanFu.FormattingEnabled = true;
            this.cmbYunSuanFu.Items.AddRange(new object[] {
            "请选择操作符",
            "+",
            "-",
            "*",
            "/"});
            this.cmbYunSuanFu.Location = new System.Drawing.Point(111, 30);
            this.cmbYunSuanFu.Name = "cmbYunSuanFu";
            this.cmbYunSuanFu.Size = new System.Drawing.Size(119, 28);
            this.cmbYunSuanFu.TabIndex = 1;
            // 
            // btnDengyu
            // 
            this.btnDengyu.Location = new System.Drawing.Point(353, 29);
            this.btnDengyu.Name = "btnDengyu";
            this.btnDengyu.Size = new System.Drawing.Size(75, 28);
            this.btnDengyu.TabIndex = 2;
            this.btnDengyu.Text = "=";
            this.btnDengyu.UseVisualStyleBackColor = true;
            this.btnDengyu.Click += new System.EventHandler(this.btnDengyu_Click);
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.Location = new System.Drawing.Point(450, 33);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(53, 20);
            this.lblNum3.TabIndex = 3;
            this.lblNum3.Text = "label1";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(248, 30);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(81, 27);
            this.txtNum2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 87);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.btnDengyu);
            this.Controls.Add(this.cmbYunSuanFu);
            this.Controls.Add(this.txtNum1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "简易计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.ComboBox cmbYunSuanFu;
        private System.Windows.Forms.Button btnDengyu;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.TextBox txtNum2;
    }
}

