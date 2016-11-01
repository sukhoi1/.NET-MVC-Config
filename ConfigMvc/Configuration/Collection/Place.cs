﻿using System.Configuration;

namespace ConfigMvc.Configuration.Collection
{
    public class Place : ConfigurationElement
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
    }
}