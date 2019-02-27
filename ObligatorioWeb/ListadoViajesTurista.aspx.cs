using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatorioDominio.Fachada;

namespace ObligatorioWeb
{
    public partial class ListadoViajesTurista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = (string)Session["Rol"];
            int n = int.Parse(Session["NDocumento"].ToString());
            if (u == null)
            {
                Response.Redirect("Login.aspx");
            }
            GRVViajes.DataSource = Fachada.Instancia.listadoViajesXTurista(n);
            GRVViajes.DataBind();
        }
        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuTurista.aspx");
        }
    }
}