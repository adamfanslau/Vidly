using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "John Smith", Id = 1},
                new Customer { Name = "James Bond", Id = 2}
            };
        // GET: Customers
        public ActionResult Index()
        {
            

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            Customer customer1 = new Customer();
            
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    customer1 = customer;
                }
            }
            
            return View(customer1);
        }
    }
}