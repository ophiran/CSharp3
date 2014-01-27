<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MgmStats.aspx.cs" Inherits="WebPressing.MgmStats" %>

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
            <asp:ListItem>Journalist Statistics</asp:ListItem>
            <asp:ListItem>Theme Statistics</asp:ListItem>
            <asp:ListItem>Readers Statistics</asp:ListItem>
            <asp:ListItem>Articles Statistics</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label1" runat="server" Text="From"></asp:Label>
&nbsp;<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
        <asp:Label ID="Label2" runat="server" Text="To"></asp:Label>
        <br />
        <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
        <br />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="JournalistView" runat="server">
                <br />
                <asp:Label ID="Label3" runat="server" Text="Articles"></asp:Label>
                <asp:GridView ID="GridViewArticles" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="139px" Width="140px" AutoGenerateColumns="False" DataSourceID="ArticlesLinqDataSource">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="Author" HeaderText="Author" ReadOnly="True" SortExpression="Author" />
                        <asp:BoundField DataField="Count" HeaderText="Count" ReadOnly="True" SortExpression="Count" />
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
                <asp:Label ID="Label4" runat="server" Text="News"></asp:Label>
                <asp:GridView ID="GridViewNews" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Width="143px" Height="99px" AutoGenerateColumns="False" DataSourceID="NewsLinqDataSource">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="Author" HeaderText="Author" ReadOnly="True" SortExpression="Author" />
                        <asp:BoundField DataField="Count" HeaderText="Count" ReadOnly="True" SortExpression="Count" />
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
                &nbsp;
            </asp:View>
            <asp:View ID="ThemeView" runat="server">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Width="223px" DataSourceID="ThemeLinqDataSource">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="RefType" HeaderText="RefType" ReadOnly="True" SortExpression="RefType" />
                        <asp:BoundField DataField="Count" HeaderText="Count" ReadOnly="True" SortExpression="Count" />
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
            <asp:View ID="ConnectedView" runat="server">
                <asp:Chart ID="Chart1" runat="server" DataSourceID="ConnectionLinqDataSource">
                    <Series>
                        <asp:Series ChartType="Line" Name="Series1" XValueMember="Date" YValueMembers="ConnectionCount">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
            </asp:View>
            <asp:View ID="ArticlesStatView" runat="server">
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="ArticlesStatLinqDataSource" GridLines="Horizontal" Width="222px">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="Title" HeaderText="Title" ReadOnly="True" SortExpression="Title" />
                        <asp:BoundField DataField="Statistic" HeaderText="Statistic" ReadOnly="True" SortExpression="Statistic" />
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
        <asp:LinqDataSource ID="ArticlesLinqDataSource" runat="server" ContextTypeName="DAL_Library.DataClasses2DataContext" EntityTypeName="" TableName="Articles" GroupBy="Author" Select="new (key as Author, it as Articles, Count() as Count)" Where="DepositDate &gt; @DepositDate &amp;&amp; DepositDate &lt;= @DepositDate1">
            <WhereParameters>
                <asp:SessionParameter DefaultValue="1970-1-1" Name="DepositDate" SessionField="FromDate" Type="DateTime" />
                <asp:SessionParameter Name="DepositDate1" SessionField="toDate" Type="DateTime" />
            </WhereParameters>
        </asp:LinqDataSource>
    
        <asp:LinqDataSource ID="NewsLinqDataSource" runat="server" ContextTypeName="DAL_Library.DataClasses2DataContext" EntityTypeName="" GroupBy="Author" Select="new (key as Author, it as News, Count() as Count)" TableName="News" Where="DepositDate &lt;= @DepositDate1 &amp;&amp; DepositDate &gt;= @DepositDate">
            <WhereParameters>
                <asp:SessionParameter Name="DepositDate1" SessionField="toDate" Type="DateTime" />
                <asp:SessionParameter Name="DepositDate" SessionField="fromDate" Type="DateTime" />
            </WhereParameters>
        </asp:LinqDataSource>
        <asp:LinqDataSource ID="ThemeLinqDataSource" runat="server" ContextTypeName="DAL_Library.DataClasses2DataContext" EntityTypeName="" GroupBy="RefType" Select="new (key as RefType, it as Articles, Count() as Count)" TableName="Articles" Where="DepositDate &gt;= @DepositDate &amp;&amp; DepositDate &lt;= @DepositDate1">
            <WhereParameters>
                <asp:SessionParameter Name="DepositDate" SessionField="fromDate" Type="DateTime" />
                <asp:SessionParameter Name="DepositDate1" SessionField="toDate" Type="DateTime" />
            </WhereParameters>
        </asp:LinqDataSource>
        <asp:LinqDataSource ID="ArticlesStatLinqDataSource" runat="server" ContextTypeName="DAL_Library.DataClasses2DataContext" EntityTypeName="" Select="new (Id, Title, Statistic)" TableName="Articles" Where="DepositDate &gt;= @DepositDate &amp;&amp; DepositDate &lt;= @DepositDate1">
            <WhereParameters>
                <asp:SessionParameter Name="DepositDate" SessionField="fromDate" Type="DateTime" />
                <asp:SessionParameter Name="DepositDate1" SessionField="toDate" Type="DateTime" />
            </WhereParameters>
        </asp:LinqDataSource>
    
        <asp:LinqDataSource ID="ConnectionLinqDataSource" runat="server" ContextTypeName="DAL_Library.DataClasses2DataContext" EntityTypeName="" OrderBy="Date" Select="new (ConnectionCount, Date)" TableName="LogConnections" Where="Date &gt;= @Date &amp;&amp; Date &lt;= @Date1">
            <WhereParameters>
                <asp:SessionParameter Name="Date" SessionField="fromDate" Type="DateTime" />
                <asp:SessionParameter Name="Date1" SessionField="toDate" Type="DateTime" />
            </WhereParameters>
        </asp:LinqDataSource>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
