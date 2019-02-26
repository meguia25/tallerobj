using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatorioDominio.Fachada;

namespace ObligatorioWeb
{
    public partial class AltaTurista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = (string)Session["Administrador"];
            if (u == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void BtnAlta_Click(object sender, EventArgs e)
        {
            bool altaTurista = false;
            string nombre = this.TxtNombre.Text;
            string contrasenia = this.TxtNombre.Text;
            string pais = this.TxtNombre.Text;
            int nDocumento = int.Parse(this.TxtNombre.Text);

            altaTurista = Fachada.Instancia.agregarTurista(nombre, pais, nDocumento, contrasenia);
            if (altaTurista)
            {
                LblMensaje.Text = "Alta de turista correcta";

            }
            else
            {
                LblMensaje.Text = "Alta de turista incorrecta";
            }
        }
        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuTurista.aspx");
        }
    }
}