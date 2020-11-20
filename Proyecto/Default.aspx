<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div  class="container">
        <div  class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="TextBox1" runat="server" class="form-control form-control-lg"></asp:TextBox>
        </div>
        <div  class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Correo"></asp:Label>
        </div>
        <div  class="form-group" >
            <asp:TextBox ID="TextBox2" runat="server" placeholder="name@example.com" class="form-control form-control-lg"></asp:TextBox>
        </div>
        <div  class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Clave"></asp:Label>
        </div>
        <div  class="form-group">
            <asp:TextBox ID="TextBox3" runat="server" class="form-control form-control-lg"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="Button1" runat="server" Text="Ingresar" class="btn btn-primary" OnClick="Button1_Click1"/>
        </div>


    </div>
    <asp:ScriptManager runat="server">
            <Scripts>
               
                <asp:ScriptReference Name="EnvioMensajes.js" Assembly="System.Web" Path="~/Scripts/EnvioMensajes.js" />
          
             
            </Scripts>
        </asp:ScriptManager>

</asp:Content>
