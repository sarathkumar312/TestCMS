using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TestCMS.Interfaces;
using TestCMS.Models;

public class CustomerRepository : ICustomerRepository
{
	private readonly AppDbContext _context;

	public CustomerRepository(AppDbContext context)
	{
		_context = context;
	}

	public IEnumerable<Customer> GetAllCustomers()
	{
		return _context.Customers.ToList();
	}

	public Customer GetCustomerById(int id)
	{
		return _context.Customers.Find(id);
	}

	public void AddCustomer(Customer customer)
	{
		_context.Customers.Add(customer);
		_context.SaveChanges();
	}

	public void UpdateCustomer(Customer customer)
	{
		_context.Entry(customer).State = EntityState.Modified;
		_context.SaveChanges();
	}

	public void DeleteCustomer(int id)
	{
		var customer = _context.Customers.Find(id);
		if (customer != null)
		{
			_context.Customers.Remove(customer);
			_context.SaveChanges();
		}
	}
}