<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorViewAssignments.aspx.cs" Inherits="GUCera.InstructorViewAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="courseenter" runat="server" Text="Enter Course ID:"></asp:Label>
        </div>
        <asp:TextBox ID="course" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="view" runat="server" Text="View Assignments" OnClick="view_Click" /> 
    </form>
</body>
</html>
