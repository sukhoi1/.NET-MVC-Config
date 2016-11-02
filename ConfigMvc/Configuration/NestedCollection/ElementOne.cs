using System.Configuration;

namespace ConfigMvc.Configuration.NestedCollection
{
    public class ElementOne : ConfigurationElement
    {
        [ConfigurationProperty("code", IsRequired = true)]
        public string Code
        {
            get { return (string)this["code"]; }
            set { this["code"] = value; }
        }

        [ConfigurationProperty("city", IsRequired = true)]
        public string City
        {
            get { return (string)this["city"]; }
            set { this["city"] = value; }
        }

        [ConfigurationProperty("country", IsRequired = true)]
        public string Country
        {
            get { return (string)this["country"]; }
            set { this["country"] = value; }
        }

        [ConfigurationProperty("collectionTwo", IsDefaultCollection = true)]
        public CollectionTwo Item
        {
            get { return (CollectionTwo)base["collectionTwo"]; }
        }
    }
}