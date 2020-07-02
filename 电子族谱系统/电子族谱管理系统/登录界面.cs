using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 电子族谱管理系统
{
    public partial class 登录界面 : Form
    {
        public 登录界面()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            管理界面 登录 = new 管理界面();
            登录.Show();
            MessageBox.Show("登录成功！","温馨提示");
            
        }

        private void 注册1_Click(object sender, EventArgs e)
        {
            注册界面 注册1 = new 注册界面();
            注册1.Show();
        }
    }
} 
