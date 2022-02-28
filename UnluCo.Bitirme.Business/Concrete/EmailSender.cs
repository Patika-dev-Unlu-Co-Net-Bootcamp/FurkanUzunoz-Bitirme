using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Interface;

namespace UnluCo.Bitirme.Business.Concrete
{
    public class EmailSender : IEmailSender
    {
        // Our private configuration variables
        private string host;
        private int port;
        private bool enableSSL;
        private string userName;
        private string password;
        

        // Get our parameterized configuration
        public EmailSender(string host, int port, bool enableSSL, string userName, string password)
        {
            this.host = host;
            this.port = port;
            this.enableSSL = enableSSL;
            this.userName = userName;
            this.password = password;
        }

        // Use our configuration to send the email by using SmtpClient
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {

            var client = new SmtpClient(host, port)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(userName, password),
                EnableSsl = enableSSL
            };
            return client.SendMailAsync(
                new MailMessage(userName, email, subject, htmlMessage) { IsBodyHtml = true }
            );
        }

        public Task WelcomeMail(string email)
        {
            var client = new SmtpClient(host, port)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(userName, password),
                EnableSsl = enableSSL
            };
            var HtmlMessage = "Sizi aramızda görmekten mutluluk duyuyoruz. Hoşgeldiniz.";
            return client.SendMailAsync(
                new MailMessage(userName, email, "Wellcome", HtmlMessage) { IsBodyHtml = true }
            );
        }
    }
}
