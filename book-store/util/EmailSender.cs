using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace book_store.util
{
    public class EmailSender
    {
        public static void SendEmail(string toEmail, string username, string password)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string fromEmail = "manyakinsasha@gmail.com";
            string emailPassword = "gwpc vqnm rrmz lrqd";

            MailMessage mail = new MailMessage
            {
                From = new MailAddress(fromEmail),
                Subject = "Восстановление доступа к аккаунту",
                Body = $"Ваш логин: {username}\nВаш пароль: {password}",
                IsBodyHtml = false
            };
            mail.To.Add(toEmail);

            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort)
            {
                Credentials = new NetworkCredential(fromEmail, emailPassword),
                EnableSsl = true
            };

            smtpClient.Send(mail);
        }
    }
}
