<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="RegistroViaje.aspx.cs" Inherits="ObligatorioWeb.RegistroViaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">
        <asp:LinkButton ID="BtnVolver" runat="server" OnClick="BtnVolver_Click">Volver al menú</asp:LinkButton>
    </div>
    <div class="form-group">
        <asp:TextBox ID="TxtFechaInicio" Text="Fecha inicio" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:TextBox ID="TxtFechaFin" Text="Fecha fin" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="BtnChequear" runat="server" type="submit"
            class="btn btn-primary pull-xs-right tm-button tm-button-normal" Text="Vehiculos disponibles" OnClick="BtnChequear_Click" />
    </div>
    <div class="form-group">
        <asp:DropDownList ID="DDLTuristas" runat="server" AutoPostBack="true"></asp:DropDownList>
        <asp:DropDownList ID="DDLVehiculos" runat="server" AutoPostBack="true"></asp:DropDownList>
    </div>
    <div class="form-group">
        <asp:CheckBox ID="ChkGuia" runat="server" Text="Guia turistico" />
    </div>
    <div class="form-group">
        <asp:Button ID="BtnALta" runat="server" type="submit"
            class="btn btn-primary pull-xs-right tm-button tm-button-normal" Text="Guardar" OnClick="BtnAlta_Click" />
    </div>
    <div class="form-group">
        <asp:Label ID="LblMensaje" runat="server" Text="" />
    </div>
</asp:Content>
