using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Routing;

namespace Ignition.Framework.Mvc.Mvc.Routing
{
	public class PublicRouteProvider : DefaultDirectRouteProvider
	{
		private readonly string _routePrefix;
		public PublicRouteProvider(string routePrefix) 
            => _routePrefix = routePrefix ?? throw new ArgumentNullException(nameof(routePrefix));
	    protected override string GetRoutePrefix(ControllerDescriptor controllerDescriptor) 
            => $"{_routePrefix}/{controllerDescriptor.ControllerName}";
	    protected override IReadOnlyList<IDirectRouteFactory> GetActionRouteFactories(ActionDescriptor actionDescriptor) 
            => actionDescriptor.GetCustomAttributes(typeof(PublicRouteAttribute), false).Any() ? 
            new[] { new RouteAttribute(actionDescriptor.ActionName) } : null;
	    protected override IReadOnlyList<IDirectRouteFactory> GetControllerRouteFactories(ControllerDescriptor controllerDescriptor) 
            => controllerDescriptor.GetCustomAttributes(typeof(PublicRouteAttribute), false).Any() ? 
            new[] { new RouteAttribute("{action}") } : null;
	}
}
