using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;


namespace demo2
{
    public partial class repairer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session["UserId"] = null;
            HttpContext.Current.Session["Userpwd"] = null;
            Response.Redirect("worker_login.aspx");
        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (int.Parse(RadioButtonList2.SelectedValue))
            {
                case 1: Label1.Text = "请输入寝室号";break;
                case 2: Label1.Text = "请输入日期"; break;
                case 3: Label1.Text = "请输入学号"; break;
                case 4: Label1.Text = "此框不需要输入"; break;
                default:break;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = null;
            DataGrid1.DataBind();
            if (RadioButtonList1.SelectedItem != null && RadioButtonList2.SelectedItem != null)
            { 
                string strConnection = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa";
            //SQL Server 和 Windows混合模式 
            //string strConnection="Initial Catalog=eshop;Data Source=localhost; Integrated Security=SSPI"; 
            //仅 Windows身份验证模式
                SqlConnection myConnection = new SqlConnection(strConnection);
                
                int isrpd=-1;
                string strCommnad=null;
                switch (int.Parse(RadioButtonList2.SelectedValue))
                {
                    case 1:
                        {
                            switch (int.Parse(RadioButtonList1.SelectedValue))
                            {
                                case 1: isrpd = 0;  strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" +" FROM record WHERE isrpd=" + isrpd + " AND domno='"+TextBox1.Text+"'"; break;
                                case 2: isrpd = 1;  strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" + " FROM record WHERE isrpd=" + isrpd + " AND domno='" + TextBox1.Text + "'"; break;   
                                case 3:              strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" +  " FROM record WHERE domno='" + TextBox1.Text + "'"; break;
                                default: break;

                            }
                        } break;
                    case 2:
                        {
                            switch (int.Parse(RadioButtonList1.SelectedValue))
                            {
                                case 1: isrpd = 0; strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" + " FROM record WHERE isrpd=" + isrpd + " AND  Convert(varchar,time,120) like '" + TextBox1.Text + "%'"; break;
                                case 2: isrpd = 1; strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" + " FROM record WHERE isrpd=" + isrpd + " AND  Convert(varchar,time,120) like '" + TextBox1.Text + "%'"; break;
                                case 3: strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" + " FROM record WHERE  Convert(varchar,time,120) like '" + TextBox1.Text + "%'";break;
                                default: break;

                            }
                        } break;
                    case 3:
                        {
                            switch (int.Parse(RadioButtonList1.SelectedValue))
                            {
                                case 1: isrpd = 0; strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" + " FROM record WHERE isrpd=" + isrpd + " AND no='" + TextBox1.Text + "'"; break;
                                case 2: isrpd = 1; strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" + " FROM record WHERE isrpd=" + isrpd + " AND no='" + TextBox1.Text + "'"; break;
                                case 3: strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" + " FROM record WHERE no='" + TextBox1.Text + "'"; break;
                                default: break;

                            }
                        }; break;
                    case 4: {
                            switch (int.Parse(RadioButtonList1.SelectedValue))
                            {
                                case 1: isrpd = 0; strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" + " FROM record WHERE isrpd=" + isrpd; break;
                                case 2: isrpd = 1; strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" + " FROM record WHERE isrpd=" + isrpd; break;
                                case 3: strCommnad = "SELECT  recordno as 记录号,name as 姓名,no as 学号,domno as 寝室号,tel as 电话号,item as 要维修的物品,details as 备注,time as 上报时间,isrpd as 是否修好" + " FROM record "; break;
                                default: break;

                            }
                        } break;
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
                Label1.Text = "请选择完整！";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if( TextBox2.Text != "" && DropDownList1.SelectedItem !=null)
            { 
            string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                       //database=test_login 数据库名
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
            cmd.CommandText = "update record set isrpd=" + DropDownList1.SelectedValue  + " WHERE recordno='" + TextBox2.Text+"'";    //创建update语句 
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                   //database=test_login 数据库名
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
            conn.Open();//打开数据库 
            cmd.CommandText = "insert into record(name,no,domno,tel,item,details,time,isrpd) values('"
                +TextBox3.Text+"','"+TextBox4.Text + "','" +TextBox5.Text + "','" +TextBox6.Text + "','" +TextBox7.Text + "','" +TextBox8.Text+"','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"',"+DropDownList2.SelectedValue+");";
            if (TextBox3.Text != "" && DropDownList2.SelectedItem != null && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "")
            {
                if (cmd.ExecuteNonQuery() > 0)//函数返回操作成功行数，成功就>0
                {
                    Label3.Text = "提交成功";
                }
                else
                {
                    Label3.Text = "提交失败";
                }
                conn.Close();
            }
            else
            {
                Label3.Text = "请补全报修信息！";
            }

        }

        protected void deleterecord_Click(object sender, EventArgs e)
        {
            if (TextBox9.Text != "")
            {
                string connstring = "server=LAPTOP-2I849P2E\\MSSQLSERVER01;database=repair;uid=sa;pwd=sa;";//server=. 代表本地服务器，就是自己的电脑
                                                                                                           //database=test_login 数据库名
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
                cmd.CommandText = "delete from record where recordno='" + TextBox9.Text + "'";    //创建delete语句 
                conn.Open();//开启数据库
                if (cmd.ExecuteNonQuery() > 0)//函数返回操作成功行数，成功就>0
                {
                    Label4.Text = "删除成功";
                }
                else
                {
                    Label4.Text = "删除失败，请检查是否有这条记录！";
                }
                conn.Close();
            }
            else if (TextBox9.Text == "")
            {
                Label4.Text = "请输入记录号！";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("repairer_grzx.aspx");
        }
    }
}