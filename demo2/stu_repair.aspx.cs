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
    public partial class stu_repair : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                       //database=test_login 数据库名
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
            cmd.CommandText = "select * from student WHERE no=" + HttpContext.Current.Session["UserId"];    //创建查询语句 
            conn.Open();//打开数据库 
            SqlDataReader sdr = cmd.ExecuteReader();//将字符串送入数据库操作
            sdr.Read();//返回数据，为数组形式
            string b = "insert into record(name,no,domno,tel,item,details,time,isrpd) values('" + sdr[1] + "','" + sdr[0] + "','" + sdr[3] + "','" + sdr[4] + "','" 
                + TextBox1.Text + "','" + TextBox2.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',0);";//插入语句
            sdr.Close();//关闭数据读取
            cmd.CommandText = b;
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                if (cmd.ExecuteNonQuery() > 0)//函数返回操作成功行数，成功就>0
                {
                    Label5.Text = "提交成功";
                }
                else
                {
                    Label5.Text = "提交失败";
                }
                conn.Close();
            }
            else
            {
                Label5.Text = "请补全报修信息！";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string strConnection = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa";
            //SQL Server 和 Windows混合模式 
            //string strConnection="Initial Catalog=eshop;Data Source=localhost; Integrated Security=SSPI"; 
            //仅 Windows身份验证模式
            SqlConnection myConnection = new SqlConnection(strConnection);
            string strCommnad = "SELECT recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" +
                " FROM record WHERE no='" + HttpContext.Current.Session["UserId"] + "'";
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


            SqlConnection con3 = new SqlConnection("server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;");//更新recordno下拉菜单
            con3.Open();
            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = "select recordno from record where no ="+ HttpContext.Current.Session["UserId"];
            cmd3.CommandType = CommandType.Text;
            cmd3.Connection = con3;
            SqlDataReader sdr3 = cmd3.ExecuteReader();
            DropDownList2.DataSource = sdr3;
            DropDownList2.DataTextField = "recordno";
            DropDownList2.DataBind();
            sdr3.Close();
            SqlDataReader sdr4 = cmd3.ExecuteReader();
            DropDownList3.DataSource = sdr4;
            DropDownList3.DataTextField = "recordno";
            DropDownList3.DataBind();
            sdr4.Close();
            con3.Close();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem != null && DropDownList2.SelectedItem != null &&TextBox3.Text != "")
            {
                string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                           //database=test_login 数据库名
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
                cmd.CommandText = "update record set " + DropDownList1.SelectedValue + "=" + "'" + TextBox3.Text + "'" + " WHERE no=" + HttpContext.Current.Session["UserId"]+" AND recordno="+DropDownList2.SelectedValue;    //创建update语句 
                conn.Open();//开启数据库
                if (cmd.ExecuteNonQuery() > 0)//函数返回操作成功行数，成功就>0
                {
                    Label8.Text = "修改成功";
                }
                else
                {
                    Label8.Text = "修改失败";
                }
                conn.Close();
            }
            else if(DropDownList2.SelectedItem == null) 
            {
                Label8.Text = "记录列表为空，请先查询报修信息！";
            }
            else
            {
                Label8.Text = "请补全信息！";
             }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        protected void Button5_Click(object sender, EventArgs e)
        {
            if (DropDownList3.SelectedValue != null)
            {
                string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                           //database=test_login 数据库名
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
                cmd.CommandText = "delete from record where recordno='"+ DropDownList3.SelectedValue +"' AND no="+ HttpContext.Current.Session["UserId"];    //创建delete语句 
                conn.Open();//开启数据库
                if (cmd.ExecuteNonQuery() > 0)//函数返回操作成功行数，成功就>0
                {
                    Label10.Text = "删除成功";
                }
                else
                {
                    Label10.Text = "删除失败，请更新维修查询记录";
                }
                conn.Close();
            }
            else if (DropDownList3.SelectedItem == null)
            {
                Label10.Text = "记录列表为空，请先查询报修信息！";
            }
        }      
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("student.aspx");
        }
    }
}