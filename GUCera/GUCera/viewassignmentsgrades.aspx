<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewassignmentsgrades.aspx.cs" Inherits="Gucera.viewassignmentsgrades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Assignment Type<br />
            <br />
            <asp:TextBox ID="assigntype" runat="server"></asp:TextBox>
            <br />
            <br />
            Assignment number<br />
            <br />
            <asp:TextBox ID="assignnumber" runat="server"></asp:TextBox>
            <br />
            <br />
            Course ID<br />
            <br />
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
             <br />
             <br />
            <asp:Button ID="viewgrades" runat="server" Text="View Grades" OnClick="viewgrades_Click" style="height: 29px" />
            <br />
            <br />
            <asp:Button ID="backtohome" runat="server" Text="Back to Home" OnClick="backtohome_Click" />
        </div>
    </form>
</body>
</html>
