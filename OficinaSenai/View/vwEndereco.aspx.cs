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
    public partial class vwEndereco : System.Web.UI.Page
    {
        Cliente c;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cliente"] != null)
            {
                c = Session["cliente"] as Cliente;
                lblCliente.Text = "Id: " + c.Id + " Nome: " + c.Nome;
            }
            if (!Page.IsPostBack)
            {
                ListarTodos();
            }

                

        }
        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            EnderecoDAO dao = new EnderecoDAO();
            Endereco endereco = new Endereco()
            {
                Rua = txtRua.Text,
                Bairro = txtBairro.Text,
                Complemento = txtComplemento.Text,
                Numero = txtNumero.Text,
                Cep = txtCep.Text,
                IdCliente = c.Id
            };

            if(endereco.Cep.Length == 8 && !String.IsNullOrEmpty(endereco.Rua) && !String.IsNullOrEmpty(endereco.Bairro) && !String.IsNullOrEmpty(endereco.Numero))
            {
                endereco = dao.Inserir(endereco);
                lblResultado.Text = "Endereco cadastrado com sucesso";
                ListarTodos();
            }
            else
            {
                lblResultado.Text = "Favor Preencher os campos Corretamente";
            }

        }


        public void ListarTodos()
        {
            EnderecoDAO dao = new EnderecoDAO();
            DataTable a = dao.ListarTodos(c);

            gridGeral.DataSource = a;
            gridGeral.DataBind();
        }

        protected void gridGeral_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridGeral.EditIndex = e.NewEditIndex;
            ListarTodos();
        }

        protected void gridGeral_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            EnderecoDAO dao = new EnderecoDAO();
            Endereco endereco = new Endereco()
            {
                Id = Convert.ToInt32(gridGeral.DataKeys[e.RowIndex].Value.ToString()),
                Rua = (gridGeral.Rows[e.RowIndex].FindControl("txtRua") as TextBox).Text,
                Numero = (gridGeral.Rows[e.RowIndex].FindControl("txtNumero") as TextBox).Text,
                Bairro = (gridGeral.Rows[e.RowIndex].FindControl("txtBairro") as TextBox).Text,
                Cep = (gridGeral.Rows[e.RowIndex].FindControl("txtCep") as TextBox).Text,
                Complemento = (gridGeral.Rows[e.RowIndex].FindControl("txtComplemento") as TextBox).Text
            };


            if(dao.Alterar(endereco) != null)
            {
                gridGeral.EditIndex = -1;
                ListarTodos();
                lblResultado.Text = "Alterado com sucesso";
            }
            else
            {
                lblResultado.Text = "Falha ao alterar";
            }
        }

        protected void gridGeral_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridGeral.EditIndex = -1;
            ListarTodos();
        }

        protected void gridGeral_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            EnderecoDAO dao = new EnderecoDAO();
            Endereco endereco = new Endereco()
            {
                Id = Convert.ToInt32(gridGeral.DataKeys[e.RowIndex].Value.ToString())
            };

            if(dao.Deletar(endereco) != null)
            {
                lblResultado.Text = "Deletado com sucesso";
                ListarTodos();
            }
            else
            {
                lblResultado.Text = "Erro ao deletar";
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/vwMenu.aspx");
        }
    }
}