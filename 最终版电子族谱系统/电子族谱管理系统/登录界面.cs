using Genealogy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 电子族谱管理系统
{
    public partial class 登录界面 : Form
    {
        public static 登录界面 form1;
        public 登录界面()
        {
            form1 = this;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str1 = 登录账号.Text;       //form里面有输入账号密码的文本框，这一步是获取其内容；
            String str2 = 登录密码.Text;
            String str3 = "select * FROM [User] WHERE User_ID='" + str1 + "'AND [key]='" + str2 + "'";   //编写sql语句，赋值给一个string变量，然后传给ExecuteQuery来执行；
            gene r1 = new gene();   //用来连接数据库的类gene，所以用其创建对象；
            DataTable d1 = new DataTable();   //因为查询是会有结果返回的，所以需要用DataTable的对象来承接返回的结果。
            d1 = r1.ExecuteQuery(str3);          //使用ExecuteQuery（）执行sql语句；
            if (d1 != null && d1.Rows.Count > 0)    //查询有结果
            {
                MessageBox.Show("欢迎使用！\n登录成功！", "欢迎进入",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Form 登录 = new 管理界面();     //这三行代码是实现界面跳转；
                Hide();
                登录.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！\n请重新输入！", "错误",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void 注册1_Click(object sender, EventArgs e)
        {
            注册界面 注册1 = new 注册界面();
            注册1.Show();
        }

        private void 登录界面_Load(object sender, EventArgs e)
        {

        }
    }
    public static class Config
    {
        public static string value = null;
    }
} 
