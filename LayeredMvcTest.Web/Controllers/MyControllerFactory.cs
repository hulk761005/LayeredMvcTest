using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using LayeredMvcTest.DataAccess;
using LayeredMvcTest.Application.Services;

namespace LayeredMvcTest.Web.Controllers
{
    public class MyControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName == "Customer")
            {
                var repoistory = new CustomerRepository();
                var service = new CustomerService(repoistory);
                var controller = new CustomerController(service);
                return controller;
            }
            return base.CreateController(requestContext, controllerName);
        }
        public override void ReleaseController(IController controller)
        {
            base.ReleaseController(controller);
        }
    }
}