<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientArticles.aspx.cs" Inherits="WebPressing.ClientArticles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 795px">
    <form id="form1" runat="server">
    <div style="height: 799px">
    
        
        <asp:Panel ID="Panel1" runat="server" BackColor="#666699">
            <asp:Menu ID="Menu1" runat="server" StaticSubMenuIndent="16px" Font-Bold="True" ForeColor="White">
            <DynamicMenuItemStyle BorderStyle="None" />
            <DynamicMenuStyle BackColor="#666699" BorderColor="#660033" BorderStyle="Inset" />
            <DynamicItemTemplate>
                <%# Eval("Text") %>
            </DynamicItemTemplate>
            <Items>
                <asp:MenuItem Text="Menu" Value="Menu"></asp:MenuItem>
            </Items>
            <StaticMenuStyle BackColor="#666699" BorderColor="#660033" BorderStyle="Inset" />
            </asp:Menu>

        </asp:Panel>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Label ID="Theme" runat="server" Text=""></asp:Label>

        <br />

        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Description" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="358px" Width="227px"></asp:ListBox>

        <br />
        <br />
        <asp:Label ID="ArticleTitle" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Image ID="ArticleImage" runat="server" Height="117px" Width="150px" />
        <br />
        <br />
        <asp:Label ID="ArticleSubtitle" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="TextZone" runat="server" Text=""></asp:Label>

    </div>
    </form>
</body>
</html>
