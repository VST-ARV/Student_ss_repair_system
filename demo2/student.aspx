<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="demo2.student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 623px">
    <form id="form1" runat="server">
        <div style="height: 609px">
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="个人中心"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" Text="我的信息"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="寝室故障报修" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="退出" OnClick="Button3_Click" style="height: 21px" />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" BorderStyle="Double" Height="255px" Width="210px">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="height: 21px" Text="刷新" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="选择要修改的信息"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="name">姓名</asp:ListItem>
                <asp:ListItem Value="classno">班级</asp:ListItem>
                <asp:ListItem Value="domno">寝室号</asp:ListItem>
                <asp:ListItem Value="tel">电话</asp:ListItem>
                <asp:ListItem Value="mail">邮箱</asp:ListItem>
                <asp:ListItem Value="password">密码</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="修改个信息" style="margin-top: 0px" />
            &nbsp;<br />
            &nbsp;
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
