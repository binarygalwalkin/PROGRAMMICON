<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Options.aspx.cs" Inherits="Options" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sessions</title>
    <style type="text/css">
       .labelStyle {
          font-size: large;
          font-weight: bold;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <asp:Label ID="promptLabel" runat="server" CssClass="labelStyle" Text="Select a programming language:"></asp:Label>
       <asp:RadioButtonList ID="languageList" runat="server">
          <asp:ListItem Value="0-13-340695-4">Visual Basic</asp:ListItem>
          <asp:ListItem Value="0-13-337933-7">Visual C#</asp:ListItem>
          <asp:ListItem Value="0-13-299044-X">C</asp:ListItem>
          <asp:ListItem Value="0-13-337871-3">C++</asp:ListItem>
          <asp:ListItem Value="0-13-294094-9">Java</asp:ListItem>
       </asp:RadioButtonList>
       <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
       <asp:Label ID="responseLabel" runat="server" CssClass="labelStyle" Text="Welcome to Sessions!" Visible="False"></asp:Label>
       <br />
       <asp:Label ID="idLabel" runat="server" Visible="False"></asp:Label>
       <br />
       <asp:Label ID="timeoutLabel" runat="server" Visible="False"></asp:Label>
       <br />
       <asp:HyperLink ID="languageLink" runat="server" NavigateUrl="~/Options.aspx" Visible="False">Click here to select another language</asp:HyperLink>
       <br />
       <asp:HyperLink ID="recommendationsLink" runat="server" NavigateUrl="~/Recommendations.aspx" Visible="False">Click here to get book recommendations</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
