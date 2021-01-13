<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="repairer_grzx.aspx.cs" Inherits="demo2.repairer_grzx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
    </style>
</head>
<body style="height: 693px">
    <form id="form1" runat="server">
        <div style="height: 765px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1"><strong>维修人员个人中心&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="返回" />
            <br />
            </strong>
            <asp:Label ID="Label1" runat="server" style="font-size: medium" Text="个人信息"></asp:Label>
                <asp:Button ID="refresh" runat="server" Height="21px" Text="刷新" Width="71px" OnClick="refresh_Click" />
            <asp:Panel ID="Panel1" runat="server" BorderStyle="Double" Height="87px" style="font-size: medium" Width="275px">
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <span class="auto-style1">
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                </span>
            </asp:Panel>
            <br />
            <br />
            ——————————————————————————<br />
            <br />
            修改个人信息<br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="username">姓名</asp:ListItem>
                <asp:ListItem Value="tel">电话</asp:ListItem>
                <asp:ListItem Value="password">密码</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="修改" style="height: 21px" />
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            </span>
        </div>
    </form>
</body>
</html>
