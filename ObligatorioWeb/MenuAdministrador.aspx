<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="MenuAdministrador.aspx.cs" Inherits="ObligatorioWeb.MenuAdministrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tm-flex">
        <div class="tm-sidebar sticky">
            <ul class="tm-main-nav-ul">
                <li class="tm-nav-item">
                    <asp:Button ID="BtnViaje" runat="server" type="submit" class="tm-nav-item-link tm-button"
                        Text="Ingreso viaje" OnClick="BtnViaje_Click" />
                </li>
                <li class="tm-nav-item">
                    <asp:Button ID="BtnTurista" runat="server" type="submit" class="tm-nav-item-link tm-button"
                        Text="Agregar turista" OnClick="BtnTurista_Click" />
                </li>
                <li class="tm-nav-item">
                    <asp:Button ID="BtnListado" runat="server" type="submit" class="tm-nav-item-link tm-button"
                        Text="Listado de viajes entre dos fechas" OnClick="BtnListado_Click" />
                </li>
                <li class="tm-nav-item">
                    <asp:Button ID="BtnCerrar" runat="server" type="submit" class="tm-nav-item-link tm-button"
                        Text="Cerrar Sesion" OnClick="BtnCerrarSesion_Click" />
                </li>
            </ul>
        </div>
    </div>
</asp:Content>
