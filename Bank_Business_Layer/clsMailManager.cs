using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Http.Headers;
using System.Net;

namespace Bank_Business_Layer
{
    public class clsMailManager
    {
        static public void Send(string ReceiverMail, string Subject, string Body)
        {
            string fromMail = "houdaifa.bank@gmail.com";
            string fromPassword = "elhyurnscytlktfk";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = Subject;
            message.To.Add(new MailAddress(ReceiverMail));
            message.Body = Body;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }

    }
}
