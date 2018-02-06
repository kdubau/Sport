
using System.Configuration;

namespace Sport.Service
{
	internal class Constants
	{
		internal static readonly string HubConnectionString = ConfigurationManager.ConnectionStrings["MS_NotificationHubConnectionString"].ConnectionString;
		internal static readonly string HubName = ConfigurationManager.AppSettings["MS_NotificationHubName"];

    }
}
