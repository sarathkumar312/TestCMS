using System.Collections.Generic;
using TestCMS.Models;

namespace TestCMS.Interfaces
{
	public interface ICustomerRepository
	{
		IEnumerable<Customer> GetAllCustomers();
		Customer GetCustomerById(int id);
		void AddCustomer(Customer customer);
		void UpdateCustomer(Customer customer);
		void DeleteCustomer(int id);
	}
}