using System.Configuration;

namespace ConfigMvc.Configuration.NestedCollection
{
    public class ElementTwo : ConfigurationElement
    {
        [ConfigurationProperty("one", IsRequired = true)]
        public string One
        {
            get { return (string)this["one"]; }
            set { this["one"] = value; }
        }

        [ConfigurationProperty("two", IsRequired = true)]
        public string Two
        {
            get { return (string)this["two"]; }
            set { this["two"] = value; }
        }
    }
}