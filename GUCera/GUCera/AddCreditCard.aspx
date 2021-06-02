<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCreditCard.aspx.cs" Inherits="GUCera.AddCreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add Credit Card Information<br />
            <br />
            Card Number:<br />
            <asp:TextBox ID="CardNumber_txt" runat="server"></asp:TextBox>
            <br />
            <br />
            Card Holder Name:<br />
            <asp:TextBox ID="CardHolder_txt" runat="server"></asp:TextBox>
            <br />
            <br />
            Expiry Date:<br />
            <asp:TextBox ID="expiryDate_txt" runat="server"></asp:TextBox>
            <br />
            <br />
            CVV:<br />
            <asp:TextBox ID="CVV_txt" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="Add" runat="server" Text="Add" OnClick="Add_Click" />
    </form>
</body>
</html>
