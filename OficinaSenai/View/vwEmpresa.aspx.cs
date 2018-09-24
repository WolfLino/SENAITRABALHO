using System;
using System.Web.UI;

namespace ExemploBD.View
{
    public partial class vwEmpresa : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnListarOS_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/vwOrdemServico.aspx");
        }
    }
}