using ExemploBD.Models;
using ExemploBD.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploBD
{
    public partial class vwListarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["nome"] != null)
                {
                    PopulateGrid(Request.QueryString["nome"]);
                }
                else
                {
                    PopulateGrid("");
                }

            }
        }

        public void PopulateGrid(string nome)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            DataTable dt = clienteDao.ListarTodos(nome);

            gdvCliente.DataSource = dt;
            gdvCliente.DataBind();

        }

        protected void gdvCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            PopulateGrid(txtNome.Text);
        }

        protected void gdvCliente_RowCommand(object sender,
            GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("AddNew"))
                {
                    
                    Cliente cliente = new Cliente();
                    cliente.Nome = (gdvCliente.FooterRow.
                        FindControl("txtNomeFooter") as TextBox).Text;
                    cliente.Rg = (gdvCliente.FooterRow.
                        FindControl("txtRgFooter") as TextBox).Text;
                    cliente.Cpf = (gdvCliente.FooterRow.
                        FindControl("txtCpfFooter") as TextBox).Text;
                    ClienteDAO clienteDao = new ClienteDAO();
                    if (clienteDao.Inserir(cliente) != null)
                    {
                        PopulateGrid("");
                        lblResultado.Text = "Cliente Inserido com sucesso!";
                    }
                }
                else if (e.CommandName.Equals("Endereco"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    //GridViewRow row = gdvCliente.SelectedRow;
                    lblResultado.Text = index.ToString();

                    Cliente cliente = new Cliente();

                    cliente.Id = index;
                    
                    

                    if (cliente != null)
                    {

                        Session["cliente"] = cliente;
                        Response.Redirect("~/View/vwEndereco.aspx");
                    }

                }
            }
            catch (Exception ee)
            {
                lblResultado.Text = "Deu Erroo";
            }
        }

        protected void gdvCliente_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gdvCliente.EditIndex = e.NewEditIndex;
            PopulateGrid("");
        }

        protected void gdvCliente_RowDeleting(object sender,
            GridViewDeleteEventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Id = Convert.ToInt32(gdvCliente.DataKeys[e.RowIndex]
                .Value.ToString())
            };
            ClienteDAO clienteDAO = new ClienteDAO();
            if (clienteDAO.Deletar(cliente) != null)
            {
                PopulateGrid("");
                lblResultado.Text = "Cliente Deletado com sucesso!";
            }
            else
            {
                lblResultado.Text = "Erro ao deletar Cliente(o mesmo possui um endereço cadastrado)";
            }

        }

        protected void gdvCliente_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Id = Convert.ToInt32(gdvCliente.DataKeys[e.RowIndex]
                .Value.ToString()),
                Nome = (gdvCliente.Rows[e.RowIndex].FindControl("txtNome")
                as TextBox).Text,
                Rg = (gdvCliente.Rows[e.RowIndex].FindControl("txtRg")
                as TextBox).Text,
                Cpf = (gdvCliente.Rows[e.RowIndex].FindControl("txtCpf")
                as TextBox).Text
            };
            ClienteDAO clienteDao = new ClienteDAO();
            if (clienteDao.Alterar(cliente) != null)
            {
                gdvCliente.EditIndex = -1;
                PopulateGrid("");
                lblResultado.Text = "Cliente Alterado com Sucesso!";
            }
            else
            {
                lblResultado.Text = "Folha ao alterar cliente";
            }
        }

        protected void gdvCliente_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gdvCliente.EditIndex = -1;
            PopulateGrid("");
        }


    }
}