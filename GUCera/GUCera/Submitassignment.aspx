<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Submitassignment.aspx.cs" Inherits="Gucera.Submitassignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Submit Assignment<br />
            <br />
            Assignment Type:<br />
            <br />
            <asp:TextBox ID="assigntype" runat="server"></asp:TextBox>
            <br />
            <br />
            Assignment number:<br />
            <br />
            <asp:TextBox ID="assignnumber" runat="server"></asp:TextBox>
            <br />
            <br />
           
            Course ID:<br />
            <br />
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="submitassign" runat="server" Text="submit" OnClick="submitassign_Click" />
            <br />
            <br />
           <asp:Button ID="backtohome" runat="server" Text="Back to Home" OnClick="backtohome_Click" />
            <br />
        </div>
    </form>
</body>
</html>
