using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBus
{
    public class BusEmail
    {
        public static void EnviarEmail(string destinatario, string assunto, string corpo, string file)
        {
            // Lógica para enviar o email

            // Configuração do e-mail
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("contato@vgti.com.br"); // remetente
            mail.To.Add(destinatario); // destinatário
            mail.Subject = assunto;
            mail.Body = corpo;

            Attachment anexo = new Attachment(file);
            mail.Attachments.Add(anexo);
            
            // Configuração do servidor SMTP
            SmtpClient smtp = new SmtpClient("email-ssl.com.br", 587);
            smtp.Credentials = new NetworkCredential("contato@vgti.com.br", "Dye122700@@123");
            smtp.EnableSsl = true; // usar SSL

            // Enviar
            smtp.Send(mail);
        }
    }
}
