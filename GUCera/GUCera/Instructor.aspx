<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instructor.aspx.cs" Inherits="GUCera.Instructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 723px">
            <span class="auto-style1"><strong>Add course:</strong></span><br />
            <br />
            Credit Hours: <br />
            <asp:TextBox ID="creditHours" runat="server"></asp:TextBox><br />
            Course Name: <br />
            <asp:TextBox ID="courseName" runat="server"></asp:TextBox><br />
            Price: <br />
            <asp:TextBox ID="price" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="InstAddCourse" runat="server" Text="Add Course" OnClick="InstAddCourse_Click" />
            <br />
            <br />
        </div>
        <hr />
        <br/>
        <div style="width: 723px">
            <span class="auto-style1"><strong>Choose a course to define assignments of different types:</strong></span><br />
            <br/>
            Course ID: <br />
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox><br/>
            Number: <br />
            <asp:TextBox ID="num" runat="server"></asp:TextBox><br/>
            Assignment Type: <br />
            <asp:TextBox ID="typ" runat="server"></asp:TextBox><br/>
            Full Grade: <br />
            <asp:TextBox ID="grade" runat="server"></asp:TextBox><br/>
            Assignment Weight: <br />
            <asp:TextBox ID="weigh" runat="server"></asp:TextBox><br/>
            Deadline: (as YYYY-MM-DD) <br />
            <asp:TextBox ID="deadlin" runat="server"></asp:TextBox><br/>
            <br/>
            Content: <br />
            <asp:TextBox ID="conten" runat="server"></asp:TextBox>
            <br />
            <br/>
            <asp:Button ID="DefineAssignmentOfCourseOfCertianType" runat="server" Text="Add Assignment to Course" OnClick="DefineAssignmentOfCourseOfCertianType_Click" />
            <br />
            <br />
        </div>
        <hr />
        <br />
        <asp:Button ID="viewAssigns" runat="server" Text="View the assignments/exams/projects submitted by the students" OnClick="viewAssigns_Click" />
        <br />
        <br />
        <hr />
        <strong>
        <br class="auto-style1" />
        </strong><span class="auto-style1"><strong>Grade submitted assignments/exams/projects: </strong></span>
        <br />
        <br />
        Student ID: <br />
        <asp:TextBox ID="sidd" runat="server"></asp:TextBox><br />
        Course ID: <br />
        <asp:TextBox ID="cidd" runat="server"></asp:TextBox><br />
        Assignment Number: <br />
        <asp:TextBox ID="numm" runat="server"></asp:TextBox><br />
        Assignment Type: <br />
        <asp:TextBox ID="typp" runat="server"></asp:TextBox><br />
        Grade: <br />
        <asp:TextBox ID="gradd" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="gradeAssigns" runat="server" Text="Submit Grade" OnClick="gradeAssigns_Click" />
        <br />
        <br />
        <hr />
        <br />
        <asp:Button ID="viewFs" runat="server" Text="View the feedback added by the students on my courses" OnClick="viewFs_Click" />
        <br />
        <br />
        <hr />
        <br />
        <span class="auto-style1"><strong>Issue certificate to a student upon course completion:</strong></span><br />
        <br />
        Course ID: <br />
        <asp:TextBox ID="ccid" runat="server"></asp:TextBox><br />
        Student ID: <br />
        <asp:TextBox ID="ssid" runat="server"></asp:TextBox><br />
        Issue Date: <br />
        <asp:TextBox ID="ddate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="IssueC" runat="server" Text="Issue" OnClick="IssueC_Click" /><br />

    </form>
</body>
</html>
