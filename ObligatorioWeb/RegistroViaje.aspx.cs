using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatorioDominio.Fachada;

namespace ObligatorioWeb
{
    public partial class RegistroViaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = (string)Session["Administrador"];
            if (u == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                DDLTuristas.DataSource = Fachada.Instancia.listadoTuristas();
                DDLTuristas.DataTextField = "Nombre";
                DDLTuristas.DataValueField = "Nombre";
                DDLTuristas.DataBind();
            }
        }
        protected void BtnChequear_Click(object sender, EventArgs e)
        {
            DateTime fechaInicial = DateTime.Parse(this.TxtFechaInicio.Text);
            DateTime fechaFinal = DateTime.Parse(this.TxtFechaFin.Text);
            DDLVehiculos.DataSource = Fachada.Instancia.listadoVehiculosDisponibles(fechaInicial, fechaFinal);
            DDLVehiculos.DataTextField = "Matricula";
            DDLVehiculos.DataValueField = "Matricula";
            DDLVehiculos.DataBind();
        }
        protected void BtnAlta_Click(object sender, EventArgs e)
        {
            bool nuevoViaje = false;
            DateTime fechaInicial = DateTime.Parse(this.TxtFechaInicio.Text);
            DateTime fechaFinal = DateTime.Parse(this.TxtFechaFin.Text);
            string unaMatricula = (DDLVehiculos.SelectedItem.Text);
            int unNDocumento = int.Parse(DDLTuristas.SelectedItem.Text);

            nuevoViaje = Fachada.Instancia.agregarViaje(fechaInicial, fechaFinal, unaMatricula, unNDocumento);
            LblMensaje.Text = "Ingreso de viaje realizada";
        }
        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuTurista.aspx");
        }
    }
}