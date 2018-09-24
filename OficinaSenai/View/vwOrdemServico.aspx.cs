using ExemploBD.Models;
using ExemploBD.Models.DAO;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace OficinaSenai.View
{
    public partial class vwOrdemServico : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
            {
                PopulateGrid(txtIdCliente.Text);
            }
        }

        protected void PopulateGrid(string idCliente)
        {
            OrdemServicoDAO ordemServicoDAO = new OrdemServicoDAO();
            DataTable dt = ordemServicoDAO.BuscarPorCliente(Convert.ToInt32(idCliente));

            gdvOrdemServico.DataSource = dt;
            gdvOrdemServico.DataBind();
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/vwEmpresa.aspx");
        }

        protected void gdvOrdemServico_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Alter"))
            {

            }
        }

        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrdemServicoDAO ordemServicoDAO = new OrdemServicoDAO();
            OrdemServico ordemServico = new OrdemServico()
            {
                
            };

            ordemServicoDAO.Alterar(ordemServico);
        }
    }
}