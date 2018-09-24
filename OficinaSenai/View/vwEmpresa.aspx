<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vwEmpresa.aspx.cs" Inherits="ExemploBD.View.vwEmpresa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblNome" runat="server" Text="EMPRESA"></asp:Label>
        <hr />
        <asp:Button ID="btnListarOS" runat="server" Text="Mostrar Ordens de Serviço" OnClick="btnListarOS_Click" />
    </form>
</body>
</html>
