using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObligatorioWeb
{
    public partial class MenuAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = (string)Session["Administrador"];
            if (u == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void BtnViaje_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroViaje.aspx");
        }
        protected void BtnTurista_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaTurista.aspx");
        }
        protected void BtnListado_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoViajes.aspx");
        }
        protected void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}