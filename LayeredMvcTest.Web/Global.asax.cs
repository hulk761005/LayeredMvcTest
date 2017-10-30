using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using LayeredMvcTest.Web.Controllers;

namespace LayeredMvcTest.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // 把 MVC 框架預設 Controller Factory 換掉
            var ctrlFactory = new MyControllerFactory();
            ControllerBuilder.Current.SetControllerFactory(ctrlFactory);
        }
    }
}
