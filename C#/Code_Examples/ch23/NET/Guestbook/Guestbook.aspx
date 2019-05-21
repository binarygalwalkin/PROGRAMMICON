<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Guestbook.aspx.cs" Inherits="Guestbook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guestbook</title>
    <style type="text/css">
       .auto-style1 {
          width: 100%;
       }
       .textBoxWidth {
          width: 300px;
       }
       .textBoxHeight {
          height: 100px;
       }
       .gridViewWidth {
          width: 650px;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div>
          <h3>Please leave a message in our guestbook:</h3>
          <table class="auto-style1">
             <tr>
                <td>Name:</td>
                <td>
                   <asp:TextBox ID="nameTextBox" runat="server" CssClass="textBoxWidth"></asp:TextBox>
                </td>
             </tr>
             <tr>
                <td>E-mail:</td>
                <td>
                   <asp:TextBox ID="emailTextBox" runat="server" CssClass="textBoxWidth"></asp:TextBox>
                </td>
             </tr>
             <tr>
                <td>Tell the world:</td>
                <td>
                   <asp:TextBox ID="messageTextBox" runat="server" CssClass="textBoxWidth textBoxHeight" TextMode="MultiLine"></asp:TextBox>
                </td>
             </tr>
             <tr>
                <td>&nbsp;</td>
                <td>
                   <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
                   &nbsp;<asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" Text="Clear" />
                </td>
             </tr>
          </table>
          <br />
          <asp:GridView ID="messagesGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="gridViewWidth" DataKeyNames="MessageID" DataSourceID="messagesEntityDataSource" ForeColor="#333333" GridLines="None">
             <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
             <Columns>
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Message1" HeaderText="Message" SortExpression="Message1" />
             </Columns>
             <EditRowStyle BackColor="#999999" />
             <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
             <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
             <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
             <SortedAscendingCellStyle BackColor="#E9E7E2" />
             <SortedAscendingHeaderStyle BackColor="#506C8C" />
             <SortedDescendingCellStyle BackColor="#FFFDF8" />
             <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
          </asp:GridView>
          <asp:EntityDataSource ID="messagesEntityDataSource" runat="server" ConnectionString="name=GuestbookEntities" DefaultContainerName="GuestbookEntities" EnableFlattening="False" EnableInsert="True" EntitySetName="Messages">
          </asp:EntityDataSource>
       </div>

    </form>
</body>
</html>
