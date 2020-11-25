<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaConfirmacion.aspx.cs" Inherits="Proyecto.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Digite el codigo de confirmación enviado al correo</h1>
    <p>&nbsp;</p>
    <asp:TextBox ID="TextCodigo" runat="server" class="form-control form-control-lg"></asp:TextBox>
    <p>&nbsp;</p>
    <h3><asp:Label ID="LabelCodigo" runat="server" ></asp:Label></h3>
    <p>&nbsp;</p>
    <asp:Button ID="ButtonConfirmar" runat="server" Text="Confirmar registro" class="btn btn-primary" OnClick="ButtonConfimar_Click1"/>
        
    
    
</asp:Content>
