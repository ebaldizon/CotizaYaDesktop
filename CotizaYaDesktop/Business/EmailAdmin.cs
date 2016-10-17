using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace CotizaYA_00
{
    class EmailAdmin
    {

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public int Port { get; set; }
        public bool SSL { get; set; }
        public string Smtp { get; set; }

        public EmailAdmin()
        {
            this.Port = 587;
            this.SSL = true;
            this.Smtp = "smtp.gmail.com";
        }

        public bool sendEmail(string username, string password, string to, string cc, string subject, string message, string path)
        {
            try
            {
                login = new NetworkCredential(username, password);
                client = new SmtpClient(this.Smtp);
                client.Port = Convert.ToInt32(this.Port);
                client.EnableSsl = this.SSL;
                client.Credentials = login;
                msg = new MailMessage { From = new MailAddress(username + this.Smtp, "", Encoding.UTF8) };
                msg.To.Add(new MailAddress(to));
                if (!string.IsNullOrEmpty(cc))
                    msg.To.Add(new MailAddress(cc));
                msg.Subject = subject;
                msg.Body = message;
                msg.BodyEncoding = Encoding.UTF8;
                msg.Attachments.Add(new Attachment(path));
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.Send(msg);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

    }
}
