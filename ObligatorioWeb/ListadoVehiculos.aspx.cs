using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatorioDominio.Fachada;

namespace ObligatorioWeb
{
    public partial class ListadoVehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = (string)Session["Turista"];
            if (u == null)
            {
                Response.Redirect("Login.aspx");
            }
            GRVVehiculos.DataSource = Fachada.Instancia.listadoTodosLosVehiculos();
            GRVVehiculos.DataBind();
        }
        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuTurista.aspx");
        }
    }
}