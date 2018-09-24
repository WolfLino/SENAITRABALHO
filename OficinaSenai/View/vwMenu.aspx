<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vwMenu.aspx.cs" Inherits="OficinaSenai.View.vwMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">

        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand" href="#">Oficina</a>
                </div>
                <ul class="nav navbar-nav">
                    <li class="active"><a href="#">Home</a></li>
                    <li><a href="vwEndereco.aspx">Cadastro Endereço</a></li>
                    <li><a href="#">Criar Ordem de Serviço</a></li>
                </ul>
            </div>
        </nav>
        <div class="text-center">
            <h1>Página Inical</h1>
            <h3>Ecolha umas das opções do Menu acima</h3>
            <asp:Label ID="lblCliente" runat="server" Text=""></asp:Label>
        </div>


    </form>
</body>
</html>
