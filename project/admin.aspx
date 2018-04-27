<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="project.admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DASHBOARD</title>
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
    <form id="form1" runat="server">
    <center>
        <img src="mit.png" width="11%" height="11%" />&nbsp; <a href="admin.aspx" style="text-decoration: none;">
            <h1>
                MIT Boys Hostel</h1>
        </a>
        <asp:Button class="button" ID="Button1" runat="server" Font-Bold="True" PostBackUrl="~/insert.aspx"
            Text="INSERT" />
        <br />
        <br />
        <asp:Button class="button" ID="Button2" runat="server" Font-Bold="True" PostBackUrl="~/delete.aspx"
            Text="DELETE" />
        <br />
        <br />
        <asp:Button class="button" ID="Button3" runat="server" Font-Bold="True" Text="UPDATE"
            PostBackUrl="~/update.aspx" />
        <br />
        <br />
        <asp:Button class="button" ID="Button4" runat="server" Font-Bold="True" Text="SHOW"
            PostBackUrl="~/show.aspx" />
        <br />
        <br />
        <asp:Button class="button" ID="Button5" runat="server" Font-Bold="True" Text="LOGOUT"
            OnClick="Button5_Click" />
    </center>
    </form>
</body>
</html>
