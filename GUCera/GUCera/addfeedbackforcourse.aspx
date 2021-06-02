<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addfeedbackforcourse.aspx.cs" Inherits="Gucera.addfeedbackforcourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Comment :<br />
            <asp:TextBox ID="comment"  runat="server"></asp:TextBox>
            <br />
            <br />
            Course ID:<br />
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="feedback" runat="server" Text="submit feedback" OnClick="feedback_Click" />
            <br />
            <br />
           <asp:Button ID="backtohome" runat="server" Text="Back to Home" OnClick="backtohome_Click" />
        </div>
    </form>
</body>
</html>
