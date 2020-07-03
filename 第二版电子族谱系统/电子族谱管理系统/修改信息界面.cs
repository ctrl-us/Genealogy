using Genealogy;
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
        public partial class 修改信息界面 : Form
    {
        public 修改信息界面()
        {
            InitializeComponent();
        }

        private void 修改_Click(object sender, EventArgs e)
        {
            String str1 = label.Text;       //form里面有输入账号密码的文本框，这一步是获取其内容；
            String str2 = 修改密码.Text;
            String str3 = 族谱号.Text;
            String str4 = "UPDATE [User] SET [key]='" + str2 + "',genealogy_ID='" + str3 + "' WHERE User_ID='" + str1 + "'";   //编写sql语句，赋值给一个string变量，然后传给ExecuteQuery来执行；
            gene r2 = new gene();   //用来连接数据库的类gene，所以用其创建对象；
            int d2 = r2.ExecuteUpdate(str4);   //执行后会有返回值，是int类型，如果执行失败会返回0；
            if (d2 != 0)
            {
                MessageBox.Show("修改成功！", "修改结果",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Form 登录 = new 登录界面();     //这两行代码是实现界面跳转；
                Hide();
            }
            else
            {
                MessageBox.Show("信息错误，\n请重新输入！", "修改结果",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void 修改信息界面_Load(object sender, EventArgs e)
        {
            label.Text = 登录界面.form1.登录账号.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 取消修改_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
