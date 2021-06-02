<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorViewFeedbacks.aspx.cs" Inherits="GUCera.InstructorViewFeedbacks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="courseenterr" runat="server" Text="Enter Course ID:"></asp:Label>
        </div>
        <asp:TextBox ID="courze" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="viewF" runat="server" Text="View Feedback" OnClick="viewF_Click" />
    </form>
</body>
</html>
