using System.Web.Mvc;
using System.Web.Configuration;

namespace ConfigMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var connectionStrings = WebConfigurationManager.ConnectionStrings;
            if (connectionStrings != null && connectionStrings.Count > 0)
            {
                var cs1 = connectionStrings[0];
                if (connectionStrings.Count == 2)
                {
                    var cs2 = connectionStrings[1];
                }
            }

            var y = WebConfigurationManager.AppSettings;
            var y1 = WebConfigurationManager.AppSettings["ClientValidationEnabled"];
            var y2 = WebConfigurationManager.AppSettings["webpages:Enabled"];
            var y3 = WebConfigurationManager.AppSettings["unknown"];

            var a1 = WebConfigurationManager.GetWebApplicationSection("appSettings");
            var a2 = WebConfigurationManager.GetWebApplicationSection("runtime");
            var a3 = WebConfigurationManager.GetWebApplicationSection("system.web");
            var a4 = WebConfigurationManager.GetWebApplicationSection("runtime");
            //var b = WebConfigurationManager.OpenWebConfiguration(@"C:\Users\anton_lyhin\Documents\visual studio 2015\Projects\ConfigMvc\ConfigMvc\Views");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}