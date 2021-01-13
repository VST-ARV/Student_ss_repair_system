<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="repairer.aspx.cs" Inherits="demo2.repairer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 维修人员中心&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="个人中心" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="退出登录" />
            <br />
            ————————————————————————————<br />
            <br />
            修改维修记录<br />
            记录号&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            是否已经修好<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">是</asp:ListItem>
                <asp:ListItem Value="0">否</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="修改" />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            ————————————————————————————<br />
            删除维修记录<br />
            记录号&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="deleterecord" runat="server" OnClick="deleterecord_Click" Text="删除" />
            <asp:Label ID="Label4" runat="server"></asp:Label>
            <br />
            <br />
            ————————————————————————————<br />
            <br />
            增加维修记录<br />
            报修人姓名<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            报修人学号<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            寝室号<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            电话<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            报修物品<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            是否修好<asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="1">是</asp:ListItem>
                <asp:ListItem Value="0">否</asp:ListItem>
            </asp:DropDownList>
            <br />
            备注</div>
        <asp:TextBox ID="TextBox8" runat="server" Height="112px" Width="146px"></asp:TextBox>
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="上报" />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <br />
        ————————————————————————————<br />
        <br />
        <br />
            查询维修记录<br />
            <br />
            ————————————<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Value="1">查询未维修记录</asp:ListItem>
                <asp:ListItem Value="2">查询已维修记录</asp:ListItem>
                <asp:ListItem Value="3">查询所有记录</asp:ListItem>
            </asp:RadioButtonList>
&nbsp;&nbsp;
            <br />
            ————————————<br />
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
                <asp:ListItem Value="1">按宿舍号查询</asp:ListItem>
                <asp:ListItem Value="2">按日期查询</asp:ListItem>
                <asp:ListItem Value="3">按学号查询</asp:ListItem>
                <asp:ListItem Value="4">所有</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            ————————————<br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询" />
            <asp:DataGrid ID="DataGrid1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                <EditItemStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:DataGrid>
            <br />
            <br />
            ————————————————————————————<br />
            <br />
        <br />
    </form>
</body>
</html>
