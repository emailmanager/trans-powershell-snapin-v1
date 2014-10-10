using System.Management.Automation;

namespace AppHarbor.PowerShell.Emailmanager.Commands
{
	public class EmailmanagerSnapIn : PSSnapIn
	{
		public override string Name
		{
			get
			{
				return "AppHarbor.PowerShell.Emailmanager";
			}
		}

		public override string Vendor
		{
			get
			{
				return "AppHarbor";
			}
		}

		public override string VendorResource
		{
			get
			{
				return "EmailmanagerSnapIn,AppHarbor";
			}
		}

		public override string Description
		{
			get
			{
				return "This is a snap-in that sends email using the Emailmanager API";
			}
		}
	}
}
