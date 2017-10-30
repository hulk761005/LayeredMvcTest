using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using LayeredMvcTest.Web.Controllers;
using LayeredMvcTest.DataAccess;

namespace LayeredMvcTest.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // 把 MVC 框架預設 Controller Factory 換掉
            var myResolver = new MyDependencyResolver();
            DependencyResolver.SetResolver(myResolver);
        }
        protected void Application_BeginRequest()
        {
            HttpContext.Current.Items["DbContext"] = new SouthwindContext();
        }
        protected void Application_EndRequest()
        {
            var db = HttpContext.Current.Items["DbContext"] as SouthwindContext;
            if (db != null)
            {
                db.Dispose();
            }
        }
    }
}
