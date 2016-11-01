using System.Configuration;

namespace ConfigMvc.Configuration.Collection
{
    public class PlaceSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(PlaceCollection))]
        public PlaceCollection Places
        {
            get { return (PlaceCollection)base[string.Empty]; }
        }

        [ConfigurationProperty("default")]
        public string Default
        {
            get { return (string)base["default"]; }
            set { base["default"] = value; }
        }
    }
}