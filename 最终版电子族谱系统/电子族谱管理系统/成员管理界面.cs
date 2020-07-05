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
    public partial class 成员管理界面 : Form
    {
        public 成员管理界面()
        {
            InitializeComponent();
        }
        
        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str1 = addmemID.Text;       
            String str2 = addzupuID.Text;
            String str3 = add父亲ID.Text;
            String str4 = memname.Text;
            String str5 = sex.Text;
            String str6 = number.Text;
            String str7 = birthdate.Text;
            String str8 = deathdate.Text;
            String str9 = birthplace.Text;
            String str10 = address.Text;
            String str11 = spousename.Text;
            String str12 = spousestate.Text;
            String str0 = textBox1.Text;
            String str13 = null;
            if(str11.Length == 0)
            {
                str13= "insert into [Member] values('" + str1 + "','" + str3 + "','" + str2 + "','" + str4 + "','" + str5+"' ,'"+ str7 + "','" + str8 + "','" + str9 + "','" + str10 + "', NULL,NULL, '" + str6 + "' ,'"+str0+"') ";   //编写sql语句，赋值给一个string变量，然后传给ExecuteQuery来执行；
            }
            else
            {
                str13 = "insert into [Member] values('" + str1 + "','" + str3 + "','" + str2 + "','" + str4 + "','" + str5 + "' ,'" + str7 + "','" + str8 + "','" + str9 + "','" + str10 + "','" + str11 + "', '" + str12 + "' , '" + str6 + "','" + str0 + "' ) ";   //编写sql语句，赋值给一个string变量，然后传给ExecuteQuery来执行；
              
            }
            gene r2 = new gene();   //用来连接数据库的类gene，所以用其创建对象；
            int d2 = r2.ExecuteUpdate(str13);   //执行后会有返回值，是int类型，如果执行失败会返回0；
            if (d2 != 0)
            {
                MessageBox.Show("添加成功！", "添加结果",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败，\n请重新输入！", "添加结果",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String str1 = addmemID.Text;
            String str2 = addzupuID.Text;
            String str3 = add父亲ID.Text;
            String str4 = memname.Text;
            String str5 = sex.Text;
            String str6 = number.Text;
            String str7 = birthdate.Text;
            String str8 = deathdate.Text;
            String str9 = birthplace.Text;
            String str10 = address.Text;
            String str11 = spousename.Text;
            String str12 = spousestate.Text;
            String str0 = textBox1.Text;
            String str13 = null;
            if (str11.Length == 0)
            {
                str13 = "UPDATE [Member] SET Member_ID='" + str1 + "',Genealogy_ID='" + str2 + "',Father_ID='" + str3 + "',name='" + str4 + "'," +
                    "sex='" + str5 + "' ,number='" + str6 + "',birth='" + str7 + "',death='" + str8 + "',birthplace='" + str9 + "',address='" + str10 + "'," +
                    "spouse_name=NULL,spouse_state=NULL,num='" + str0+ "'";   //编写sql语句，赋值给一个string变量，然后传给ExecuteQuery来执行；
            }
            else
            {
                str13 = "UPDATE [Member] SET Member_ID='" + str1 + "',Genealogy_ID='" + str2 + "',Father_ID='" + str3 + "',name='" + str4 + "'," +
                                   "sex='" + str5 + "' ,number='" + str6 + "',birth='" + str7 + "',death='" + str8 + "',birthplace='" + str9 + "',address='" + str10 + "'," +
                                   "spouse_name='" + str11 + "',spouse_state='" + str12 + "',num='" + str0 + "'";   //编写sql语句，赋值给一个string变量，然后传给ExecuteQuery来执行；
            }
            gene r2 = new gene();   //用来连接数据库的类gene，所以用其创建对象；
            int d2 = r2.ExecuteUpdate(str13);   //执行后会有返回值，是int类型，如果执行失败会返回0；
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
            String str1 = shanchuID.Text;
            String str2 = "DELETE FROM [Member] WHERE Member_ID = '" + str1 + "' OR Father_ID='" + str1 + "'";
            gene r2 = new gene();   //用来连接数据库的类gene，所以用其创建对象；
            int d2 = r2.ExecuteUpdate(str2);   //执行后会有返回值，是int类型，如果执行失败会返回0；
            if (d2 != 0)
            {
                if (MessageBox.Show("确认删除成员吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    MessageBox.Show("删除成功", "删除结果", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("删除错误!\n", "删除结果",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void shanchuID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void spousestate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
