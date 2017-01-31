// sendmail example using mono .Net C#
// this example using ssl enable

using System;
using System.Net.Mail;

namespace SmtpClientExample
{
	public class SendMail
	{
		string smtp;
		string username;
		string password;
		int port;


		public SendMail(string smtp, string username, string password, int port)
		{
			this.smtp = smtp;
			this.username = username;
			this.password = password;
			this.port = port;
		}

		public bool Send(MailMessage message)
		{
			try
			{
				var client = new System.Net.Mail.SmtpClient(smtp, port);
				client.EnableSsl = true;
				client.UseDefaultCredentials = false;
				client.EnableSsl = true;
				client.Credentials = new System.Net.NetworkCredential(username, password);
				client.Send(message);
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				return false;
			}
		}
	}
}