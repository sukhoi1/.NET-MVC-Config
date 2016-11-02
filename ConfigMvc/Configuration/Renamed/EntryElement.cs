using System.Configuration;

namespace ConfigMvc.Configuration.Renamed
{
    public class EntryElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get
            {
                return (string)base["name"];
            }
        }

        [ConfigurationProperty("value", IsRequired = true, IsKey = true)]
        public string Value
        {
            get
            {
                return (string)base["value"];
            }
        }
    }
}