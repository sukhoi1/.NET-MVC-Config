using System.Configuration;

namespace ConfigMvc.Configuration.Collection
{
    public class PlaceCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement() // abstract
        {
            return new Place();
        }

        protected override object GetElementKey(ConfigurationElement element) // abstract
        {
            return ((Place)element).Code;
        }

        public new Place this[string key]
        {
            get { return (Place)BaseGet(key); } // <- just because BaseGet was marked as protected we have to add one more class implementation for custom collection
        }
    }
}