using Microsoft.Extensions.Logging;
using System;
using System.Net.Mail;
using System.Text;

namespace ProjectCollection
{
    public class CreateMail : ICreateMail
    {
        private readonly ILogger _logger;
        public CreateMail(ILogger<CreateMail> logger)
        {
            _logger = logger;
        }
        public void CreateMessage(string sender, string receiver, string subject, string content, string password)
        {
            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(sender);
            mail.To.Add(receiver);
            mail.Subject = subject;
            mail.Body = content;

            //client.Port = 587;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(sender, password);
            client.EnableSsl = true;
            try
            {
                _logger.LogInformation("ASDFADSFFDSAFDSA");
                throw new Exception();
                //client.Send(mail);
                //MessageBox.Show("Mail was sent successfully");
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder(1024);
                sb.Append("\nSender: " + sender);
                sb.Append("\nEmpfänger: " + receiver);
                sb.Append("\nBetreff: " + subject);
                sb.Append("\nInhalt: " + content);
                //Log.Error(sb.ToString(), ex);
                _logger.LogError(ex, sb.ToString());
                //logs.LogError(ex, "Got error");
            }
        }
    }
}
