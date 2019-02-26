<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ListadoVehiculos.aspx.cs" Inherits="ObligatorioWeb.ListadoVehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="tm-flex">
        <div class="tm-contact-left-half tm-gray-bg">
            <div class="form-group">
                <asp:linkbutton id="BtnVolver" runat="server" onclick="BtnVolver_Click">Volver al menú</asp:linkbutton>
            </div>
            <div class="form-group">
                <h1>Listado de Vehiculos</h1>
                <asp:gridview id="GRVVehiculos" runat="server"></asp:gridview>
            </div>
        </div>
    </div>
</asp:Content>
