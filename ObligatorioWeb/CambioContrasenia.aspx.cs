using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatorioDominio.Fachada;

namespace ObligatorioWeb
{
    public partial class CambioContrasenia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = (string)Session["Turista"];
            if (u == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
            bool cambioContrasenia = false;
            string nuevaContrasenia = this.TxtContrasenia.Text;
            string usuario = Session["NDocumento"].ToString();

            cambioContrasenia = Fachada.Instancia.cambiarContraseña(usuario, nuevaContrasenia);   
            if (cambioContrasenia)
            {
                LblMensaje.Text = "Cambio de contraseña";

            }
            else
            {
                LblMensaje.Text = "Cambio de contraseña, incorrecta";
            }
        }
        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuTurista.aspx");
        }
    }
}