<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ListadoViajesTurista.aspx.cs" Inherits="ObligatorioWeb.ListadoViajesTurista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tm-flex">
        <div class="tm-contact-left-half tm-gray-bg">
            <div class="form-group">
                <asp:LinkButton ID="BtnVolver" runat="server" OnClick="BtnVolver_Click">Volver al menú</asp:LinkButton>
            </div>
            <div class="form-group">
                <h1>Listado de viajes</h1>
                <asp:GridView ID="GRVViajes" runat="server"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
