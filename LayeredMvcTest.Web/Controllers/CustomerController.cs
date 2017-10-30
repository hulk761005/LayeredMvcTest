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
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            this._service = service;
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customer = _service.GetCustomerList(a => a.Id < 4);
            return View(customer);
        }
    }
}