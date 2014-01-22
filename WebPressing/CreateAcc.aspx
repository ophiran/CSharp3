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
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" Height="340px" Width="488px">
            <WizardSteps>
                <asp:WizardStep runat="server" title="Account Type">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="56px" Width="133px">
                        <asp:ListItem>Journalist</asp:ListItem>
                        <asp:ListItem>Reader</asp:ListItem>
                    </asp:RadioButtonList>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="User Informations">
                    Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
                    <br /> Mail Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxMail" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
                    <br /> Confirm Password:&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxPasswordConfirm" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Finalizing">
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Validation file :"></asp:Label>
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
