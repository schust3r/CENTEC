<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Exito.aspx.cs" Inherits="Exito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <div id="top">
            <asp:Image ID="Image1" runat="server" Height="45px" ImageUrl="~/Res/Logo.png" Width="287px" />
        </div>

        <div id="center">

            <asp:Image ID="Image2" runat="server" Height="222px" ImageUrl="~/Res/mat_success.png" Width="598px" />

        </div>
        
        <style>
           #center { width:600px; height:500px; margin-left:auto; margin-right:auto; margin-top:150px}
           #top { margin-left:30px; margin-top:30px;}
           #data {margin-top:30px; margin-left:20%; margin-right:20% }
        </style>
    
    </form>
</body>
</html>
