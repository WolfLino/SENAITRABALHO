<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vwLogin.aspx.cs" Inherits="ExemploBD.View.vwLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSenha" runat="server" Text="Senha: "></asp:Label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" ></asp:TextBox>
            <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text="" ></asp:Label>

        </div>
    </form>
</body>
</html>
