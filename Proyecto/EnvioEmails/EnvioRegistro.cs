using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

using System.Diagnostics;
using System.IO;
using System.Text;
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
        {/*
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\WINDOWS\system32\cmd.exe";


            var script = @"/c node C:\Users\sebas\udistri\octavo\Bases1\pruebaHTmlenvioemails\EnvioMensajes.js";

            var v1 = "qdqdasdasdasd";
            var v2 = "qdqdasdasdasd";

            psi.Arguments = $"\"{script}\" \"{v1}\" \"{v2}\"";


            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardInput = true;



            using (var process = Process.Start(psi))
            {
                nombre = process.StandardError.ReadToEnd();
                this.nombre = process.StandardOutput.ReadToEnd();
            }
            */
            
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
            //mail.IsBodyHtml = true;
            mail.Subject = "Registro";
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