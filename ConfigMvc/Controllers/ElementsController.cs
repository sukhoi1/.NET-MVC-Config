using System.Collections.Generic;
using System.Web.Configuration;
using System.Web.Mvc;

namespace ConfigMvc.Controllers
{
    public class ElementsController : Controller
    {
        public ActionResult Index()
        {
            return this.Private(); // Belarus
        }

        public ActionResult Another()
        {
            return this.Private(); // UK
        }

        private ActionResult Private()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string key in WebConfigurationManager.AppSettings.Keys)
            {
                dict.Add(key, $"{key} {WebConfigurationManager.AppSettings[key]}");
            }

            return View("~/Views/Home/Ccs.cshtml", dict);
        }
    }
}