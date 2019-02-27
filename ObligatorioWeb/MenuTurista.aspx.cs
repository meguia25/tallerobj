using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatorioDominio.Fachada;
using ObligatorioDominio.EntidadesDeNegocio;

namespace ObligatorioWeb
{
    public partial class MenuTurista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = (string)Session["rol"];
            if (u == null && u == "Turista")
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void BtnVehiculos_Click(object sender, EventArgs e)
        {
             Response.Redirect("ListadoVehiculos.aspx");
        }
        protected void BtnViajes_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoViajesTurista.aspx");
        }
        protected void BtnCambio_Click(object sender, EventArgs e)
        {
            Response.Redirect("CambioContrasenia.aspx");
        }
        protected void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}