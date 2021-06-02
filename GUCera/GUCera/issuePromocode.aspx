<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="issuePromocode.aspx.cs" Inherits="GUCera.issuePromocode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Issue Promocode<br />
            <br />
            student ID:<br />
            <asp:TextBox ID="studentID_txt" runat="server"></asp:TextBox>
            <br />
            code:<br />
            <asp:TextBox ID="promocode_txt" runat="server" MaxLength="6"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="issue_btn" runat="server" Text="Issue Promocode" OnClick="issue_btn_Click" />
        </div>
    </form>
</body>
</html>
