using System.Data.Entity;
using System.Web.Http;
using TestCMS.App_Start;

namespace TestCMS
{
	public class Global
	{
		protected void Application_Start()
		{
			// Set the custom initializer for the database
			Database.SetInitializer(new AppDbInitializer());

			// Other configuration code
			GlobalConfiguration.Configure(WebApiConfig.Register);
		}

	}
}