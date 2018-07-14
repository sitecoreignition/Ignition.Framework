using System;

namespace Ignition.Framework.Mvc.Mvc.Routing
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false)]
	public class PublicRouteAttribute : Attribute
	{
	}
}
