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
    public partial class 管理界面 : Form
    {
        public 管理界面()
        {
            InitializeComponent();
        }

        private void 族谱管理_Click(object sender, EventArgs e)
        {
            族谱管理界面 族谱管理 = new 族谱管理界面();
            族谱管理.Show();
        }

        private void 成员管理_Click(object sender, EventArgs e)
        {
            成员管理界面 成员管理 = new 成员管理界面();
            成员管理.Show();
        }

        private void 族谱管理_Click_1(object sender, EventArgs e)
        {
            族谱管理界面 族谱管理 = new 族谱管理界面();
            族谱管理.Show();
        }

        private void 查询管理_Click(object sender, EventArgs e)
        {
            查询管理界面 查询管理 = new 查询管理界面();
            查询管理.Show();
        }

        private void 成员管理_Click_1(object sender, EventArgs e)
        {
            成员管理界面 成员管理 = new 成员管理界面();
            成员管理.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否退出系统？","温馨提示",MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void 管理界面_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
