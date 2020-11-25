using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto.EnvioEmail;

namespace Proyecto
{
    public partial class About : Page
    {

        EnvioRegistro registro = new EnvioRegistro();


        protected void ButtonConfimar_Click1(object sender, EventArgs e)
        {
            if (Application["codigo"].ToString() == TextCodigo.Text){

                LabelCodigo.Text = "Usted esta registrado";
                //ButtonConfirmar.Dispose();

            }
            else
            {
            
                LabelCodigo.Text = "Codigo incorrecto vuelva a digitarlo";
            
            }

        }

    }
    
}