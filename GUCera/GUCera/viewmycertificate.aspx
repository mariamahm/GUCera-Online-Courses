<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewmycertificate.aspx.cs" Inherits="Gucera.viewmycertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
            
            Course ID<br />
            <br />
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="viewcertificate" runat="server" Text="View Certificate" OnClick="viewcertificate_Click" />
            <br />
            <br />
            <asp:Button ID="backtohome" runat="server" Text="Back to Home" OnClick="backtohome_Click" />
        </div>
    </form>
</body>
</html>
