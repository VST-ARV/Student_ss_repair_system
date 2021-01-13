<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_wxrygl.aspx.cs" Inherits="demo2.admin_wxrygl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 596px">
    <form id="form1" runat="server">
        <div style="height: 592px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 维修人员管理中心&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="返回" />
&nbsp;&nbsp; <br />
            <br />
            ——————————————————————————————<br />
            <br />
            新增维修人员<br />
            输入姓名<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            输入电话<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            输入密码<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            ——————————————————————————————<br />
            <br />
            修改维修人员信息<br />
            输入维修人员id<span class="auto-style1"><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            要修改的项</span><asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="username">姓名</asp:ListItem>
                <asp:ListItem Value="tel">电话</asp:ListItem>
                <asp:ListItem Value="password">密码</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="修改" />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            ——————————————————————————————<br />
            <br />
            删除维修人员<br />
            输入维修人员id<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="删除" />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <br />
            ——————————————————————————————<br />
            <br />
            查询维修人员表<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="查询" />
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
