using System.Data.Entity;
using TestCMS.Models;

public class AppDbContext : DbContext
{
	public AppDbContext() : base("DefaultConnection")
	{
	}

	public DbSet<Customer> Customers { get; set; }

	protected override void OnModelCreating(DbModelBuilder modelBuilder)
	{
		// Configure Fluent API if necessary
		modelBuilder.Entity<Customer>().HasKey(c => c.Id);

		base.OnModelCreating(modelBuilder);
	}
}
