<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vwOrdemServico.aspx.cs" Inherits="OficinaSenai.View.vwOrdemServico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtIdCliente" placeholder="ID Cliente" runat="server"></asp:TextBox>
            <asp:Button ID="btnListar" runat="server" Text="Listar Ordens de Serviços" OnClick="btnListar_Click" />
            <hr />
            <asp:GridView ID="gdvOrdemServico" runat="server" AutoGenerateColumns="False" OnRowCommand="gdvOrdemServico_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Número">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("idordem_serv") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Data de Solicitação">
                        <ItemTemplate>
                            <asp:Label ID="lblData" runat="server" Text='<%# Bind("data_solic") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Prazo">
                        <ItemTemplate>
                            <asp:Label ID="lblPrazo" runat="server" Text='<%# Bind("prazo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Total">
                        <ItemTemplate>
                            <asp:Label ID="lblTotal" runat="server" Text='<%# Bind("total") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:DropDownList ID="ddlStatus" runat="server" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                <asp:ListItem Value="1">Aberto</asp:ListItem>
                                <asp:ListItem Value="2">Em Andamento</asp:ListItem>
                                <asp:ListItem Value="3">Finalizado</asp:ListItem>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
        </div>
    </form>
</body>
</html>
