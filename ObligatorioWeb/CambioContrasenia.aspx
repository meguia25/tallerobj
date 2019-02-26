<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="CambioContrasenia.aspx.cs" Inherits="ObligatorioWeb.CambioContrasenia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tm-contact-left-half tm-gray-bg">
            <div class="form-group">
                <asp:LinkButton ID="BtnVolver" runat="server" OnClick="BtnVolver_Click">Volver al menú</asp:LinkButton>
            </div>
            <h2 class="tm-section-title">Cambiar contraseña</h2>
            <div class="form-group">
                <asp:TextBox ID="TxtContrasenia" class="form-control" runat="server" Text="Contraseña nueva" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtContrasenia" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Button ID="BtnConfirmar" runat="server" type="submit"
                    class="btn btn-primary pull-xs-right tm-button tm-button-normal" Text="Guardar" OnClick="BtnConfirmar_Click" />
            </div>
            <div class="form-group">
                <asp:Label ID="LblMensaje" runat="server" Text="" />
            </div>
        </div>
    </div>
</asp:Content>
