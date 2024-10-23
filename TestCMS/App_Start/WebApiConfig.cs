using System.Web.Http;

namespace TestCMS.App_Start
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API routes
			config.MapHttpAttributeRoutes();

			// Define the default route for Web API
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{action}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}