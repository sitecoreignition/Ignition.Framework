namespace Ignition.Framework.Core.DatabaseTypes
{
	public sealed class MasterDatabaseType : IDatabaseType
	{
		public string GetDatabaseName()
		{
			return "master";
		}
	}
}
