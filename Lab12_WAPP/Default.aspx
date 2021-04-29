<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab12_WAPP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="Operand1" runat="server"></asp:TextBox>
            <asp:DropDownList ID="Operator" runat="server" style="margin-right: 0px">
                <asp:ListItem Value="plus">+</asp:ListItem>
                <asp:ListItem Value="minus">-</asp:ListItem>
                <asp:ListItem Value="mult">*</asp:ListItem>
                <asp:ListItem Value="divide">/</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="Operand2" runat="server"></asp:TextBox>
            <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Spocti" />

        </div>
    </form>
</body>
</html>
