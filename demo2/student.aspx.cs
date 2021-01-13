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
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("stu_repair.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedItem!=null && TextBox1.Text!=""){
                string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                           //database=test_login 数据库名
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
                cmd.CommandText = "update student set " + RadioButtonList1.SelectedValue + "=" + "'" + TextBox1.Text + "'" + " WHERE no=" + HttpContext.Current.Session["UserId"];    //创建update语句 
                conn.Open();//开启数据库
                if (cmd.ExecuteNonQuery() > 0)//函数返回操作成功行数，成功就>0
                {
                    Label5.Text = "修改成功";
                }
                else
                {
                    Label5.Text = "修改失败";
                }
                conn.Close();
            }
            else if(RadioButtonList1.SelectedItem == null && TextBox1.Text != "")
            {
                Label5.Text = "请选择要修改的信息！";
            }
            else if (RadioButtonList1.SelectedItem!= null && TextBox1.Text == "")
            {
                Label5.Text = "请输入要修改的信息！";
            }
            else
            {
                Label5.Text = "请选择和输入输入要修改的信息！";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
   
               string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                          //database=test_login 数据库名
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
                cmd.CommandText = "select * from student WHERE no=" + HttpContext.Current.Session["UserId"];    //创建查询语句 
                conn.Open();//打开数据库 
                SqlDataReader sdr = cmd.ExecuteReader();//将字符串送入数据库操作
                sdr.Read();//返回数据，为数组形式
                Label3.Text = "学号:" + sdr[0] + "<br/>" + "姓名:" + sdr[1] + "<br/>" + "班级:" + sdr[2] + "<br/>" + "寝室号:" + sdr[3] + "<br/>" + "电话:" + sdr[4] + "<br/>" + "邮箱:" + sdr[5];
                conn.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("welcome.aspx");
            HttpContext.Current.Session["UserId"] = null;
            HttpContext.Current.Session["Userpwd"] = null;
        }
    }
}