namespace 电子族谱管理系统
{
    partial class 登录界面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登录界面));
            this.label1 = new System.Windows.Forms.Label();
            this.登录账号 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.登录密码 = new System.Windows.Forms.TextBox();
            this.注册1 = new System.Windows.Forms.Button();
            this.登录 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(157, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // 登录账号
            // 
            this.登录账号.Location = new System.Drawing.Point(269, 89);
            this.登录账号.Name = "登录账号";
            this.登录账号.Size = new System.Drawing.Size(195, 28);
            this.登录账号.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(157, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // 登录密码
            // 
            this.登录密码.Location = new System.Drawing.Point(269, 180);
            this.登录密码.Name = "登录密码";
            this.登录密码.Size = new System.Drawing.Size(195, 28);
            this.登录密码.TabIndex = 3;
            // 
            // 注册1
            // 
            this.注册1.BackColor = System.Drawing.Color.White;
            this.注册1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.注册1.Location = new System.Drawing.Point(191, 299);
            this.注册1.Name = "注册1";
            this.注册1.Size = new System.Drawing.Size(75, 35);
            this.注册1.TabIndex = 4;
            this.注册1.Text = "注册";
            this.注册1.UseVisualStyleBackColor = false;
            this.注册1.Click += new System.EventHandler(this.注册1_Click);
            // 
            // 登录
            // 
            this.登录.BackColor = System.Drawing.Color.White;
            this.登录.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.登录.Location = new System.Drawing.Point(365, 299);
            this.登录.Name = "登录";
            this.登录.Size = new System.Drawing.Size(75, 35);
            this.登录.TabIndex = 5;
            this.登录.Text = "登录";
            this.登录.UseVisualStyleBackColor = false;
            this.登录.Click += new System.EventHandler(this.button2_Click);
            // 
            // 登录界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.登录);
            this.Controls.Add(this.注册1);
            this.Controls.Add(this.登录密码);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.登录账号);
            this.Controls.Add(this.label1);
            this.Name = "登录界面";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 登录账号;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 登录密码;
        private System.Windows.Forms.Button 注册1;
        private System.Windows.Forms.Button 登录;
    }
}

