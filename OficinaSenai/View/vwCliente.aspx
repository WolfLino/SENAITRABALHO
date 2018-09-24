<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vwCliente.aspx.cs" Inherits="ExemploBD.vwCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <title>Cadastro de Cliente</title>

    <style type="text/css">
        .jumbotron {
            width: 600px;
            margin-top: 20px;
            margin-left: auto;
            /*border-width: 6px;
            border-style: ridge;
            border-color: #000000;*/
            padding: 12px;
            margin-right: auto;
            border-radius: 10px 10px 10px 10px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div class="jumbotron">
            <div class="row">
                <div class="col-md-2">
                    <asp:Label ID="lblId" runat="server" Text="Id: "></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtId" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">
                    <asp:Label ID="lblNome" runat="server" Text="Nome: "></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtNome" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblCPF" runat="server" Text="CPF: "></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtCPF" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblRG" runat="server" Text="RG: "></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtRG" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />
            <asp:Button class="btn btn-success" ID="btnAdicionar" Text="Adicionar" runat="server" OnClick="btnAdicionar_Click" />
            <asp:Button class="btn btn-warning" ID="btnAlterar" Text="Alterar" runat="server" OnClick="btnAlterar_Click" />
            <asp:Button class="btn btn-danger" ID="btnDeletar" Text="Deletar" runat="server" OnClick="btnDeletar_Click" />
            <asp:Button class="btn btn-info" ID="btnBuscar" Text="Buscar" runat="server" OnClick="btnBuscar_Click" />
            <br />
            <asp:Label ID="lblResultado" runat="server" Font-Size="X-Large" ForeColor="#009933"></asp:Label>
            <br />
            <br />

        </div>
    </form>



</body>
</html>
