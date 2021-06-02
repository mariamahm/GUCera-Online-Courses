<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Gucera.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="viewMyProfile" runat="server" Text="My Profile" OnClick="viewMyProfile_Click" />
            <br />
            <br />
            <asp:Button ID="courses" runat="server" Text="All Courses" OnClick="courses_Click" />
            <br />
            <br />
            <asp:Button ID="creditcard" runat="server" Text="Add Credit Card" OnClick="creditcard_Click" />
            <br />
            <br />
            <asp:Button ID="promos" runat="server" Text="My Promocodes" OnClick="promos_Click" />
            <br />
            <br />
            <asp:Button ID="Viewassigncontent" runat="server" Text="Assignments content" OnClick="Viewassigncontent_Click" />
            <br />
            <br />
            <asp:Button ID="submitassign" runat="server" Text="Submit Assignment" OnClick="submitassign_Click" />
            <br />
            <br />
            <asp:Button ID="viewgradesofassign" runat="server" Text="Grades" OnClick="viewgradesofassign_Click" />
            <br />
            <br />
            <asp:Button ID="addfeedbackforcourse" runat="server" Text="Add feedback for course" OnClick="addfeedbackforcourse_Click"/>
            <br />
            <br />
            <asp:Button ID="viewmycertificates" runat="server" Text="My certificates" OnClick="viewmycertificates_Click" />
         
        </div>
    </form>
</body>
</html>
