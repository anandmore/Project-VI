<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="project.update" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UPDATE RECORDS</title>
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
    <form id="form1" runat="server">
    <center>
        <img src="mit.png" width="11%" height="11%" />&nbsp; <a href="admin.aspx" style="text-decoration: none;">
            <h1>
                MIT Boys Hostel</h1>
        </a>
        <asp:TextBox class="input" ID="TextBox1" runat="server" placeholder="Unique ID" required
            type="number"></asp:TextBox>
        <br />
        <asp:TextBox class="input" ID="TextBox2" runat="server" placeholder="Room no." required
            type="number"></asp:TextBox>
        <br />
        <br />
        <asp:Button class="button" ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click"
            PostBackUrl="~/update.aspx" Text="UPDATE" />
        <br />
    </center>
    </form>
</body>
</html>
