using ExemploBD.Models;
using ExemploBD.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploBD.View
{
    public partial class vwLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginDAO dao = new LoginDAO();
            Cliente cliente = new Cliente()
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text
            };

            cliente = dao.Logar(cliente);

            if (cliente != null)
            {
                Session["cliente"] = cliente;
                Response.Redirect("~/View/vwMenu.aspx");
            }else
            {
                lblResultado.Text = "O login ou a senha estão incorretos";
            }


        }
    }
}