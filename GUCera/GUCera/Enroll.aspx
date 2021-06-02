<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Enroll.aspx.cs" Inherits="GUCera.Enroll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Course Enrollment:<br />
        </div>
        <p>
            Please Enter Your ID:</p>
        <asp:TextBox ID="UserID_txt" runat="server"></asp:TextBox>
        <br />
        <br />
        Please Enter Course ID:<br />
        <br />
        <asp:TextBox ID="CourseID_txt" runat="server"></asp:TextBox>
        <br />
        <br />
        Please Enter The Instructor&#39;s ID:<br />
        <br />
        <asp:TextBox ID="InstructorID_txt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Enroll_btn" runat="server" Text="Enroll" OnClick="Enroll_btn_Click" />
    </form>
</body>
</html>
