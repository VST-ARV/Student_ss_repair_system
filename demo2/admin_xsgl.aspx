<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_xsgl.aspx.cs" Inherits="demo2.admin_xsgl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 942px">
    <form id="form1" runat="server">
        <div style="height: 979px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 学生管理中心&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="返回" />
            <br />
            ————————————————————————————————————————<br />
            <br />
            修改学生信息<br />
            输入学号<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            选择要修改的属性<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="name">姓名</asp:ListItem>
                <asp:ListItem Value="classno">班号</asp:ListItem>
                <asp:ListItem Value="domno">宿舍号</asp:ListItem>
                <asp:ListItem Value="tel">电话</asp:ListItem>
                <asp:ListItem Value="mail">邮箱</asp:ListItem>
                <asp:ListItem Value="password">密码</asp:ListItem>
            </asp:DropDownList>
            <br />
            修改为<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="修改" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            ————————————————————————————————————————<br />
            <br />
            添加学生信息<br />
            输入学号<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            输入姓名<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            输入班级号<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            输入寝室号<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            输入电话<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            输入邮箱<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            输入密码<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="添加" />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            ————————————————————————————————————————<br />
            <br />
            删除学生信息<br />
            输入学号<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="删除" />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <br />
            ————————————————————————————————————————<br />
            <br />
            查询学生信息<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Value="1">按学号查询</asp:ListItem>
                <asp:ListItem Value="2">按班级号查询</asp:ListItem>
                <asp:ListItem Value="3">按寝室号查询</asp:ListItem>
                <asp:ListItem Value="4">所有</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="Label4" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox11" runat="server" Width="148px"></asp:TextBox>
            <asp:Button ID="Button7" runat="server" Height="19px" OnClick="Button7_Click" Text="查询" />
            <asp:Label ID="Label5" runat="server"></asp:Label>
            <asp:DataGrid ID="DataGrid1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingItemStyle BackColor="White" />
                <EditItemStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#E3EAEB" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            </asp:DataGrid>
            </div>
    </form>
</body>
</html>
