using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ConfigMvc.Configuration.Renamed
{
    [ConfigurationCollection(typeof(EntryElement), AddItemName = "entry", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class MyCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new EntryElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            return ((EntryElement)element).Name;
        }

        [ConfigurationProperty("default", IsRequired = false)]
        public string Default
        {
            get
            {
                return (string)base["default"];
            }
        }

        public new EntryElement this[string key]
        {
            get { return (EntryElement)BaseGet(key); }
        }
    }
}