using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto.Validacoin;
namespace Proyecto
{
    public partial class _Default : Page
    {

        Usuario usuario = new Usuario();
      


        protected void Button1_Click1(object sender, EventArgs e)
        {
            usuario.enviar(TextBox2.Text, TextBox1.Text, TextBox3.Text);
            
            TextBox1.Text = usuario.nombre;
                Application["email"] = TextBox2.Text;
                //Response.Redirect("About");
            




        }
    }
}