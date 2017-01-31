// send mail example using mono .Net C#
// this example using native smtp module on mono .Net
using System;
using System.Net.Mail;
using System.Text;

namespace SmtpClientExample
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// we try to use outlook email
			// * Note for gmail you must allow security from unsecured connection
			// * should enable from google account setting

			string smtp = "your smtp server"; // outlook use smtp-mail.outlook.com
			string smtpUser = "your smtp username";
			string smtpPassword = "your smtp password";
			int port = 587; // default smpt

			// create mail message object
			var mailMsg = new MailMessage();
			mailMsg.To.Add("destination mail address");
			mailMsg.From = new MailAddress("sender mail address");
			mailMsg.Subject = "Email subject";
			mailMsg.IsBodyHtml = true; // enable html body, so you can create beaurifull template in html format
			mailMsg.ReplyToList.Add("add reply address list");
			mailMsg.Body = "<p>your body email, you can add html format when sending an email</p>";
			mailMsg.SubjectEncoding = System.Text.Encoding.UTF8;
			mailMsg.BodyEncoding = System.Text.Encoding.UTF8;
			mailMsg.HeadersEncoding = System.Text.Encoding.UTF8;

			// let sending the amil
			var sendMail = new SendMail(smtp, smtpUser, smtpPassword, port);
			sendMail.Send(mailMsg);
		}
	}
}
