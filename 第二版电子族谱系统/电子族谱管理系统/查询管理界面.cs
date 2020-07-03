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

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void textspouse_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            String str1 = textinput.Text;
            String str2 = "SELECT Member_ID,Father_ID,Genealogy_ID,name,sex,birth,death,birthplace,address,spouse_name,spouse_state,number  FROM [Member] WHERE Member_ID='" + str1 + "'";
            gene r1 = new gene();   //我写的那个用来连接数据库的类是ResM，所以用其创建对象；
            DataTable d1 = new DataTable();   //因为查询是会有结果返回的，所以需要用DataTable的对象来承接返回的结果。
            d1 = r1.ExecuteQuery(str2);
            if (d1 != null && d1.Rows.Count > 0)
            {
                text成员ID.Text = d1.Rows[0]["Member_ID"].ToString();   //查询结果
                text族谱ID.Text = d1.Rows[0]["Genealogy_ID"].ToString();
                text父亲ID.Text = d1.Rows[0]["Father_ID"].ToString();
                text姓名.Text = d1.Rows[0]["name"].ToString();
                sex1.Text = d1.Rows[0]["sex"].ToString();
                text世代.Text = d1.Rows[0]["number"].ToString();
                dateTimebirth.Text = d1.Rows[0]["birth"].ToString();
                dateTimedeath.Text = d1.Rows[0]["death"].ToString();
                textplace.Text = d1.Rows[0]["birthplace"].ToString();
                textaddress.Text = d1.Rows[0]["address"].ToString();
                spouse_name.Text = d1.Rows[0]["spouse_name"].ToString();
                spouse_state.Text = d1.Rows[0]["spouse_state"].ToString();
            }
            else
            {
                MessageBox.Show("查不到此成员，请重新输入成员ID", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String str1 = Father.Text;
            String str2 = "SELECT Member_ID,Genealogy_ID,name,sex,birth  FROM [Member] WHERE Father_ID='" + str1 + "'";
            gene r1 = new gene();   //我写的那个用来连接数据库的类是ResM，所以用其创建对象；
            DataTable d1 = new DataTable();   //因为查询是会有结果返回的，所以需要用DataTable的对象来承接返回的结果。
            d1 = r1.ExecuteQuery(str2);
            if (d1 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d1;
                dataGridView1.Columns[0].HeaderCell.Value = "成员ID";
                dataGridView1.Columns[1].HeaderCell.Value = "族谱ID";
                dataGridView1.Columns[2].HeaderCell.Value = "姓名";
                dataGridView1.Columns[3].HeaderCell.Value = "性别";
                dataGridView1.Columns[4].HeaderCell.Value = "出生日期";
            }
            else
            {
                MessageBox.Show("查不到此成员后代，请重新输入成员ID", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            }
        }

        private void text姓名_TextChanged(object sender, EventArgs e)
        {

        }

        private void 查询管理界面_Load(object sender, EventArgs e)
        {

        }

        private void serach_peiou_Click(object sender, EventArgs e)
        {
            if (peiou.Text == String.Empty)
            {
                MessageBox.Show("请输入成员ID！", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            String sql = "select spouse_name,spouse_state from Member  where Member_ID = '" + peiou.Text + "'";
            gene x = new gene();
            x.ExecuteQuery(sql);
            DataTable d1 = new DataTable();
            d1 = x.ExecuteQuery(sql);

            if (d1 != null && d1.Rows.Count > 0)
            {
                MessageBox.Show("查询成功！", "操作结果", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                peiou_name.Text= d1.Rows[0]["spouse_name"].ToString();
                peiou_state.Text= d1.Rows[0]["spouse_state"].ToString();
            }
            else
            {
                MessageBox.Show("查找不到此成员及其配偶，请重新输入成员ID", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }

        private void search_5_Click(object sender, EventArgs e)
        {
            if (zupu_id2.Text == String.Empty)
            {
                MessageBox.Show("请输入族谱ID！","温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            String sql = "select MAX(number) from Member  where Genealogy_ID = '" + zupu_id2.Text + "'";
            gene x = new gene();
            x.ExecuteQuery(sql);
            DataTable d1 = new DataTable(); 
            d1 = x.ExecuteQuery(sql);
            
            if (d1!=null)
            {
                MessageBox.Show("查询成功！","操作结果", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                zupu_daishu.Text = d1.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("查找不到此族谱代数，请重新输入族谱ID", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

            
        }

        private void search_6_Click(object sender, EventArgs e)
        {
            if (zupu_id3.Text == String.Empty)
            {
                MessageBox.Show("请输入族谱ID！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            String sql = "select count(*) from Member  where Genealogy_ID = '" + zupu_id3.Text + "'";
            gene x = new gene();
            x.ExecuteQuery(sql);
            DataTable d1 = new DataTable();
            d1 = x.ExecuteQuery(sql);

            if (d1 != null && d1.Rows.Count > 0)
            {
                MessageBox.Show("查询成功！", "操作结果", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                jz_num.Text = d1.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("查不到此族谱人数，请重新输入族谱ID", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Hide();
        }

        private void search_3_Click(object sender, EventArgs e)
        {
            if (zupu_id1.Text == String.Empty|| daishu_n.Text == String.Empty)
            {
                MessageBox.Show("请输入族谱ID和代数！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            String sql = "SELECT Member_ID,Genealogy_ID,name,sex,birth,spouse_name,spouse_state  FROM [Member] WHERE Genealogy_ID='" + zupu_id1.Text+ "'and number='"+daishu_n.Text+"'";
            gene r1 = new gene();  
            DataTable d1 = new DataTable();  
            d1 = r1.ExecuteQuery(sql);
            if (d1 != null && d1.Rows.Count > 0)
            {
                MessageBox.Show("查询成功！", "操作结果", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                dataGridView2.DataSource = d1;
                dataGridView2.Columns[0].HeaderCell.Value = "成员ID";
                dataGridView2.Columns[1].HeaderCell.Value = "族谱ID";
                dataGridView2.Columns[2].HeaderCell.Value = "姓名";
                dataGridView2.Columns[3].HeaderCell.Value = "性别";
                dataGridView2.Columns[4].HeaderCell.Value = "出生日期";
                dataGridView2.Columns[5].HeaderCell.Value = "配偶姓名";
                dataGridView2.Columns[6].HeaderCell.Value = "配偶状态";
            }
            else
            {
                MessageBox.Show("查找不到此族谱的n代成员，请重新输入", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
