<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="worker_login.aspx.cs" Inherits="demo2.worker_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Enabled="False" Text="维修人员和管理员登陆"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 10px"></asp:TextBox>
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="19px" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登陆" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">返回学生登陆</asp:LinkButton>
        <br />
    </form>
</body>
</html>
