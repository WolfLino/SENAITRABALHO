<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vwListarCliente.aspx.cs" Inherits="ExemploBD.vwListarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <style> 
        .jumbotron {
            width: 800px;
            margin-top: 20px;
            padding: 12px;
            margin-left: auto;
            margin-right: auto;
            border-radius: 10px 10px 10px 10px;
        }
    </style>

    
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <div class="table-responsive">
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
                <br />
                <asp:GridView CssClass="table table-striped" ID="gdvCliente" runat="server"
                    AutoGenerateColumns="False" ShowFooter="True"
                    DataKeyNames="idcliente"
                    OnRowCommand="gdvCliente_RowCommand"
                    OnRowEditing="gdvCliente_RowEditing" OnRowCancelingEdit="gdvCliente_RowCancelingEdit" OnRowDeleting="gdvCliente_RowDeleting" OnRowUpdating="gdvCliente_RowUpdating">
                    <EmptyDataTemplate>
                        &nbsp;<asp:Label ID="lblVazio" runat="server" ForeColor="Red" Text="Sem resultados!"></asp:Label>
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:TemplateField HeaderText="Nome">
                            <EditItemTemplate>
                                <asp:TextBox ID="txtNome" runat="server" Text='<%# Bind("nome") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("nome") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox runat="server" ID="txtNomeFooter"></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="RG">
                            <EditItemTemplate>
                                <asp:TextBox ID="txtRg" runat="server" Text='<%# Bind("rg") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("rg") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox runat="server" ID="txtRgFooter"></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CPF">
                            <EditItemTemplate>
                                <asp:TextBox ID="txtCpf" runat="server" Text='<%# Bind("cpf") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("cpf") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtCpfFooter" runat="server"></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="E-mail">
                            <EditItemTemplate>
                                <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("email") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("email") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtEmailFooter" runat="server"></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Senha">
                            <EditItemTemplate>
                                <asp:TextBox ID="txtSenha" runat="server" Text='<%# Bind("senha") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("senha") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtSenhaFooter" runat="server"></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Operações">
                            <ItemTemplate>
                                <asp:LinkButton ID="lkbEditar" runat="server" Text="Editar"
                                    CommandName="Edit"></asp:LinkButton>
                                <asp:LinkButton ID="lkbDeletar" runat="server" Text="Deletar"
                                    CommandName="Delete"
                                    OnClientClick="return confirm('Deseja realmente deletar?');"></asp:LinkButton>
                                <asp:LinkButton ID="lkbEndrecos" runat="server" Text="Endereços"
                                    CommandName="Endereco" CommandArgument='<%# Bind("idcliente") %>'></asp:LinkButton>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:LinkButton ID="lkbSalvar" runat="server" Text="Salvar"
                                    CommandName="Update"></asp:LinkButton>
                                <asp:LinkButton ID="lkbCancelar" runat="server" Text="Cancelar"
                                    CommandName="Cancel"></asp:LinkButton>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:LinkButton ID="lkbInserir" runat="server"
                                    Text="Adicionar" CommandName="AddNew"
                                    CommandArgument='<%# Bind("idcliente") %>'></asp:LinkButton>
                            </FooterTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
