<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAcc.aspx.cs" Inherits="WebPressing.CreateAcc" %>

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
    
        <br />
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" Height="340px" Width="556px">
            <WizardSteps>
                <asp:WizardStep runat="server" title="Account Type">
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="User Informations">
                    Username:<br /> Mail Address:<br />
                    <br />
                    Password:<br /> Confirm Password:<br />
                    <br />
                    <br />
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Finalizing">
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="-Programmable-"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
        <br />
    
    </div>
    </form>
</body>
</html>
