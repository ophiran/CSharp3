<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MgmtReaders.aspx.cs" Inherits="WebPressing.MgmtReaders" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 420px">
    
        
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
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="LinqDataSource1" GridLines="Horizontal" Height="16px" Width="863px">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" ReadOnly="True" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" ReadOnly="True" />
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" SortExpression="BirthDate" ReadOnly="True" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" ReadOnly="True" />
                <asp:BoundField DataField="MailAddress" HeaderText="MailAddress" SortExpression="MailAddress" ReadOnly="True" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" ReadOnly="True" />
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
    
        <br />
    
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DAL_Library.DataClasses2DataContext" EntityTypeName="" TableName="Users" Select="new (Id, FirstName, LastName, BirthDate, UserName, MailAddress, Status)" Where="Right == @Right">
            <WhereParameters>
                <asp:Parameter DefaultValue="2" Name="Right" Type="Int32" />
            </WhereParameters>
        </asp:LinqDataSource>
    
    </div>
    </form>
</body>
</html>
