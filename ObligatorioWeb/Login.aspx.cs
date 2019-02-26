using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatorioDominio.EntidadesDeNegocio;
using ObligatorioDominio.Fachada;

namespace ObligatorioWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void btnLogin_Click(object sender, AuthenticateEventArgs e)
        {
            if (this.txtUsuario.Text == "" || this.txtContrasenia.Text == "")
            {
                lblMensaje.Text = "Debe ingresar usuario y contraseña";
            }
            else
            {
                String unUsuario = this.txtUsuario.Text;
                String contrasenia = this.txtContrasenia.Text;
                Usuario usu = Fachada.Instancia.Login(unUsuario, contrasenia);
                Session["rol"] = usu.Rol;
                Session["NDocumento"] = usu.Usu;
                if (usu.Rol == "Turista")
                {
                    Response.Redirect("MenuTurista.aspx");
                }
                else if(usu.Rol == "Administrador")
                {
                    Response.Redirect("MenuAdministrador.aspx");
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }

            }
        }
    }
}