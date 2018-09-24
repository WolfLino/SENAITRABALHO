<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vwEndereco.aspx.cs" Inherits="ExemploBD.vwEndereco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <title></title>

    <style>
        .jumbotron {
            width: 600px;
            margin-top: 20px;
            padding: 12px;
            margin-left: auto;
            margin-right: auto;
            border-radius: 10px 10px 10px 10px;
        }

        .negrito {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <div>
                <asp:Label class="negrito" ID="lblCliente" runat="server" Text="Label"></asp:Label>
            </div>
            <hr />
            <div class="row">
                <div class="col-md-6">
                    <asp:Label ID="lblRua" runat="server" Text="Rua: "></asp:Label>
                    <asp:TextBox class="form-control" ID="txtRua" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblBairro" runat="server" Text="Bairro: "></asp:Label>
                    <asp:TextBox class="form-control" CssClass="form-control" ID="txtBairro" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <asp:Label ID="Label1" runat="server" Text="Complemento: "></asp:Label>
                    <asp:TextBox class="form-control" ID="txtComplemento" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-2">
                    <asp:Label ID="Label2" runat="server" Text="Numero: "></asp:Label>
                    <asp:TextBox class="form-control" CssClass="form-control" ID="txtNumero" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="Label3" runat="server" Text="Cep: "></asp:Label>
                    <asp:TextBox class="form-control" CssClass="form-control" ID="txtCep" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />

            <asp:Button class="btn btn-success" ID="btnAdicionar" Text="Adicionar" runat="server" OnClick="btnAdicionar_Click" />
            <asp:Button class="btn btn-warning" ID="btnVoltar" Text="Voltar" runat="server" OnClick="btnVoltar_Click" />
            <%--<asp:Button class="btn btn-danger" ID="btnDeletar" Text="Deletar" runat="server" />
            <asp:Button class="btn btn-info" ID="btnBuscar" Text="Buscar" runat="server" />--%>
            <br />
            <asp:Label ID="lblResultado" runat="server" Font-Size="X-Large" ForeColor="#009933"></asp:Label>
            <br />


        <div class="table-responsive">
            <asp:GridView CssClass="table table-striped" ID="gridGeral" runat="server" DataKeyNames="idendereco" AutoGenerateColumns="False" OnRowEditing="gridGeral_RowEditing" OnRowUpdating="gridGeral_RowUpdating" OnRowCancelingEdit="gridGeral_RowCancelingEdit" OnRowDeleting="gridGeral_RowDeleting" >
                <Columns>
                    <asp:TemplateField HeaderText="Rua">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtRua" runat="server" Text='<%# Bind("rua") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("rua") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Numero">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNumero" runat="server" Text='<%# Bind("numero") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("numero") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Bairro">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBairro" runat="server" Text='<%# Bind("bairro") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("bairro") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cep">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCep" runat="server" Text='<%# Bind("cep") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("cep") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Complemento">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtComplemento" runat="server" Text='<%# Bind("comp") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("comp") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Operações">
                        <EditItemTemplate>
                            <asp:LinkButton ID="btnSalvar" runat="server" CommandName="Update">Salvar</asp:LinkButton>
                            <asp:LinkButton ID="btnCancelar" runat="server" CommandName="Cancel">Cancelar</asp:LinkButton>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="btnEditar" runat="server" CommandName="Edit">Editar</asp:LinkButton>
                            <asp:LinkButton ID="btnDeletar" runat="server" CommandName="Delete">Deletar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

         </div>


    </form>
</body>
</html>
