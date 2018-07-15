using Platform = Sitecore;
namespace Ignition.Framework.Sitecore
{
	public class SitecoreSettingsFactory : ISitecoreSettingsFactory
	{
		public string GetSitecoreSetting(string key)
		{
			return Platform.Configuration.Settings.GetSetting(key);
		}

		public string GetSitecoreSetting(string key, string arg)
		{
			return Platform.Configuration.Settings.GetSetting(key, arg);
		}
	}
}
