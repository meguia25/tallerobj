<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ObligatorioWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="form-group">
        <asp:Label ID="Label1"  class="form-control" runat="server" Text="Usuario:"></asp:Label>
        <asp:TextBox ID="txtUsuario"  class="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="Label2"  class="form-control" runat="server" Text="Contraseña:"></asp:Label>
        <asp:TextBox ID="txtContrasenia" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="btnLogin" class="btn btn-primary pull-xs-right tm-button tm-button-normal"  runat="server" OnClick="btnLogin_Click" Text="Login" />
    </div>   
    <div class="form-group">
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </div>   
</asp:Content>
