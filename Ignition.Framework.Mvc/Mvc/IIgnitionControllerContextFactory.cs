namespace Ignition.Framework.Mvc.Mvc
{
	public interface IIgnitionControllerContextFactory
	{
		IgnitionControllerContext GetInstance(ControllerContext controllerContext);
	}
}
