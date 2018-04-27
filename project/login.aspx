<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="project.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
    <form id="form1" runat="server">
    <center>
        <img src="mit.png" width="11%" height="11%" />&nbsp; <a href="login.aspx" style="text-decoration: none;">
            <h1>
                MIT Boys Hostel</h1>
        </a>
        <asp:TextBox class="input" ID="TextBox1" runat="server" placeholder="Username" required></asp:TextBox>
        <br />
        <asp:TextBox class="input" ID="TextBox2" runat="server" TextMode="Password" placeholder="Password"
            required></asp:TextBox>
        <br />
        <br />
        <asp:Button class="button" ID="Button1" runat="server" Font-Bold="True" Text="LOGIN"
            OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Button class="button" ID="Button2" runat="server" Font-Bold="True" PostBackUrl="~/signup.aspx"
            Text="SIGNUP" />
    </center>
    </form>
</body>
</html>
