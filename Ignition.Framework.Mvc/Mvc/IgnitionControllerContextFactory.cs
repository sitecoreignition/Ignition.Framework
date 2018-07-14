namespace Ignition.Framework.Mvc.Mvc
{
	public class IgnitionControllerContextFactory : IIgnitionControllerContextFactory
	{
		public IgnitionControllerContext GetInstance(ControllerContext controllerContext)
		{
			return new IgnitionControllerContext(controllerContext);
		}
	}
}
