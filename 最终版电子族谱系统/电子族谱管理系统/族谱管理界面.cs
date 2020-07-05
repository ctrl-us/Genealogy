using Genealogy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 电子族谱管理系统
{
    public partial class 族谱管理界面 : Form
    {
        public 族谱管理界面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str1 = 族谱号.Text;       //form里面有输入账号密码的文本框，这一步是获取其内容；
            String str2 = 家族姓氏.Text;
            String str3 = 族长.Text;
            String str4 = 族谱简介.Text;
            String str5 = "insert into Genealogy values('" + str1 + "','" + str2 + "','" + str3 + "','" + str4 + "')";   //编写sql语句，赋值给一个string变量，然后传给ExecuteQuery来执行；
            gene r2 = new gene();   //用来连接数据库的类gene，所以用其创建对象；
            int d2 = r2.ExecuteUpdate(str5);   //执行后会有返回值，是int类型，如果执行失败会返回0；
            if (d2 != 0)
            {
                MessageBox.Show("新建成功！", "新建结果",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("信息错误，\n请重新输入！", "新建结果",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String str1 = xiugai族谱号.Text;       //form里面有输入账号密码的文本框，这一步是获取其内容；
            String str2 = 家族姓氏.Text;
            String str3 = 族长.Text;
            String str4 = 族谱简介.Text;
            String str5 = "UPDATE Genealogy SET Last_name='" + str2 + "',patriarch='" + str3 + "',introduction='" + str4 + "' WHERE genealogy_ID='" + str1 + "'";   //编写sql语句，赋值给一个string变量，然后传给ExecuteQuery来执行；
            gene r2 = new gene();   //用来连接数据库的类gene，所以用其创建对象；
            int d2 = r2.ExecuteUpdate(str5);   //执行后会有返回值，是int类型，如果执行失败会返回0；
            if (d2 != 0)
            {
                MessageBox.Show("修改成功！", "修改结果",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("信息错误，\n请重新输入！", "修改结果",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String str1 = shanchu族谱.Text;
            String str2 = "DELETE FROM [Genealogy] WHERE Genealogy_ID = '"+str1+"'";
            gene r2 = new gene();   //用来连接数据库的类gene，所以用其创建对象；
            int d2 = r2.ExecuteUpdate(str2);   //执行后会有返回值，是int类型，如果执行失败会返回0；
            if (d2 != 0)
            {
                MessageBox.Show("确认删除族谱吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("删除错误!\n", "删除结果",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void 族谱号_TextChanged(object sender, EventArgs e)
        {

        }

        private void 修改族谱_Click(object sender, EventArgs e)
        {
            
        }

        private void 族谱号2_TextChanged(object sender, EventArgs e)
        {

        }

        private void 删除族谱_Click(object sender, EventArgs e)
        {
         
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            String str1 =登录界面.form1.登录账号.Text;
            String str2 = "select Genealogy_ID from [User] WHERE User_ID='" + str1 + "'";
            gene r1 = new gene();   //用来连接数据库的类gene，所以用其创建对象；
            DataTable d1 = new DataTable();   //因为查询是会有结果返回的，所以需要用DataTable的对象来承接返回的结果。
            d1 = r1.ExecuteQuery(str2);          //使用ExecuteQuery（）执行sql语句；
            if (d1 != null && d1.Rows.Count > 0)
            {
                xiugai族谱号.Text = d1.Rows[0][0].ToString();   //查询结果
                shanchu族谱.Text = d1.Rows[0][0].ToString();    //查询结果
            }
        }
        private void quxiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quxiao2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quxiao3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 族谱管理界面_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            String str1 = 登录界面.form1.登录账号.Text;
            String str2 = "select Genealogy_ID from [User] WHERE User_ID='" + str1 + "'";
            gene r1 = new gene();   //用来连接数据库的类gene，所以用其创建对象；
            DataTable d1 = new DataTable();   //因为查询是会有结果返回的，所以需要用DataTable的对象来承接返回的结果。
            d1 = r1.ExecuteQuery(str2);          //使用ExecuteQuery（）执行sql语句；
            if (d1 != null && d1.Rows.Count > 0)
            {
                xiugai族谱号.Text = d1.Rows[0]["Genealogy_ID"].ToString();   //查询结果
                shanchu族谱.Text = d1.Rows[0]["Genealogy_ID"].ToString();    //查询结果
            }
        }

        string Genealogy_ID = null;
        private void InitTree1()
        {
            string str = @"Data Source=DESKTOP-9BINEI3\XS;Initial Catalog=电子族谱数据库;Persist Security Info=True;User ID=sa;Password=233323";
            SqlConnection conn = new SqlConnection(str);
            if (conn.State != ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
            @" Select num,name From Member where num like '1' and Genealogy_ID='" + Genealogy_ID + "'";
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                TreeNode tchild = new TreeNode();
                tchild.Name = sdr["num"].ToString();
                tchild.Text = sdr["name"].ToString();
                LoadAll2(sdr["num"].ToString(), tchild);
                this.treeView1.Nodes.Add(tchild);
            }

        }
        //加载所属节点
        public void LoadAll2(string num, TreeNode tn)
        {
            string str = @"Data Source=DESKTOP-9BINEI3\XS;Initial Catalog=电子族谱数据库;Persist Security Info=True;User ID=sa;Password=233323";
            SqlConnection conn = new SqlConnection(str);
            if (conn.State != ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            SqlCommand cmd = conn.CreateCommand();
            //限定查询位数 如果部门很多 需要2位 那么就需要2个占位符（下划线）
            num = num + "_";
            //通过通配符查询
            cmd.CommandText = @" Select name,num From Member where num like '" + num + "'and Genealogy_ID='" + Genealogy_ID + "'";
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                TreeNode tchild = new TreeNode();
                tchild.Name = sdr["num"].ToString();
                tchild.Text = sdr["name"].ToString();
                LoadAll2(sdr["num"].ToString(), tchild);//递归调用加载所属节点方法
                tn.Nodes.Add(tchild);//把当前节点加入到tn数的节点中
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                Genealogy_ID = textBox1.Text;
                InitTree1();
            }
        }
    }
}
