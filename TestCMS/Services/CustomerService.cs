using System.Collections.Generic;
using TestCMS.Interfaces;
using TestCMS.Models;

namespace TestCMS.Services
{
	public class CustomerService
	{
		private readonly ICustomerRepository _customerRepository;

		public CustomerService(ICustomerRepository customerRepository)
		{
			_customerRepository = customerRepository;
		}

		public IEnumerable<Customer> GetAllCustomers() => _customerRepository.GetAllCustomers();

		public Customer GetCustomerById(int id) => _customerRepository.GetCustomerById(id);

		public void AddCustomer(Customer customer)
		{
			// Business logic can be added here
			_customerRepository.AddCustomer(customer);
		}

		public void UpdateCustomer(Customer customer)
		{
			_customerRepository.UpdateCustomer(customer);
		}

		public void DeleteCustomer(int id)
		{
			_customerRepository.DeleteCustomer(id);
		}
	}

}