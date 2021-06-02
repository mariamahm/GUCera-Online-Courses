<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewassignmentscontent.aspx.cs" Inherits="Gucera.Viewassignmentscontent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <div>
           
            <br />
            Course ID<br />
            <asp:TextBox ID="Courseid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="viewassigncontentt" runat="server" Text="View Assignment Content" OnClick="viewassigncontentt_Click" />
            <br />
            <br />
            <asp:Button ID="backtohome" runat="server" Text="Back to Home" OnClick="backtohome_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
