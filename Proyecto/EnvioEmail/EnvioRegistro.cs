using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

using System.Diagnostics;
using System.IO;
using System.Text;
namespace Proyecto.EnvioEmail
{
    public class EnvioRegistro
    {

        public string codigo;
            
        public EnvioRegistro()
        {
            this.codigo = "";

        }

        public void Enviar(string correo, string nombre)
        {

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            SmtpClient smtp = new SmtpClient();
            mail.From = new MailAddress("jsebastianmg00@gmail.com");
            smtp.Port = 587; //25; //465; //587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("jsebastianmg00@gmail.com", "20171020059");
            smtp.Host = "smtp.gmail.com";
            mail.To.Add(correo);
            mail.Subject = "Codigo de registro";
            Random rdm = new Random();
            this.codigo = Convert.ToString(rdm.Next(100000, 999999));
            String mensaje = "Hola " + nombre + " tu codigo de registro es " + codigo;
            mail.Body = @mensaje;
           // try
           // {
                smtp.Send(mail);
            //  }
            //  catch (SmtpException e)
            //  {
            //e.Message;
          //  }
          //  finally
          //   {
            smtp.Dispose();
        //    }
            

        }
        


    }
    
}