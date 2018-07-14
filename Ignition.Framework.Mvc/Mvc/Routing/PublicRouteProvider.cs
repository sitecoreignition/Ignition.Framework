using System;
using System.Collections.Generic;

namespace Ignition.Framework.Mvc.Mvc.Routing
{
	public class PublicRouteProvider : DefaultDirectRouteProvider
	{
		private readonly string _routePrefix;

		public PublicRouteProvider(string routePrefix)
		{
			if (routePrefix == null) throw new ArgumentNullException(nameof(routePrefix));
			_routePrefix = routePrefix;
		}

		protected override string GetRoutePrefix(ControllerDescriptor controllerDescriptor)
		{
			return $"{_routePrefix}/{controllerDescriptor.ControllerName}";
		}

		protected override IReadOnlyList<IDirectRouteFactory> GetActionRouteFactories(ActionDescriptor actionDescriptor)
		{
			var publiclyRoutable = actionDescriptor.GetCustomAttributes(typeof(PublicRouteAttribute), false).Any();
			return publiclyRoutable ? new[] { new RouteAttribute(actionDescriptor.ActionName) } : null;
		}

		protected override IReadOnlyList<IDirectRouteFactory> GetControllerRouteFactories(ControllerDescriptor controllerDescriptor)
		{
			var publiclyRoutable = controllerDescriptor.GetCustomAttributes(typeof(PublicRouteAttribute), false).Any();
			return publiclyRoutable ? new[] { new RouteAttribute("{action}") } : null;
		}
	}
}
