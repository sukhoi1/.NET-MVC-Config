using System.Configuration;

namespace ConfigMvc.Configuration
{
    public class NewUserDefaultsSection : ConfigurationSection
    {
        [ConfigurationProperty("city", IsRequired = true)]
        public string City
        {
            get { return (string)this["city"]; }
            set { this["city"] = value; }
        }

        [ConfigurationProperty("country", DefaultValue = "DefaultCountry")]
        public string Country
        {
            get { return (string)this["country"]; }
            set { this["country"] = value; }
        }

        [ConfigurationProperty("language")]
        public string Language
        {
            get { return (string)this["language"]; }
            set { this["language"] = value; }
        }

        [ConfigurationProperty("regionCode")]
        [IntegerValidator(MaxValue = 5, MinValue = 0)]
        public int RegionCode
        {
            get { return (int)this["regionCode"]; }
            set { this["regionCode"] = value; }
        }
    }
}