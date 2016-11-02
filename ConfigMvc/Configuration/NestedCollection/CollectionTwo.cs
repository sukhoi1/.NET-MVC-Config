using System.Configuration;

namespace ConfigMvc.Configuration.NestedCollection
{
    public class CollectionTwo : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ElementTwo();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ElementTwo)element).One;
        }

        public new ElementTwo this[string key]
        {
            get { return (ElementTwo)BaseGet(key); }
        }
    }
}