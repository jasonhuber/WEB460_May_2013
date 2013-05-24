<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calculator.aspx.cs" Inherits="calculator" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        alert('<%=btnTest.ClientID%>');
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" /><br />
        <asp:Button ID="btnTest" runat="server" Text="Add" /><br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>