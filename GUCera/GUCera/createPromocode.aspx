<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createPromocode.aspx.cs" Inherits="GUCera.createPromocode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Create Promocode<br />
            <br />
            code:<br />
            <asp:TextBox ID="code_txt" runat="server" MaxLength="6"></asp:TextBox>
            <br />
            <br />
            issue date:<br />
            <asp:TextBox ID="issueDate_txt" runat="server"></asp:TextBox>
            <br />
            <br />
            expiry date:<br />
            <asp:TextBox ID="expiryDate_txt" runat="server"></asp:TextBox>
            <br />
            <br />
            discount:<br />
            <asp:TextBox ID="discount_txt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="create_btn" runat="server" Text="Create" OnClick="create_btn_Click" />
        </div>
    </form>
</body>
</html>
