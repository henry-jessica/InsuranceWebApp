<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="InsuranceWebApp.InsuranceForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>JJ Insurance Company</h1>
       <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label><br/>
        <asp:TextBox ID="txbAge" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label2" runat="server" Text="Location"></asp:Label><br/>
        <asp:TextBox ID="tbxLocation" runat="server"></asp:TextBox><br/><br/>
        <asp:Button ID="Button1" runat="server" Text="Calcule" OnClick="Button1_Click" />
        <br /><br /><br />
        premium: <asp:Label ID="lblResult" runat="server" Text="0"></asp:Label>

    </form>
    
</body>
</html>
