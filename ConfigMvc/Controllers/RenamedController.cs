using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using ConfigMvc.Configuration.Renamed;

namespace ConfigMvc.Controllers
{
    public class RenamedController : Controller
    {
        public ActionResult Index()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            MySection section = (MySection)ConfigurationManager.GetSection("mySection");
            foreach (EntryElement item in section.MyCollection)
            {
                dict.Add(item.Name, item.Value);
            }

            return View("~/Views/Home/Ccs.cshtml", dict);
        }

        public ActionResult Single()
        {
            MySection section = (MySection)ConfigurationManager.GetSection("mySection");
            return View("~/Views/Home/DisplaySingle.cshtml", (object)section.MyCollection[section.MyCollection.Default].Value);
        }
    }
}