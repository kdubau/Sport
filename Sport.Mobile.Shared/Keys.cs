using Microsoft.WindowsAzure.MobileServices;

namespace Sport.Mobile.Shared
{
	public class Keys
	{
		public static readonly MobileServiceAuthenticationProvider AuthenticationProvider = MobileServiceAuthenticationProvider.Google;
		public static string GoogleClientId;
		public static string GoogleServerID;
		public static readonly string MobileCenterKeyiOS = "%APPCENTER_IOS_KEY%";
        public static readonly string MobileCenterKeyAndroid = "%APPCENTER_ANDROID_KEY%";

        public static readonly string SourceCodeUrl = "https://github.com/kdubau/sport";
		public static readonly string GooglePushNotificationSenderId = "469968893431";
        public static readonly string AzureDomainLocal = "http://localhost:2077/";
        public static readonly string AzureDomainRemote = "https://xqa-sport.azurewebsites.net/";

		public static readonly string GoogleClientIdiOS = "213595153601-gsnh6gi23jp6duacm972i2sl9tkj3a9i.apps.googleusercontent.com"; //iOS App
		public static readonly string GoogleServerIdiOS = "213595153601-s10p0nmjg7sm73o81as78rms842sn80n.apps.googleusercontent.com"; //WebApp for server
		public static readonly string GoogleServerIdAndroid = "213595153601-s10p0nmjg7sm73o81as78rms842sn80n.apps.googleusercontent.com"; //WebApp for Android
        public static readonly string GoogleClientIdAndroid = GoogleServerIdAndroid; //Android auth uses the WebApp key

		public static string AzureDomain = AzureDomainRemote;
	}
}