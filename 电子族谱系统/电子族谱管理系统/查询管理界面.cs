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
    public partial class 查询管理界面 : Form
    {
        public 查询管理界面()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确认退出吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确认退出吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            查询成员 成员 = new 查询成员();
            成员.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            查询后代 后代 = new 查询后代();
            后代.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
