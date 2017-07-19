using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> Customers = new List<Customer>
        {
            new Customer {Name = "John Smith", Id = 1},
            new Customer {Name = "Mary Williams", Id = 2}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new CustomersIndexViewModel
            {
                Customers = Customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Customers.Count < id)
            {
                return HttpNotFound();
            }
  
            var customer = Customers[id-1];

            return View(customer);
        }
    }
}