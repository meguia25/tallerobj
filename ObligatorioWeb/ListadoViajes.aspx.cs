using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatorioDominio.Fachada;

namespace ObligatorioWeb
{
    public partial class ListadoViajes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = (string)Session["Administrador"];
            if (u == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicial = DateTime.Parse(this.TxtFechaInicial.Text);
            DateTime fechaFinal = DateTime.Parse(this.TxtFechaFinal.Text);

            GRVViajes.DataSource = Fachada.Instancia.listadoViajesEntreDosFechas(fechaInicial,fechaFinal);
            GRVViajes.DataBind();
        }
        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuTurista.aspx");
        }
    }
}