using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;  //引用 表的命名空间
using System.Data.SqlClient;    //第一步：引用与sql相关的命名空间

namespace demo2
{
    public partial class admin_xsgl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem != null && TextBox1.Text != "" && TextBox2.Text != "")
            {
                string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                           //database=test_login 数据库名
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
                cmd.CommandText = "update student set " + DropDownList1.SelectedValue + "=" + "'" + TextBox2.Text + "'" + " WHERE no=" + "'" + TextBox1.Text + "'";    //创建update语句 
                conn.Open();//开启数据库
                if (cmd.ExecuteNonQuery() > 0)//函数返回操作成功行数，成功就>0
                {
                    Label1.Text = "修改成功";
                }
                else
                {
                    Label1.Text = "修改失败";
                }
                conn.Close();
            }
            else
            {
                Label1.Text = "请补全信息！";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "")
            {
                string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                           //database=test_login 数据库名
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
                cmd.CommandText = "insert into student values('" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "');";    //创建insert语句 
                conn.Open();//开启数据库
                if (cmd.ExecuteNonQuery() > 0)//函数返回操作成功行数，成功就>0
                {
                    Label2.Text = "添加成功";
                }
                else
                {
                    Label2.Text = "添加失败";
                }
                conn.Close();
            }
            else
            {
                Label2.Text = "请补全信息！";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox10.Text != "" )
            {
                string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                           //database=test_login 数据库名
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
                cmd.CommandText = "delete from student where no='" + TextBox10.Text + "'";
                conn.Open();//开启数据库
                if (cmd.ExecuteNonQuery() > 0)//函数返回操作成功行数，成功就>0
                {
                    Label3.Text = "删除成功";
                }
                else
                {
                    Label3.Text = "删除失败";
                }
                conn.Close();
            }
            else
            {
                Label3.Text = "请输入学号！";
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = null;
            DataGrid1.DataBind();
            Label4.Text = "";
            Label5.Text = "";
            if ((RadioButtonList1.SelectedItem != null && TextBox11.Text !="")||(RadioButtonList1.SelectedItem != null && int.Parse(RadioButtonList1.SelectedValue)==4))
            {
                string strConnection = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa";
                //SQL Server 和 Windows混合模式 
                //string strConnection="Initial Catalog=eshop;Data Source=localhost; Integrated Security=SSPI"; 
                //仅 Windows身份验证模式
                SqlConnection myConnection = new SqlConnection(strConnection);
                string strCommnad = null;
                switch(int.Parse(RadioButtonList1.SelectedValue))
                {
                    case 1: strCommnad = "select * from student where no='" + TextBox11.Text+"'"; break;
                    case 2: strCommnad = "select * from student where classno=" + TextBox11.Text + "'"; break;
                    case 3: strCommnad = "select * from student where domno=" + TextBox11.Text + "'"; break;
                    case 4: strCommnad = "select * from student" ; break;
                    default: break;
                }
                try { myConnection.Open(); }
                catch (Exception) { }
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(strCommnad, myConnection);
                DataSet myDataSet = new DataSet();
                try
                {
                    int i = myDataAdapter.Fill(myDataSet, "recordno");
                    if (i == 0) return;
                }
                catch (Exception) { return; }

                DataGrid1.DataSource = myDataSet;
                DataGrid1.DataBind();

                myConnection.Close();

            }
            else
            {
                Label5.Text = "补全信息！";
            }

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(int.Parse(RadioButtonList1.SelectedValue)==4)
            {
                Label4.Text = "不用输入";
            }
            else
            {
                Label4.Text = "";
            }
        }
    }
}