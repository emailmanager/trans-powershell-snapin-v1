using System.Management.Automation;
using EmailmanagerDotNet;

namespace AppHarbor.PowerShell.Emailmanager.Commands
{
	[Cmdlet("Send", "EmailmanagerEmail")]
	public class SendEmailCmdlet : Cmdlet
	{
		protected override void ProcessRecord()
		{
			var message = new EmailmanagerMessage
			{
				From = From,
				To = To,
				Subject = Subject,
				HtmlBody = HtmlBody,
				TextBody = TextBody,
				ReplyTo = ReplyTo,
			};

			var response = EmailmanagerClient.SendMessage(message);
			WriteObject(response);
		}

		[Parameter(ValueFromPipeline = true)]
		[ValidateNotNullOrEmpty]
		public EmailmanagerClient EmailmanagerClient
		{
			get;
			set;
		}

		[Parameter(Position = 0, Mandatory = true)]
		[ValidateNotNullOrEmpty]
		public string From
		{
			get;
			set;
		}

		[Parameter(Position = 1, Mandatory = true)]
		[ValidateNotNullOrEmpty]
		public string To
		{
			get;
			set;
		}

		[Parameter(Position = 2, Mandatory = true)]
		[ValidateNotNullOrEmpty]
		public string Subject
		{
			get;
			set;
		}

		[Parameter(Position = 3)]
		public string HtmlBody
		{
			get;
			set;
		}

		[Parameter(Position = 4)]
		[ValidateNotNullOrEmpty]
		public string TextBody
		{
			get;
			set;
		}

		[Parameter(Position = 5)]
		public string ReplyTo
		{
			get;
			set;
		}
	}
}
