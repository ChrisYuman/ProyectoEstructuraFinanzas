using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraFinanzas
{
    public static class EmailSender
    {
        // Configuración del servidor SMTP y credenciales
        private static readonly string SmtpServer = "smtp.gmail.com"; // Por ejemplo, puedes usar el servidor de Gmail
        private static readonly int SmtpPort = 587; // Puerto para Gmail
        private static readonly string SmtpUsername = "finanzasproc@gmail.com"; 
        private static readonly string SmtpPassword = "aaup mrzl yzjs egtt"; 

        public static void SendPaymentReminder(string destinatario, string asunto, string cuerpo)
        {
            try
            {
                // Configuración del cliente SMTP
                SmtpClient client = new SmtpClient(SmtpServer, SmtpPort)
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(SmtpUsername, SmtpPassword),
                    EnableSsl = true
                };

                // Creación del correo electrónico
                MailMessage mailMessage = new MailMessage(SmtpUsername, destinatario)
                {
                    Subject = asunto,
                    Body = cuerpo
                };

                // Envío del correo electrónico
                client.Send(mailMessage);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error de envío de correo electrónico
                Console.WriteLine($"Error al enviar correo electrónico: {ex.Message}");
            }
        }
    }
}
