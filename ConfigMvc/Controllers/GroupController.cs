using System.Collections.Generic;
using System.Web.Configuration;
using System.Web.Mvc;
using ConfigMvc.Configuration.Collection;
using ConfigMvc.Configuration.Group;

namespace ConfigMvc.Controllers
{
    public class GroupController : Controller
    {
        public ActionResult Index()
        {
            Dictionary<string, string> configData = new Dictionary<string, string>();

            CustomDefaults cDefaults = WebConfigurationManager.OpenWebConfiguration("/").GetSectionGroup("customDefaults") as CustomDefaults;
            foreach (Place place in cDefaults.Places.Places)
            {
                configData.Add(place.Code, $"{place.City} {place.Country}");
            }

            return View("~/Views/Home/Ccs.cshtml", configData);
        }

        public ActionResult Single()
        {
            PlaceSection section = WebConfigurationManager.GetWebApplicationSection("customDefaults/places") as PlaceSection;
            Place defaultPlace = section.Places[section.Default];
            return this.View("~/Views/Home/DisplaySingle.cshtml", (object)string.Format($"The default place is: {defaultPlace.City}"));
        }
    }
}