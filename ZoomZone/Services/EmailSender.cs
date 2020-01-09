using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using MimeKit;
using System.Net.Mail;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace ZoomZone.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly string _host;
        private readonly int _port;
        private readonly bool _ssl;
        private readonly string _username;
        private readonly string _password;
        public EmailSender(string host, int port,bool ssl,string username ,string password)
        {
            _host = host;
            _port = port;
            _ssl = ssl;
            _username = username;
            _password = password;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MimeMessage();
            message.To.Add(new MailboxAddress(email));
            message.From.Add(new MailboxAddress("ZoomZone", "kamranalibeyli@gmail.com"));

            message.Subject = subject;
            message.Body = new TextPart("html")
            {
                Text = htmlMessage
            };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect(_host, _port, _ssl);
                smtp.Authenticate(_username, _password);
                await smtp.SendAsync(message);
                smtp.Disconnect(true);
            }

        }
    }
}
