<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Promocodes.aspx.cs" Inherits="GUCera.Promocodes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="create_hl" runat="server" NavigateUrl="~/createPromocode.aspx">Create new Promocode</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="issue_hl" runat="server" NavigateUrl="~/issuePromocode.aspx">Issue Promocode to Student</asp:HyperLink>
        </div>
    </form>
</body>
</html>
