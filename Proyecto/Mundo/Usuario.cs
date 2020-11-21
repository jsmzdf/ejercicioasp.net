using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Mundo
{
    
    public class Usuario
    {
        protected string correo;
        protected string nombre;
        protected string clave;
        
        Usuario() {
            this.clave = "";
            this.correo = "";
            this.nombre = "";
           
        }
        
    }
}