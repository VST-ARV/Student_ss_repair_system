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
    public partial class admin_wxrygl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
            {
                string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                           //database=test_login 数据库名
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
                cmd.CommandText = "insert into worker(username,tel,password,duty) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','repairer');";//插入语句
                conn.Open();//打开数据库 

                if (cmd.ExecuteNonQuery() > 0)//函数返回操作成功行数，成功就>0
                    {
                        Label1.Text = "提交成功";
                    }
                else
                    {
                        Label1.Text = "提交失败";
                    }
                conn.Close();
                
               
            }
            else
            {
                    Label1.Text = "请补全信息！";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string strConnection = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa";
            //SQL Server 和 Windows混合模式 
            //string strConnection="Initial Catalog=eshop;Data Source=localhost; Integrated Security=SSPI"; 
            //仅 Windows身份验证模式
            SqlConnection myConnection = new SqlConnection(strConnection);
            string strCommnad = "select id as 登陆id,username as 姓名,tel as 电话,password as 密码 from worker where duty='repairer'";
            try { myConnection.Open(); }
            catch (Exception) { }
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(strCommnad, myConnection);
            DataSet myDataSet = new DataSet();
            try
            {
                int i = myDataAdapter.Fill(myDataSet, "id");
                if (i == 0) return;
            }
            catch (Exception) { return; }

            DataGrid1.DataSource = myDataSet;
            DataGrid1.DataBind();
            myConnection.Close();


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem != null && TextBox5.Text != "" && TextBox4.Text != "")
            {
                string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                           //database=test_login 数据库名
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
                cmd.CommandText = "update worker set " + DropDownList1.SelectedValue + "=" + "'" + TextBox4.Text + "'" + " WHERE id=" + TextBox5.Text;    //创建update语句 
                conn.Open();//开启数据库
                if (cmd.ExecuteNonQuery() > 0)//函数返回操作成功行数，成功就>0
                {
                    Label2.Text = "修改成功";
                }
                else
                {
                    Label2.Text = "修改失败";
                }
                conn.Close();
            }
            else 
            {
                Label2.Text = "请补全信息！";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text != "")
            {
                string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                           //database=test_login 数据库名
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
                cmd.CommandText = "delete from worker where id='" + TextBox6.Text + "'";    //创建update语句 
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
                Label3.Text = "请补全信息！";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }
    }
}