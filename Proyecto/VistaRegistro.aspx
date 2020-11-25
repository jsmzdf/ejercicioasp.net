<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaRegistro.aspx.cs" Inherits="Proyecto._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div  class="container">
        <div  class="form-group">
            <asp:Label ID="LabelNombres" runat="server" Text="Nombres"></asp:Label>
        </div>
        <div  class="form-group">
            <asp:TextBox ID="TextNombres" runat="server" class="form-control form-control-lg"></asp:TextBox>
        </div>
        <div  class="form-group">
            <asp:Label ID="LabelApellidos" runat="server" Text="Apellidos"></asp:Label>
        </div>
        <div  class="form-group" >
            <asp:TextBox ID="TextApellidos" runat="server" class="form-control form-control-lg"></asp:TextBox>
        </div>
        <div  class="form-group">
            <asp:Label ID="LabelCorreo" runat="server" Text="Correo"></asp:Label>
        </div>
        <div  class="form-group">
            <asp:TextBox ID="TextCorreo" runat="server" placeholder="name@example.com" class="form-control form-control-lg"></asp:TextBox>
        </div>
        <div  class="form-group">
            <asp:Label ID="LabelClave" runat="server" Text="Clave"></asp:Label>
        </div>
        <div  class="form-group" >
            <asp:TextBox ID="TextClave" runat="server" class="form-control form-control-lg" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="ButtonRegistrar" runat="server" Text="Registrar" class="btn btn-primary" OnClick="ButtonRegistrar_Click1"/>
        </div>


    </div>
  

</asp:Content>
