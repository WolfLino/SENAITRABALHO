<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vwLogin.aspx.cs" Inherits="ExemploBD.View.vwLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
     <style type="text/css">
        .jumbotron {
            width: 400px;
            margin-top: 20px;
            margin-left: auto;
            padding: 12px;
            margin-right: auto;
            border-radius: 10px 10px 10px 10px;
        }
      
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox class="form-control" ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSenha" runat="server" Text="Senha: "></asp:Label>
            <asp:TextBox class="form-control" ID="txtSenha" runat="server" TextMode="Password" ></asp:TextBox>
            <br />
            <asp:Button CssClass="btn btn-default" ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text="" ></asp:Label>

        </div>
    </form>
</body>
</html>
