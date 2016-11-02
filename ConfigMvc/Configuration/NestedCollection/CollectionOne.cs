using System.Configuration;

namespace ConfigMvc.Configuration.NestedCollection
{
    [ConfigurationCollection(typeof(ElementOne), AddItemName = "entity", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class CollectionOne : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement() // abstract
        {
            return new ElementOne();
        }

        protected override object GetElementKey(ConfigurationElement element) // abstract
        {
            return ((ElementOne)element).Code;
        }

        public new ElementOne this[string key]
        {
            get { return (ElementOne)BaseGet(key); } // <- just because BaseGet was marked as protected we have to add one more class implementation for custom collection
        }
    }
}