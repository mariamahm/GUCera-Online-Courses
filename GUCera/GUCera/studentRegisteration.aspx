<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentRegisteration.aspx.cs" Inherits="GUCera.studentRegisteration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Register As A Student<br />
            <br />
            First Name:<br />
            <asp:TextBox ID="fname_txt" runat="server" MaxLength="20"></asp:TextBox>
            <br />
            <br />
            Last Name:<br />
            <asp:TextBox ID="lname_txt" runat="server" MaxLength="20"></asp:TextBox>
            <br />
            <br />
            Password:<br />
            <asp:TextBox ID="pass_txt" runat="server" MaxLength="20"></asp:TextBox>
            <br />
            <br />
            E-mail:<br />
            <asp:TextBox ID="mail_txt" runat="server" MaxLength="50"></asp:TextBox>
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
            <asp:Button ID="studentReg_btn" runat="server" Text="Register" OnClick="studentReg_btn_Click" />
        </div>
    </form>
</body>
</html>
