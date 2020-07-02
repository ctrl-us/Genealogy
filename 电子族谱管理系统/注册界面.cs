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
    public partial class 注册界面 : Form
    {
        public 注册界面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str1 = 注册账号.Text;       //form里面有输入账号密码的文本框，这一步是获取其内容；
            String str2 = 注册密码.Text;
            String str3 = 族谱号.Text;
            String str4 = null;
            if(str3.Length == 0)
            { 
                str4 = "insert into [User] values('" + str1 + "','" + str2 + "',NULL)";   
            }
            else
            {
                str4=  "insert into [User] values('" + str1 + "','" + str2 + "','" + str3 + "')";
            }
            gene r2 = new gene();   //用来连接数据库的类gene，所以用其创建对象；
            int d2 = r2.ExecuteUpdate(str4);   //执行后会有返回值，是int类型，如果执行失败会返回0；
            if (d2 != 0 )    
            {
                MessageBox.Show("注册成功！", "添加结果",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Form 登录 = new 登录界面();     //这两行代码是实现界面跳转；
                Hide();
            }
            else
            {
                MessageBox.Show("信息错误，\n请重新输入！", "添加结果",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
