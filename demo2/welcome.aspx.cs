using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace demo2
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user_number = Request.Form["TextBox1"].ToString();
            string user_pwd = Request.Form["TextBox2"].ToString();

            string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
            //database=test_login 数据库名
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
            cmd.CommandText = "select * from student WHERE no=" + user_number + "AND password=" + "'" + user_pwd + "'";    //创建查询语句 
            try
            {
                conn.Open();//打开数据库 
                SqlDataReader sdr = cmd.ExecuteReader();    //从数据库中读取数据流存入reader中                                              
                if (sdr.Read()) //从sdr中读取下一行数据,如果没有数据,sdr.Read()返回flase 
                {
                    HttpContext.Current.Session["UserId"] = user_number;
                    HttpContext.Current.Session["Userpwd"] = user_pwd;
                    Response.Redirect("student.aspx");
                }
                else
                {
                    //Message.Text = "输入错误，请重新输入！";

                    // Response.Redirect("login.aspx");
                    // Response.Write("<script>confirm('输入账号或密码错误！');</script>");

                    Response.Write("<script language=javascript>alert('输入账号或密码错误！');window.location = 'welcome.aspx';</script>");

                }
            }
            catch (Exception ee)
            {
                Response.Write("The connection is fair");
            }
            finally
            {
                conn.Close();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("worker_login.aspx"); 
        }
    }
}