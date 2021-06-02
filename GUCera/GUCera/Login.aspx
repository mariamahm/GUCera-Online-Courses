<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Please Log in</p>
        <p>
            User ID: </p>
        <asp:TextBox ID="username_txt" runat="server"></asp:TextBox>
        <br />
        <br />
        Password:<br />
        <br />
        <asp:TextBox ID="password_txt" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:Button ID="login_btn" runat="server" Text="Login" OnClick="login" />
        </p>
        <p>
            Not a registered user?</p>
        <p>
            Register as a
            <asp:HyperLink ID="student_hl" runat="server" NavigateUrl="~/studentRegisteration.aspx">Student</asp:HyperLink>
            .</p>
        <p>
            or</p>
        <p>
            Register as an
            <asp:HyperLink ID="instr_hl" runat="server" NavigateUrl="~/instructorRegistration.aspx">Instructor</asp:HyperLink>
            .</p>
        <p>
            &nbsp;</p>
        Add Phone Number For User:<br />
        <br />
        User ID:<br />
        <asp:TextBox ID="uidmobile" runat="server"></asp:TextBox>
        <br />
        <br />
        Mobile Number:<br />
        <asp:TextBox ID="mobile" runat="server" MaxLength="20"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addmobile" runat="server" Text="Add" OnClick="addmobile_Click" />
        <br />
    </form>
</body>
</html>
