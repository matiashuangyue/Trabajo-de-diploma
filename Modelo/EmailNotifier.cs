using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Entidades;
using Modelo.Interfaces;
using COMUN;


namespace Modelo
{
    public class EmailNotifier : IObserver
    {
        public void Update(Usuario usuario)
        {
            SendMail(usuario);
        }

      

        public void SendMail(Usuario usuario)
        {

                // Crear el cuerpo del correo electrónico
                StringBuilder cuerpoMail = new StringBuilder();
                cuerpoMail.AppendLine($"Estimado/a usuario/a,{usuario.Name}");
                cuerpoMail.AppendLine();
                cuerpoMail.AppendLine("Tu informacion de usuario ha sido modificada.");
                cuerpoMail.AppendLine();
                cuerpoMail.AppendLine();
                cuerpoMail.AppendLine("Si no solicitó esta información, por favor contacte a nuestro soporte inmediatamente.");
                cuerpoMail.AppendLine();
                cuerpoMail.AppendLine("Saludos cordiales,");
                cuerpoMail.AppendLine("El equipo de soporte");
                string remitente = "Starcgcompany@gmail.com"; // Remitente del correo electrónico
                string destinatario = usuario.Mail; // Dirección de correo electrónico del destinatario

            try
            {
                // Enviar el correo electrónico
                MetodosComunes.EnviarMail(cuerpoMail, remitente, destinatario);

            } catch (Exception ex) { }

        }
    }
}
