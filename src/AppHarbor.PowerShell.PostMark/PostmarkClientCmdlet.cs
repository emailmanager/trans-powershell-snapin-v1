using System.Management.Automation;
using EmailmanagerDotNet;

namespace AppHarbor.PowerShell.Emailmanager.Commands
{
	[Cmdlet(VerbsCommon.Get, "EmailmanagerClient")]
	public class EmailmanagerClientCmdlet : Cmdlet
	{
		[Parameter(Position = 0)]
		[ValidateNotNullOrEmpty]
		public string ServerToken
		{
			get;
			set;
		}

		protected override void ProcessRecord()
		{
			var emailmanagerClient = new EmailmanagerClient(ServerToken);
			WriteObject(emailmanagerClient);
		}
	}
}
