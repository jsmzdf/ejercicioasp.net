using System;
using System.Web.UI;
using Proyecto.EnvioEmail;
namespace Proyecto
{
    public partial class _Default : Page
    {

       
        EnvioRegistro registro = new EnvioRegistro();


        protected void ButtonRegistrar_Click1(object sender, EventArgs e)
        {
             registro.Enviar(TextCorreo.Text, TextNombres.Text);
             Application["codigo"] = registro.codigo;
             Response.Redirect("VistaConfirmacion");

        }

    }
}