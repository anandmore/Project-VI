<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="project.signup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SIGNUP</title>
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
    <form id="form1" runat="server">
    <center>
        <img src="mit.png" width="11%" height="11%" />&nbsp;
        <a href="login.aspx" style="text-decoration:none;"><h1>
            MIT Boys Hostel</h1></a>
        <asp:TextBox class="input" ID="TextBox1" runat="server" placeholder="Name" required></asp:TextBox>
        &nbsp;&nbsp;
        <asp:TextBox class="input" ID="TextBox2" runat="server" placeholder="Username" required></asp:TextBox>
        <br />
        <asp:TextBox class="input" ID="TextBox3" runat="server" TextMode="Password" placeholder="Password"
            required></asp:TextBox>
        &nbsp;&nbsp;
        <asp:TextBox class="input" ID="TextBox4" runat="server" TextMode="Password" placeholder="Retype Password"
            required></asp:TextBox>
        <br />
        <asp:TextBox class="input" ID="TextBox5" runat="server" placeholder="Unique ID" required
            type="number"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:TextBox class="input" ID="TextBox6" runat="server" placeholder="Address" required></asp:TextBox>
        <br />
        <asp:TextBox class="input" ID="TextBox7" runat="server" placeholder="Age" required
            type="number" min="18" max="100"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:TextBox class="input" ID="TextBox8" runat="server" placeholder="Email" required
            type="email"></asp:TextBox>
        <br />
        <asp:TextBox class="input" ID="TextBox9" runat="server" placeholder="Contact" required
            type="text" MaxLength="10" pattern="[8,9]{1}[0-9]{9}"></asp:TextBox>
        <br />
        <br />
        <asp:Button class="button" ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click"
            Text="SUBMIT" />
        <br />
    </center>
    </form>
</body>
</html>
