<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="MenuTurista.aspx.cs" Inherits="ObligatorioWeb.MenuTurista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tm-flex">
        <div class="tm-sidebar sticky">
            <ul class="tm-main-nav-ul">
                <li class="tm-nav-item">
                    <asp:Button ID="BtnVehiculos" runat="server" type="submit" class="tm-nav-item-link tm-button"
                        Text="Listado dev vehiculos" OnClick="BtnVehiculos_Click" />
                </li>
                <li class="tm-nav-item">
                    <asp:Button ID="BtnViajes" runat="server" type="submit" class="tm-nav-item-link tm-button"
                        Text="Listado de viajes" OnClick="BtnViajes_Click" />
                </li>
                <li class="tm-nav-item">
                    <asp:Button ID="BtnCambio" runat="server" type="submit" class="tm-nav-item-link tm-button"
                        Text="Cambio de contraseña" OnClick="BtnCambio_Click" />
                </li>
                <li class="tm-nav-item">
                    <asp:Button ID="BtnCerrar" runat="server" type="submit" class="tm-nav-item-link tm-button"
                        Text="Cerrar Sesion" OnClick="BtnCerrarSesion_Click" />
                </li>
            </ul>
        </div>
    </div>
</asp:Content>
