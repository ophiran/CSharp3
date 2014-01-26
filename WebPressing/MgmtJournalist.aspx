<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MgmtJournalist.aspx.cs" Inherits="WebPressing.MgmtJournalist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        
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
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="LinqDataSource1" GridLines="Horizontal" Width="863px">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" ReadOnly="True" SortExpression="FirstName" />
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" ReadOnly="True" SortExpression="LastName" />
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" ReadOnly="True" SortExpression="BirthDate" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" ReadOnly="True" SortExpression="UserName" />
                <asp:BoundField DataField="MailAddress" HeaderText="MailAddress" ReadOnly="True" SortExpression="MailAddress" />
                <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="True" SortExpression="Status" />
                <asp:ButtonField ButtonType="Button" CommandName="Download" Text="Download" />
                <asp:ButtonField ButtonType="Button" CommandName="Enable" Text="Enable" />
                <asp:ButtonField ButtonType="Button" CommandName="Disable" Text="Disable" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DAL_Library.DataClasses2DataContext" EntityTypeName="" Select="new (FirstName, Id, LastName, BirthDate, UserName, MailAddress, Status)" TableName="Users" Where="Right == @Right">
            <WhereParameters>
                <asp:Parameter DefaultValue="3" Name="Right" Type="Int32" />
            </WhereParameters>
        </asp:LinqDataSource>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
