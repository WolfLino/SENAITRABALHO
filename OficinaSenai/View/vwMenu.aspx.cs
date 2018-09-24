using ExemploBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OficinaSenai.View
{
    public partial class vwMenu : System.Web.UI.Page
    {
        Cliente c;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cliente"] != null)
            {
                c = Session["cliente"] as Cliente;
                lblCliente.Text = "Id: " + c.Id + " Nome: " + c.Nome;
            }
            else
            {
                Response.Redirect("~/View/vwLogin.aspx");
            }
        }
    }
}