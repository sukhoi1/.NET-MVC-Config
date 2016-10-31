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

            // reading app settings by index
            var index0 = WebConfigurationManager.AppSettings[0];
            var index1 = WebConfigurationManager.AppSettings[1];

            // reading app settings by key
            var y1 = WebConfigurationManager.AppSettings["ClientValidationEnabled"];
            var y2 = WebConfigurationManager.AppSettings["webpages:Enabled"];
            var y3 = WebConfigurationManager.AppSettings["unknown"];

            var keys = WebConfigurationManager.AppSettings.AllKeys;

            var a1 = WebConfigurationManager.GetWebApplicationSection("appSettings");
            var a2 = WebConfigurationManager.GetWebApplicationSection("runtime");
            var a3 = WebConfigurationManager.GetWebApplicationSection("system.web");
            var a4 = WebConfigurationManager.GetWebApplicationSection("runtime");

            // exception: can not cast object to string
            // string displaySetting = a4;

            // exception: The configuration is read only.
            // WebConfigurationManager.AppSettings.Add("MyCustomWebConfigSetting", "test");
            // WebConfigurationManager.AppSettings.Add("TestRemove", "B");
            // WebConfigurationManager.AppSettings.Remove("TestRemove");

            var configuration = WebConfigurationManager.OpenWebConfiguration("~/Web.config");
            var systemWeb = configuration.GetSection("system.web");
            var authentication = configuration.GetSection("system.web/authentication");
            var compilation = configuration.GetSection("system.web/compilation");

            // Q. How can I read other settings "web.settings"?
            //var systemWebServer = configuration.GetSection("system.webServer");
            //var systemWebServer2 = configuration.GetSectionGroup("system.webServer");
            //var modules = configuration.GetSection("system.webServer/modules"); // null ?
            //var modules2 = configuration.GetSectionGroup("system.webServer/modules"); // null ?
            //var validation = configuration.GetSection("system.webServer/validation"); // null ?

            // Q. How to use transformation?

            return View();
        }

        public ActionResult DisplaySingle()
        {
            return View((object)WebConfigurationManager.AppSettings["defaultLanguage"]);
        }
    }
}