<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorRegistration.aspx.cs" Inherits="GUCera.instructorRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Register As An Instructor<br />
            <br />
            First Name:<br />
            <asp:TextBox ID="fname_txt" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            <br />
            Last Name:<br />
            <asp:TextBox ID="lname_txt" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            <br />
            Password:<br />
            <asp:TextBox ID="pass_txt" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            <br />
            E-mail:<br />
            <asp:TextBox ID="mail_txt" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            <br />
            Gender: (Please enter &#39;0&#39; for male or &#39;1&#39; for female)<br />
            <asp:TextBox ID="gender_txt" runat="server" MaxLength="1"></asp:TextBox>
            <br />
            <br />
            Address:<br />
            <asp:TextBox ID="address_txt" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="instructorReg_btn" runat="server" Text="Register" OnClick="instructorReg_btn_Click" />
        </div>
    </form>
</body>
</html>
