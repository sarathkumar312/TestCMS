using System.Web.Mvc;
using TestCMS.Interfaces;
using TestCMS.Models;

namespace TestCMS.Controllers
{
		public class CustomerController : Controller
		{
			private readonly ICustomerRepository _customerService;

			// Constructor Injection via Dependency Injection
			public CustomerController(ICustomerRepository customerService)
			{
				_customerService = customerService;
			}

			// GET: Customer
			public ActionResult Index()
			{
				var customers = _customerService.GetAllCustomers();
				return View(customers); // Return a View instead of Json
			}

			// GET: Customer/Details/5
			public ActionResult Details(int id)
			{
				var customer = _customerService.GetCustomerById(id);
				if (customer == null)
				{
					return HttpNotFound();
				}
				return View(customer);
			}

			// POST: Customer/Create
			[System.Web.Http.HttpPost]
			public ActionResult Create(Customer customer)
			{
				if (ModelState.IsValid)
				{
					_customerService.AddCustomer(customer);
					return RedirectToAction("Index"); // Redirect after creating a customer
				}
				return View(customer); // Show the same view if validation fails
			}

			// GET: Customer/Edit/5
			public ActionResult Edit(int id)
			{
				var customer = _customerService.GetCustomerById(id);
				if (customer == null)
				{
					return HttpNotFound();
				}
				return View(customer);
			}

			// POST: Customer/Edit/5
			[System.Web.Http.HttpPost]
			public ActionResult Edit(Customer customer)
			{
				if (ModelState.IsValid)
				{
					_customerService.UpdateCustomer(customer);
					return RedirectToAction("Index");
				}
				return View(customer);
			}

			// GET: Customer/Delete/5
			public ActionResult Delete(int id)
			{
				var customer = _customerService.GetCustomerById(id);
				if (customer == null)
				{
					return HttpNotFound();
				}
				return View(customer);
			}

			// POST: Customer/Delete/5
			[System.Web.Http.HttpPost, System.Web.Http.ActionName("Delete")]
			public ActionResult DeleteConfirmed(int id)
			{
				_customerService.DeleteCustomer(id);
				return RedirectToAction("Index");
			}
		}
}