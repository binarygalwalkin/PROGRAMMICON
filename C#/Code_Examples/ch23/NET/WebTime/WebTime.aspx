<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebTime.aspx.cs" Inherits="WebTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>&nbsp;Simple Web Form Example</title>
    <style type="text/css">
        .timeStyle {
            color: #FFFF00;
            font-size: xx-large;
            background-color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Current time on the Web server:</h1>
        <p>
            <asp:Label ID="timeLabel" runat="server" CssClass="timeStyle"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
