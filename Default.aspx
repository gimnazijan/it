<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="asp_css.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    </div>
    <p>
        <asp:Button class="dugme" ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br /><asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br /><asp:Button class="dugme" ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
    </p>
    </form>
</body>
</html>
