using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Web.Mvc;
using ConfigMvc.Configuration.NestedCollection;

namespace ConfigMvc.Controllers
{
    public class NestedController : Controller
    {
        private Random rnd = new Random();

        public ActionResult Index()
        {
            Dictionary<string, string> configData = new Dictionary<string, string>();

            Group group = WebConfigurationManager.OpenWebConfiguration("/").GetSectionGroup("group") as Group;
            foreach (ElementOne element in group.Section.CollectionOne)
            {
                configData.Add(element.Code + $"{rnd.Next()}", $"{element.City} {element.Country}");

                // level 2
                foreach (ElementTwo item in element.Item)
                {
                    configData.Add($"> {rnd.Next()}:", $"{item.One} {item.Two}");
                }
            }

            return View("~/Views/Home/Ccs.cshtml", configData);
        }

        public ActionResult Single()
        {
            Dictionary<string, string> configData = new Dictionary<string, string>();

            Section section = WebConfigurationManager.GetWebApplicationSection("group/section") as Section;
            CollectionTwo collectionTwo = section.CollectionOne[section.Attr].Item;

            configData.Add(section.Attr, $"The quantity is: {collectionTwo.Count}");

            // level 2
            foreach (ElementTwo element in collectionTwo)
            {
                configData.Add($"> {rnd.Next()}:", $"{element.One} {element.Two}");
            }

            return this.View("~/Views/Home/Ccs.cshtml", configData);
        }
    }
}