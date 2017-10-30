using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LayeredMvcTest.Application.Services;

namespace LayeredMvcTest.Web.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerService _service = new CustomerService();
        // GET: Customer
        public ActionResult Index()
        {
            var customer = _service.GetCustomerList(a => a.Id < 4);
            return View(customer);
        }
    }
}