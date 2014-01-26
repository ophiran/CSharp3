<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MgmtNewsArticles.aspx.cs" Inherits="WebPressing.MgmtNewsArticles" %>

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
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>News</asp:ListItem>
            <asp:ListItem>Articles</asp:ListItem>
            <asp:ListItem>Themes</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="NewsView" runat="server">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="NewsLinqDB" GridLines="Horizontal" Height="209px" Width="621px">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="Title" HeaderText="Title" ReadOnly="True" SortExpression="Title" />
                        <asp:BoundField DataField="DepositDate" HeaderText="DepositDate" ReadOnly="True" SortExpression="DepositDate" />
                        <asp:BoundField DataField="Author" HeaderText="Author" ReadOnly="True" SortExpression="Author" />
                        <asp:BoundField DataField="Statistics" HeaderText="Statistics" ReadOnly="True" SortExpression="Statistics" />
                        <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="True" SortExpression="Status" />
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
            </asp:View>
            <asp:View ID="ArticlesView" runat="server">
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="ArticlesLinqDB" GridLines="Horizontal" Width="618px">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="Title" HeaderText="Title" ReadOnly="True" SortExpression="Title" />
                        <asp:BoundField DataField="DepositDate" HeaderText="DepositDate" ReadOnly="True" SortExpression="DepositDate" />
                        <asp:BoundField DataField="Statistic" HeaderText="Statistic" ReadOnly="True" SortExpression="Statistic" />
                        <asp:BoundField DataField="Author" HeaderText="Author" ReadOnly="True" SortExpression="Author" />
                        <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="True" SortExpression="Status" />
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
            </asp:View>
            <asp:View ID="ThemeView" runat="server">
                <asp:GridView ID="GridView3" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="ThemeLinqDB" GridLines="Horizontal">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="Type1" HeaderText="Type1" ReadOnly="True" SortExpression="Type1" />
                        <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="True" SortExpression="Status" />
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
            </asp:View>
        </asp:MultiView>
        <br />
        <asp:LinqDataSource ID="ArticlesLinqDB" runat="server" ContextTypeName="DAL_Library.DataClasses2DataContext" EntityTypeName="" Select="new (Id, Title, DepositDate, Type, Statistic, Author, Status)" TableName="Articles">
        </asp:LinqDataSource>
        <asp:LinqDataSource ID="NewsLinqDB" runat="server" ContextTypeName="DAL_Library.DataClasses2DataContext" EntityTypeName="" Select="new (Id, Title, DepositDate, Author, Statistics, Status)" TableName="News">
        </asp:LinqDataSource>
        <asp:LinqDataSource ID="ThemeLinqDB" runat="server" ContextTypeName="DAL_Library.DataClasses2DataContext" EntityTypeName="" Select="new (Id, Type1, Status)" TableName="Types">
        </asp:LinqDataSource>
        <br />
        <br />
    
        <br />
    
    </div>
    </form>
</body>
</html>
