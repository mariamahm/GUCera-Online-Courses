<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="GUCera.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="allcourses_hl" runat="server" NavigateUrl="~/allCourses.aspx">All Courses</asp:HyperLink>
&nbsp;&nbsp;
            <asp:HyperLink ID="nonacceptedcourses_hl" runat="server" NavigateUrl="~/nonAcceptedCourses.aspx">Accept Courses</asp:HyperLink>
&nbsp;&nbsp;
            <asp:HyperLink ID="promocodes_hl" runat="server" NavigateUrl="~/Promocodes.aspx">Promocodes</asp:HyperLink>
&nbsp;&nbsp;
            </div>
    </form>
</body>
</html>
