<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stu_repair.aspx.cs" Inherits="demo2.stu_repair" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="故障报修"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="返回" />
&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Panel ID="Panel1" runat="server" BorderStyle="Double" Height="264px" Width="377px">
                <asp:Label ID="Label2" runat="server" Text="输入要报修的物品："></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="备注："></asp:Label>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" Height="181px" OnTextChanged="TextBox2_TextChanged" Width="287px"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" />
                <asp:Label ID="Label5" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:Panel>
            <br />
            <asp:Label ID="Label4" runat="server" Text="报修记录查询"></asp:Label>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="查询" />
            <br />
            <asp:DataGrid ID="DataGrid1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingItemStyle BackColor="White" />
                <EditItemStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#EFF3FB" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            </asp:DataGrid>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="报修记录修改"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text="选择要修改的信息"></asp:Label>
            <br />
            报修记录号<asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="domno">寝室号</asp:ListItem>
                <asp:ListItem Value="tel">电话</asp:ListItem>
                <asp:ListItem Value="item">报修物品</asp:ListItem>
                <asp:ListItem Value="details">备注</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="修改" />
            <asp:Label ID="Label8" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="报修记录删除"></asp:Label>
            <br />
            报修记录号<asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="删除" />
            <br />
            <asp:Label ID="Label10" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            &nbsp;<br />
            &nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
