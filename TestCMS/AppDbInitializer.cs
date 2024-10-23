using System.Data.Entity;
using System.Linq;
using TestCMS.Models;

namespace TestCMS
{
	public class AppDbInitializer : CreateDatabaseIfNotExists<AppDbContext>
	{
		protected override void Seed(AppDbContext context)
		{
			// Seed initial data for Customers
			if (!context.Customers.Any())
			{
				context.Customers.Add(new Customer { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com" });
				context.Customers.Add(new Customer { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com" });
			}

			// You can seed other entities in a similar way

			// Save changes to the database
			context.SaveChanges();

			base.Seed(context);
		}
	}
}




