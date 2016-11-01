using System.Collections.Generic;
using System.Web.Configuration;
using System.Web.Mvc;
using ConfigMvc.Configuration.Collection;

namespace ConfigMvc.Controllers
{
    public class CollectionController : Controller
    {
        public ActionResult Index()
        {
            Dictionary<string, string> configData = new Dictionary<string, string>();
            PlaceSection section = WebConfigurationManager.GetWebApplicationSection("places") as PlaceSection;
            foreach (Place place in section.Places)
            {
                configData.Add(place.Code, $"{place.City} {place.Country}");
            }

            return View("~/Views/Home/Ccs.cshtml", configData);
        }

        public ActionResult Single()
        {
            PlaceSection section = WebConfigurationManager.GetWebApplicationSection("places") as PlaceSection;
            Place defaultPlace = section.Places[section.Default];
            return this.View("~/Views/Home/DisplaySingle.cshtml", (object)string.Format($"The default place is: {defaultPlace.City}"));
        }
    }
}