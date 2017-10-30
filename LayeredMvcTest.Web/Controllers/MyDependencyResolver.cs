using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LayeredMvcTest.DataAccess;
using LayeredMvcTest.Application.Services;

namespace LayeredMvcTest.Web.Controllers
{
    public class MyDependencyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            System.Diagnostics.Debug.WriteLine(serviceType.FullName);
            if (serviceType == typeof(CustomerController))
            {
                var repository = new CustomerRepository();
                var customerSvc = new CustomerService(repository);
                var controller = new CustomerController(customerSvc);
                return controller;
            }
            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }
    }
}