<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ListadoViajes.aspx.cs" Inherits="ObligatorioWeb.ListadoViajes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="tm-flex">
        <div class="tm-contact-left-half tm-gray-bg">
            <div class="form-group">
                <asp:linkbutton id="BtnVolver" runat="server" onclick="BtnVolver_Click">Volver al menú</asp:linkbutton>
            </div>
            <div class="form-group">
                <h1>Listado de viajes entre dos fechas</h1>
            <div class="form-group">
                <asp:TextBox class="form-control" runat="server" ID="TxtFechaInicial" Text="Nombre"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtFechaInicial" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:TextBox class="form-control" runat="server" ID="TxtFechaFinal" Text="Contrasenia"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtFechaFinal" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Button ID="BtnMostrar" runat="server" type="submit" 
                    class="btn btn-primary pull-xs-right tm-button tm-button-normal" Text="Submit" OnClick="BtnMostrar_Click" />
            </div>
                <asp:gridview id="GRVViajes" runat="server"></asp:gridview>
            </div>
        </div>
    </div>
</asp:Content>
