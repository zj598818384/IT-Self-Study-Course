namespace 学生或者老师登录
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.rdostudent = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoteacher = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(85, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(85, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(179, 69);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(158, 25);
            this.txtname.TabIndex = 2;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(178, 113);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(159, 25);
            this.txtpwd.TabIndex = 3;
            // 
            // rdostudent
            // 
            this.rdostudent.AutoSize = true;
            this.rdostudent.Location = new System.Drawing.Point(178, 171);
            this.rdostudent.Name = "rdostudent";
            this.rdostudent.Size = new System.Drawing.Size(58, 19);
            this.rdostudent.TabIndex = 4;
            this.rdostudent.TabStop = true;
            this.rdostudent.Text = "学生";
            this.rdostudent.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoteacher
            // 
            this.rdoteacher.AutoSize = true;
            this.rdoteacher.Location = new System.Drawing.Point(279, 171);
            this.rdoteacher.Name = "rdoteacher";
            this.rdoteacher.Size = new System.Drawing.Size(58, 19);
            this.rdoteacher.TabIndex = 6;
            this.rdoteacher.TabStop = true;
            this.rdoteacher.Text = "老师";
            this.rdoteacher.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 387);
            this.Controls.Add(this.rdoteacher);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdostudent);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.RadioButton rdostudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoteacher;
    }
}

