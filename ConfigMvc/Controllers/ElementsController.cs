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

        public ActionResult Third()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            var config = WebConfigurationManager.OpenWebConfiguration("~/Views/FolderConfig");
            foreach (string key in config.AppSettings.Settings.AllKeys) //Note: not directly WebConfigurationManager!
            {
                dict.Add(key, $"{key} {config.AppSettings.Settings[key].Value}");
            }

            // 'Folder/Web.config' settings will be merged
            return View("~/Views/FolderConfig/many.cshtml", dict);
        }
        private ActionResult Private()
        {
            return View("~/Views/Home/Ccs.cshtml", this.Dict());
        }

        private Dictionary<string, string> Dict()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string key in WebConfigurationManager.AppSettings.Keys)
            {
                dict.Add(key, $"{key} {WebConfigurationManager.AppSettings[key]}"); //Note: WebConfigurationManager!
            }

            return dict;
        }
    }
}