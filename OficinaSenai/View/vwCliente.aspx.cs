using ExemploBD.Models;
using ExemploBD.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploBD
{
    public partial class vwCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            Cliente cliente = new Cliente()
            {
                Nome = txtNome.Text,
                Cpf = txtCPF.Text,
                Rg = txtRG.Text
            };

            if (cliente.Nome.Length <= 45 && cliente.Cpf.Length == 11 && cliente.Rg.Length == 9)
            {
                cliente = clienteDao.Inserir(cliente);
                lblResultado.Text = "Cadastrado com sucesso";
                if (cliente != null)
                {
                    Session["cliente"] = cliente;
                    Response.Redirect("~/View/vwEndereco.aspx");
                }
            }
            else
                {
                    lblResultado.Text = "Favor Preencher os campos corretamente";
                }



            }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            Cliente c = clienteDao.BuscarPorId(Convert.ToInt32(txtId.Text));
            lblResultado.Text = "";
            if (c != null)
            {
                txtNome.Text = c.Nome;
                txtCPF.Text = c.Cpf;
                txtRG.Text = c.Rg;
            }else
            {
                txtNome.Text = "";
                txtCPF.Text = "";
                txtRG.Text = "";
            }
            
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            Cliente c = new Cliente()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nome = txtNome.Text,
                Cpf = txtCPF.Text,
                Rg = txtRG.Text
            };
            c = clienteDao.Alterar(c);
            if (c != null)
                lblResultado.Text = "Cliente alterado com sucesso!";
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            Cliente c = new Cliente()
            {
                Id = Convert.ToInt32(txtId.Text),
    
            };
            c = clienteDao.Deletar(c);
            if (c != null)
                lblResultado.Text = "Cliente deletado com sucesso!";
        }

        protected void btnEndereco_Click(object sender, EventArgs e)
        {

        }
    }
}