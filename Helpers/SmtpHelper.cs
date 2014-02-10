using System;
using System.Net;
using System.Net.Mail;

namespace ids.smtpreport
{
    public static class SmtpHelper
    {
        private static string getSubject(string instance, string subject)
        {
            if (string.IsNullOrEmpty(instance)) throw new Exception("Instance cannot be null.");
            if (string.IsNullOrEmpty(instance)) throw new Exception("Subject cannot be null.");

            return string.Format("[Powiadamiacz | {0}] {1}", instance, subject);
        }

        public static void SendTest(SmtpEntity smtp, GeneralEntity general)
        {
            if (smtp == null) throw new Exception("SMTP instance cannot be null.");
            if (general == null) throw new Exception("General instance cannot be null.");

            SmtpHelper.SendSSL(
                from: smtp.User,
                to: smtp.Receiver,
                subject: getSubject(general.InstanceName, "Wiadomość testowa"),
                smtpServer: smtp.Host,
                credentials: new System.Net.NetworkCredential(smtp.User, smtp.Pass),
                port: (int)smtp.Port,
                body: "Otrzymałeś wiadomość testową od programu Powiadamiacz.");
        }

        public static void SendReport(SmtpEntity smtp, GeneralEntity general, string checkName, string checkResult)
        {
            if (smtp == null) throw new Exception("SMTP instance cannot be null.");
            if (general == null) throw new Exception("General instance cannot be null.");
            if (string.IsNullOrEmpty(checkName) == null) throw new Exception("checkName cannot be null or empty.");
            if (string.IsNullOrEmpty(checkResult) == null) throw new Exception("checkResult cannot be null or empty.");

            SmtpHelper.SendSSL(
                from: smtp.User,
                to: smtp.Receiver,
                subject: getSubject(general.InstanceName, checkName),
                smtpServer: smtp.Host,
                credentials: new System.Net.NetworkCredential(smtp.User, smtp.Pass),
                port: (int)smtp.Port,
                body: checkResult);
        }

        public static bool SendSSL(string from, string to, string subject, string body, string smtpServer, int port, NetworkCredential credentials)
        {
            if (string.IsNullOrEmpty(from)) throw new Exception("Field 'from' cannot be null or empty.");
            if (string.IsNullOrEmpty(to)) throw new Exception("Field 'to' Cannot be null or empty.");
            if (string.IsNullOrEmpty(subject)) throw new Exception("Field 'subject' Cannot be null or empty.");
            if (string.IsNullOrEmpty(body)) throw new Exception("Field 'body' Cannot be null or empty.");
            if (string.IsNullOrEmpty(smtpServer)) throw new Exception("Field 'smtpServer' Cannot be null or empty.");
            if (credentials == null) throw new Exception("Credentials cannot be null.");


            MailMessage mail = new MailMessage(new MailAddress(from, from), new MailAddress(to, to));
            SmtpClient client = new SmtpClient();
            client.Port = port;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = smtpServer;
            client.EnableSsl = true;
            client.Credentials = credentials;
            mail.Subject = subject;
            mail.Body = body;
            client.Send(mail);
            return true;

        }
    }
}

