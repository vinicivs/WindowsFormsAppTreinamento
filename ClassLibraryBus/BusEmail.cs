using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;
using System.IO;
using DocumentFormat.OpenXml.Drawing;

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

        public static void LerEmail(string caminho_)
        {
            try
            {
                using (var client = new ImapClient())
                {
                    // Conectar ao servidor IMAP (exemplo: Gmail)
                    client.Connect("email-ssl.com.br", 993, true);

                    // Autenticar
                    client.Authenticate("contato@vgti.com.br", "Dye122700@@123");

                    // Selecionar a caixa de entrada
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    // Ler os últimos 5 e-mails
                    for (int i = inbox.Count - 5; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);

                        // Mostrar assunto
                        Console.WriteLine("Assunto: " + message.Subject);

                        // Verificar anexos
                        foreach (var attachment in message.Attachments)
                        {
                            if (attachment is MimePart part)
                            {
                                string filePath = System.IO.Path.Combine(caminho_, part.FileName);
                                using (var stream = File.Create(filePath))
                                {
                                    part.Content.DecodeTo(stream);
                                }
                                Console.WriteLine("Anexo salvo: " + filePath);
                            }
                        }
                    }

                    client.Disconnect(true);
                }

                
            }
            catch (Exception ex)
            {
               throw new Exception("Erro ao ler e-mails: " + ex.Message);
            }
        }
    }
}
