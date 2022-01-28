using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
		public static void SendEmail(string toAddress, string subject, string body)
        {
			SendEmail(new List<string> { toAddress }, new List<string>(), subject, body);
		}

		public static void SendEmail(List<string> toAddresses, List<string> bccAddresses, string subject, string body)
        {
			MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail"), GlobalConfig.AppKeyLookup("senderDisplayName"));

			MailMessage mail = new MailMessage();
            foreach (string email in toAddresses)
            {
				mail.To.Add(email);
			}
			foreach (string email in bccAddresses)
			{
				mail.Bcc.Add(email);
			}
			mail.From = fromMailAddress;
			mail.Subject = subject;
			mail.Body = body;
			mail.IsBodyHtml = true;

			SmtpClient client = new SmtpClient();

			client.Send(mail);
		}
    }
}
