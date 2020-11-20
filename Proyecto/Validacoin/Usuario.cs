using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
namespace Proyecto.Validacoin
{
    public class Usuario
    {


        public string correo;
        public string nombre;
        public string clave;
        public string salida;
        public Usuario()
        {
            this.clave = "";
            this.correo = "";
            this.nombre = "";
            this.salida = "";
        }

        public void enviar(string correo, string clave, string nombre)
        {



            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            SmtpClient smtp = new SmtpClient();
            mail.From = new MailAddress("jsebastianmg00@gmail.com");
            smtp.Port = 587; //25; //465; //587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("jsebastianmg00@gmail.com", "2171020059");
            smtp.Host = "smtp.gmail.com";
            mail.To.Add(correo);
            //mail.IsBodyHtml = true;
            mail.Subject = "Hello World";
            mail.Body = @"Hello";
           // try
           // {
                smtp.Send(mail);
            //  }
            //  catch (SmtpException e)
            //  {
            this.salida = "asdasd"; //e.Message;
          //  }
          //  finally
          //   {
            smtp.Dispose();
        //    }

          
        }
        


    }
    
}